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
        bool menuloaiphongExpand = false;
        bool menudichvuExpand = false;
        bool menucongnoExpand = false;
        bool menutienchiphieuthuExpand = false;
        bool sidebarExpand = false;
        private void khachsanTransition_Tick(object sender, EventArgs e)
        {
            if (menukhachsanExpand == false)
            {
                menukhachsanContainer.Height += 10;
                if (menukhachsanContainer.Height >= 230)
                {
                    menukhachsanTransition.Stop();
                    menukhachsanExpand = true;
                }
            }
            else
            {
                menukhachsanContainer.Height -= 5;
                if (menukhachsanContainer.Height <= 45)
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

        private void btnLoaiphongvaCaidat_Click(object sender, EventArgs e)
        {
            menuloaiphongTransition.Start();
        }

        private void menuloaiphongTransition_Tick(object sender, EventArgs e)
        {
            if (menuloaiphongExpand == false)
            {
                menuloaiphongContainer.Height += 10;
                if (menuloaiphongContainer.Height >= 230)
                {
                    menuloaiphongTransition.Stop();
                    menuloaiphongExpand = true;
                }
            }
            else
            {
                menuloaiphongContainer.Height -= 5;
                if (menuloaiphongContainer.Height <= 45)
                {
                    menuloaiphongTransition.Stop();
                    menuloaiphongExpand = false;
                }
            }
        }

        private void btnDichvuvaKho_Click(object sender, EventArgs e)
        {
            menudichvuvakhoTransition.Start();
        }

        private void menudichvuvakhoTransition_Tick(object sender, EventArgs e)
        {
            if (menudichvuExpand == false)
            {
                menudichvuContainer.Height += 15;
                if (menudichvuContainer.Height >= 175)
                {
                    menudichvuvakhoTransition.Stop();
                    menudichvuExpand = true;
                }
            }
            else
            {
                menudichvuContainer.Height -= 5;
                if (menudichvuContainer.Height <= 45)
                {
                    menudichvuvakhoTransition.Stop();
                    menudichvuExpand = false;
                }
            }
        }

        private void menucongnoTransition_Tick(object sender, EventArgs e)
        {
            if (menucongnoExpand == false)
            {
                menucongnoContainer.Height += 15;
                if (menucongnoContainer.Height >= 175)
                {
                    menucongnoTransition.Stop();
                    menucongnoExpand = true;
                }
            }
            else
            {
                menucongnoContainer.Height -= 5;
                if (menucongnoContainer.Height <=45)
                {
                    menucongnoTransition.Stop();
                    menucongnoExpand = false;
                }
            }
        }

        private void btnCongno_Click(object sender, EventArgs e)
        {
            menucongnoTransition.Start();
        }

        private void btntienchivaphieuthu_Click(object sender, EventArgs e)
        {
            menutienchiTransition.Start();
        }

        private void menutienchivaphieuthuTransition_Tick(object sender, EventArgs e)
        {
            if(menutienchiphieuthuExpand == false)
            {
                menutienchivaphieuthuContainer.Height += 15;
                if (menutienchivaphieuthuContainer.Height >= 150)
                {
                    menutienchiTransition.Stop();
                    menutienchiphieuthuExpand = true;
                }
            }
            else
            {
                menutienchivaphieuthuContainer.Height -= 5;
                if (menutienchivaphieuthuContainer.Height <=45)
                {
                    menutienchiTransition.Stop();
                    menutienchiphieuthuExpand=false;
                }
            }
        }

        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand == false)
            {
                sidebar.Width -= 10;
                if (sidebar.Width <= 50)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = true;    
                }
            }
            else
            {
                sidebar.Width += 10;
                if(sidebar.Width >= 260)
                {
                    sidebarTransition.Stop();
                    sidebarExpand = false;
                }
            }
        }

        private void sidebar_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            // Hiển thị hộp thoại xác nhận
            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn thoát không?", "Xác nhận thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                // Nếu người dùng chọn Yes, đóng form đăng nhập
                this.Close();
            }
            // Nếu người dùng chọn No, không thực hiện hành động gì
        }
    }
}
