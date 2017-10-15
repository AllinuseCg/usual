namespace CSharpUsual
{
    partial class BezierForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.bezierViewer = new CSharpUsual.Control.BezierViewer();
            this.x1t = new System.Windows.Forms.TextBox();
            this.y1t = new System.Windows.Forms.TextBox();
            this.x2t = new System.Windows.Forms.TextBox();
            this.y2t = new System.Windows.Forms.TextBox();
            this.x1L = new System.Windows.Forms.Label();
            this.y1L = new System.Windows.Forms.Label();
            this.x2L = new System.Windows.Forms.Label();
            this.y2L = new System.Windows.Forms.Label();
            this.fre = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // bezierViewer
            // 
            this.bezierViewer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bezierViewer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.bezierViewer.frequency = 0.1F;
            this.bezierViewer.Location = new System.Drawing.Point(0, 52);
            this.bezierViewer.Name = "bezierViewer";
            this.bezierViewer.Size = new System.Drawing.Size(309, 309);
            this.bezierViewer.TabIndex = 0;
            // 
            // x1t
            // 
            this.x1t.Location = new System.Drawing.Point(12, 1);
            this.x1t.Name = "x1t";
            this.x1t.Size = new System.Drawing.Size(100, 21);
            this.x1t.TabIndex = 1;
            this.x1t.TextChanged += new System.EventHandler(this.posChanged);
            // 
            // y1t
            // 
            this.y1t.Location = new System.Drawing.Point(141, 1);
            this.y1t.Name = "y1t";
            this.y1t.Size = new System.Drawing.Size(100, 21);
            this.y1t.TabIndex = 2;
            this.y1t.TextChanged += new System.EventHandler(this.posChanged);
            // 
            // x2t
            // 
            this.x2t.Location = new System.Drawing.Point(12, 25);
            this.x2t.Name = "x2t";
            this.x2t.Size = new System.Drawing.Size(100, 21);
            this.x2t.TabIndex = 3;
            this.x2t.TextChanged += new System.EventHandler(this.posChanged);
            // 
            // y2t
            // 
            this.y2t.Location = new System.Drawing.Point(141, 25);
            this.y2t.Name = "y2t";
            this.y2t.Size = new System.Drawing.Size(100, 21);
            this.y2t.TabIndex = 4;
            this.y2t.TextChanged += new System.EventHandler(this.posChanged);
            // 
            // x1L
            // 
            this.x1L.AutoSize = true;
            this.x1L.Location = new System.Drawing.Point(-2, 7);
            this.x1L.Name = "x1L";
            this.x1L.Size = new System.Drawing.Size(17, 12);
            this.x1L.TabIndex = 5;
            this.x1L.Text = "x1";
            // 
            // y1L
            // 
            this.y1L.AutoSize = true;
            this.y1L.Location = new System.Drawing.Point(118, 7);
            this.y1L.Name = "y1L";
            this.y1L.Size = new System.Drawing.Size(17, 12);
            this.y1L.TabIndex = 6;
            this.y1L.Text = "y1";
            // 
            // x2L
            // 
            this.x2L.AutoSize = true;
            this.x2L.Location = new System.Drawing.Point(-2, 28);
            this.x2L.Name = "x2L";
            this.x2L.Size = new System.Drawing.Size(17, 12);
            this.x2L.TabIndex = 7;
            this.x2L.Text = "x2";
            // 
            // y2L
            // 
            this.y2L.AutoSize = true;
            this.y2L.Location = new System.Drawing.Point(118, 28);
            this.y2L.Name = "y2L";
            this.y2L.Size = new System.Drawing.Size(17, 12);
            this.y2L.TabIndex = 8;
            this.y2L.Text = "y2";
            // 
            // fre
            // 
            this.fre.Location = new System.Drawing.Point(260, 12);
            this.fre.Name = "fre";
            this.fre.Size = new System.Drawing.Size(100, 21);
            this.fre.TabIndex = 9;
            this.fre.TextChanged += new System.EventHandler(this.freChanged);
            // 
            // BezierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.ClientSize = new System.Drawing.Size(384, 361);
            this.Controls.Add(this.fre);
            this.Controls.Add(this.y2L);
            this.Controls.Add(this.x2L);
            this.Controls.Add(this.y1L);
            this.Controls.Add(this.x1L);
            this.Controls.Add(this.y2t);
            this.Controls.Add(this.x2t);
            this.Controls.Add(this.y1t);
            this.Controls.Add(this.x1t);
            this.Controls.Add(this.bezierViewer);
            this.Name = "BezierForm";
            this.Text = "BezierForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Control.BezierViewer bezierViewer;
        private System.Windows.Forms.TextBox x1t;
        private System.Windows.Forms.TextBox y1t;
        private System.Windows.Forms.TextBox x2t;
        private System.Windows.Forms.TextBox y2t;
        private System.Windows.Forms.Label x1L;
        private System.Windows.Forms.Label y1L;
        private System.Windows.Forms.Label x2L;
        private System.Windows.Forms.Label y2L;
        private System.Windows.Forms.TextBox fre;
    }
}

