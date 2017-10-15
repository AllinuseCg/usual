using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpUsual.Control
{
    class BezierViewer : System.Windows.Forms.UserControl
    {
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // BezierViewer
            // 
            this.Name = "BezierViewer";
            this.Size = new System.Drawing.Size(255, 255);
            this.ResumeLayout(false);

        }
    }
}
