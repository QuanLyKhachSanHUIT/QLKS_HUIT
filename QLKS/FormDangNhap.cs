using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using DAL;
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
            string username = txtUsername.Text;
            string password = txtPass.Text;

            int staffType;
            if (XacThucNguoiDung(username, password, out staffType))
            {
                // Chuyển hướng đến form tương ứng dựa trên loại nhân viên
                if (staffType == 1)
                {
                    FormMain formMain = new FormMain();
                    formMain.Show();
                }
                else if (staffType == 2)
                {
                    FormAD formAD = new FormAD();
                    formAD.Show();
                }
                this.Hide(); // Ẩn form đăng nhập
            }
            else
            {
                MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng. Vui lòng thử lại.", "Đăng nhập không thành công", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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

        private void FormDangNhap_Load(object sender, EventArgs e)
        {

        }

        private void btn_opensetting_Click(object sender, EventArgs e)
        {

        }
        private bool XacThucNguoiDung(string username, string password, out int staffType)
        {
            staffType = -1; // Mặc định là loại nhân viên không hợp lệ
            try
            {
                using (SqlConnection conn = new SqlConnection(ConnectionManager.GetConnectionString()))
                {
                    string query = "SELECT IDStaffType FROM STAFF WHERE UserName = @username AND PassWord = @password";
                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@username", username);
                        cmd.Parameters.AddWithValue("@password", password);

                        conn.Open();
                        object result = cmd.ExecuteScalar();

                        if (result != null)
                        {
                            staffType = Convert.ToInt32(result);
                            return true;
                        }
                        return false;
                    }
                }
            }
            catch
            {
                // Log the exception details if needed
                MessageBox.Show("Đã xảy ra lỗi khi xác thực người dùng. Vui lòng thử lại sau.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }





        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
