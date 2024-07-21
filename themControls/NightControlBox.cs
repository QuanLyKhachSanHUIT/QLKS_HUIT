using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Design;

namespace themControls
{
    public class NightControlBox : UserControl
    {
        private Button btnMinimize;
        private Button btnMaximize;
        private Button btnClose;
        public NightControlBox()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.btnMinimize = new System.Windows.Forms.Button();
            this.btnMaximize = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnMinimize
            // 
            this.btnMinimize.Location = new System.Drawing.Point(0, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(30, 30);
            this.btnMinimize.TabIndex = 0;
            this.btnMinimize.Text = "-";
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Location = new System.Drawing.Point(30, 0);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(30, 30);
            this.btnMaximize.TabIndex = 1;
            this.btnMaximize.Text = "[]";
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(60, 0);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(30, 30);
            this.btnClose.TabIndex = 2;
            this.btnClose.Text = "X";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // NightControlBox
            // 
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.btnMaximize);
            this.Controls.Add(this.btnClose);
            this.Name = "NightControlBox";
            this.Size = new System.Drawing.Size(100, 30);
            this.ResumeLayout(false);

        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.FindForm().WindowState = FormWindowState.Minimized;
        }

        private void btnMaximize_Click(object sender, EventArgs e)
        {
            Form form = this.FindForm();
            if (form.WindowState == FormWindowState.Normal)
            {
                form.WindowState = FormWindowState.Maximized;
            }
            else
            {
                form.WindowState = FormWindowState.Normal;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.FindForm().Close();
        }
    }
}
