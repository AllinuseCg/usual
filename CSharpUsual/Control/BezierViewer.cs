﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using usual;

namespace CSharpUsual.Control
{
    class BezierViewer : UserControl
    {
        CubicBezier m_bezier;
        bool haveValue = false;
        
        public CubicBezier bezier
        {
            set
            {
                haveValue = true;
                m_bezier = value;
                this.Invalidate();
            }
            get { return m_bezier; }
        }
        float m_frequency;
        public float frequency
        {
            set
            {
                m_frequency = value;
                this.Invalidate();
            }
            get { return m_frequency; }
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (haveValue)
            {
                List<Vector2d_simple> points_alpha = new List<Vector2d_simple>();
                List<Vector2d_simple> points_t = new List<Vector2d_simple>();
                points_alpha.Add(new Vector2d_simple(0, 0));
                points_t.Add(new Vector2d_simple(0, 0));
                for (float i = frequency; i < 1; i += frequency)
                {
                    //这里是用alpha值获取，应该改为用t值获取
                    var a = bezier.getPointByAlpha(i);
                    var t = bezier.getPointByX(i);
                    points_alpha.Add(a);
                    points_t.Add(t);
                }
                points_alpha.Add(new Vector2d_simple(1, 1));
                points_t.Add(new Vector2d_simple(1, 1));
                for (int i = 0; i < points_alpha.Count - 1; i++)
                {
                    e.Graphics.DrawLine(System.Drawing.Pens.Black, Width * points_alpha[i].x, Height * (1 - points_alpha[i].y), Width * points_alpha[i + 1].x, Height * (1 - points_alpha[i + 1].y));
                    e.Graphics.DrawLine(System.Drawing.Pens.Yellow, Width * points_t[i].x, Height * (1 - points_t[i].y), Width * points_t[i + 1].x, Height * (1 - points_t[i + 1].y));
                    
                }
                var pen = new System.Drawing.Pen(System.Drawing.Color.Red, 5);
                e.Graphics.DrawLine(pen, 0, Height, Width * bezier.A.x, Height * (1 - bezier.A.y));
                e.Graphics.DrawLine(pen, Width, 0, Width * bezier.B.x, Height * (1 - bezier.B.y));
            }
            base.OnPaint(e);
        }

        public BezierViewer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            m_frequency = 0.02f;
        }
        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BezierViewer
            // 
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Name = "BezierViewer";
            this.Size = new System.Drawing.Size(255, 255);
            this.SizeChanged += new System.EventHandler(this.BezierViewer_SizeChanged);
            this.ResumeLayout(false);

        }

        private void BezierViewer_SizeChanged(object sender, EventArgs e)
        {
            this.Invalidate();
            Width = Height;
        }
    }
}
