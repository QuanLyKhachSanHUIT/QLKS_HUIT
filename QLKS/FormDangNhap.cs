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
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void chk_hienthimatkhau_CheckedChanged(object sender, EventArgs e)
        {
            // Kiểm tra trạng thái của hộp kiểm
            if (chk_hienthimatkhau.Checked)
            {
                // Nếu được chọn, hiển thị mật khẩu bằng cách thiết lập UseSystemPasswordChar thành false
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                // Nếu không được chọn, ẩn mật khẩu bằng cách thiết lập UseSystemPasswordChar thành true
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void btn_dangnhap_Click(object sender, EventArgs e)
        {

        }

        private void btn_thoat_Click(object sender, EventArgs e)
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
