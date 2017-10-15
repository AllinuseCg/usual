using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpUsual
{
    public partial class BezierForm : Form
    {
        public BezierForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            bezierViewer.bezier = new usual.Bezier(new usual.Vector2d_simple(1, 0), new usual.Vector2d_simple(0, 1));
        }

        private void posChanged(object sender, EventArgs e)
        {
            float x1 = 0, y1 = 0, x2 = 0, y2 = 0;
            Console.WriteLine(x1t.Text + " " + y1t.Text + " " + x2t.Text + " " + y2t.Text);
            try
            {
                x1 = float.Parse(x1t.Text);
                y1 = float.Parse(y1t.Text);
                x2 = float.Parse(x2t.Text);
                y2 = float.Parse(y2t.Text);
            }
            catch (Exception s)
            {
                Console.WriteLine("pos error : "+s.Message);
            }
            bezierViewer.bezier = new usual.Bezier(new usual.Vector2d_simple(x1, y1), new usual.Vector2d_simple(x2, y2));


        }

        private void freChanged(object sender, EventArgs e)
        {
            float f = 0;
            Console.WriteLine("fre= " + fre.Text);
            try
            {
                f = float.Parse(fre.Text);
            }
            catch (Exception s)
            {
                Console.WriteLine("fre error : " + s.Message);
            }
            if (f != bezierViewer.frequency && f != 0)
            {
                bezierViewer.frequency = f;
            }
           
        }
    }
}
