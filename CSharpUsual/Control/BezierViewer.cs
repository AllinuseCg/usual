using System;
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
        Bezier m_bezier;
        bool haveValue = false;
        
        public Bezier bezier
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
                List<Vector2d_simple> points = new List<Vector2d_simple>();
                points.Add(new Vector2d_simple(0, 0));
                for (float i = frequency; i < 1; i += frequency)
                {
                    var v = bezier.getValueAtAlpha(i);
                    //这里是用alpha值获取，应该改为用x值获取
                    points.Add(v);
                }
                points.Add(new Vector2d_simple(1, 1));

                for (int i = 0; i < points.Count - 1; i++)
                {
                    e.Graphics.DrawLine(System.Drawing.Pens.Black, Width * points[i].x, Height * (1 - points[i].y), Width * points[i + 1].x, Height * (1 - points[i + 1].y));
                }
            }
            base.OnPaint(e);
        }

        public BezierViewer()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            m_frequency = 0.1f;
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
