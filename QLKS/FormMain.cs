using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLKS
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

        }
        bool menukhachsanExpand = false;
        private void khachsanTransition_Tick(object sender, EventArgs e)
        {
            if (menukhachsanExpand == false)
            {
                menukhachsanContainer.Height += 25;
                if (menukhachsanContainer.Height >= 175)
                {
                    menukhachsanTransition.Stop();
                    menukhachsanExpand = true;
                }
            }
            else
            {
                menukhachsanContainer.Height -= 25;
                if (menukhachsanContainer.Height <= 50)
                {
                    menukhachsanTransition.Stop();
                    menukhachsanExpand = false;
                }
            }
        }

        private void btnSodokhachsan_Click(object sender, EventArgs e)
        {
            menukhachsanTransition.Start();
        }
    }
}
