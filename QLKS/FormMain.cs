using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;   
using System.Windows.Forms;
using BLL;
using DAL;
using DTO;
namespace QLKS
{
    public partial class FormMain : Form
    {
        public RoomBLL roomBLL = new RoomBLL();
        private string selectedRoomID;
        private StatusRoomBLL statusRoomBLL = new StatusRoomBLL();
        private ContextMenuStrip roomContextMenu;

        public FormMain()
        {
            InitializeComponent();
            roomContextMenu = new ContextMenuStrip();
            roomContextMenu.Items.Add("Xem chi tiết phòng", null, ViewRoomDetails_Click);
            roomContextMenu.Items.Add("Nhận phòng", null, ReceiveRoom_Click);
            roomContextMenu.Items.Add("Đặt phòng", null, BookRoom_Click);
            roomContextMenu.Items.Add("Cập nhật trạng thái", null, UpdateRoomStatus_Click);
            roomContextMenu.Items.Add("Trả phòng", null, CheckoutRoom_Click);
            roomContextMenu.Items.Add("Thêm dịch vụ", null, AddService_Click);

            this.Load += FormMain_Load;
         

        }

        private void AddService_Click(object sender, EventArgs e)
        {
        }

        private void CheckoutRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Xác nhận trả phòng này: {selectedRoomID}");

        }

        private void BookRoom_Click(object sender, EventArgs e)
        {
            // Kiểm tra nếu có phòng được chọn
            if (!string.IsNullOrEmpty(selectedRoomID))
            {
                if (int.TryParse(selectedRoomID, out int roomID))
                {
                    // Lấy thông tin phòng từ RoomBLL
                    RoomDTO room = roomBLL.GetRoomByID(roomID);

                    if (room != null)
                    {
                        // Kiểm tra trạng thái phòng
                        if (room.StatusName == "Sẵn sàng")
                        {
                            // Hiển thị hộp thoại xác nhận
                            DialogResult result = MessageBox.Show($"Xác nhận đặt phòng này: {selectedRoomID}?", "Xác nhận đặt phòng", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

                            if (result == DialogResult.OK)
                            {
                                // Mở form đặt phòng với roomID
                                FormDatPhong bookRoomForm = new FormDatPhong(roomID);
                                bookRoomForm.ShowDialog(); // Sử dụng ShowDialog để mở form như một hộp thoại
                            }
                        }
                        else
                        {
                            // Thông báo phòng không thể sử dụng
                            MessageBox.Show("Phòng hiện tại không thể sử dụng hoặc đang có người ở.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin phòng.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("ID phòng không hợp lệ.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn phòng để đặt.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void UpdateRoomStatus_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Cập nhật tình trạng phòng này: {selectedRoomID}");

        }

        private void ViewRoomDetails_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(selectedRoomID))
            {
                int roomID;
                if (int.TryParse(selectedRoomID, out roomID))
                {
                    RoomDTO room = roomBLL.GetRoomByID(roomID);
                    if (room != null)
                    {
                        FormChiTietPhong detailForm = new FormChiTietPhong(room);
                        detailForm.ShowDialog(); // Sử dụng ShowDialog để mở form như một hộp thoại
                    }
                    else
                    {
                        MessageBox.Show("Không tìm thấy thông tin phòng.");
                    }
                }
                else
                {
                    MessageBox.Show("ID phòng không hợp lệ.");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn phòng để xem chi tiết.");
            }
        }

        private void ReceiveRoom_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Xác nhận đặt phòng này: {selectedRoomID}");
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            tableLayoutPanel1.Controls.Clear();
            tableLayoutPanel1.RowCount = 0;
            tableLayoutPanel1.ColumnCount = 4;

            int buttonWidth = 200;
            int buttonHeight = 100;
            int buttonsPerRow = tableLayoutPanel1.ColumnCount;

            var rooms = roomBLL.GetRooms();

            foreach (var room in rooms)
            {
                var roomButton = new Button
                {
                    Text = $"ID: {room.RoomID}\nName: {room.RoomName}\nStatus: {room.StatusName}",
                    AutoSize = false,
                    Width = buttonWidth,
                    Height = buttonHeight,
                    FlatStyle = FlatStyle.Flat,
                    Padding = new Padding(5),
                    Margin = new Padding(5),
                    TextAlign = ContentAlignment.MiddleCenter,
                  
                    Tag = room.RoomID
                };
                roomButton.Click += RoomButton_Click;

                // Set background color based on room status
                switch (room.StatusName)
                {
                    case "Đang sử dụng":
                        roomButton.BackColor = Color.Red;
                        break;
                    case "Sẵn sàng":
                        roomButton.BackColor = Color.Lime;
                        break;
                    case "Đang đợi khách":
                        roomButton.BackColor = Color.Yellow;
                        break;
                    case "Chưa dọn":
                        roomButton.BackColor = Color.Gray;
                        break;
                    default:
                        roomButton.BackColor = Color.White;
                        break;
                }

                tableLayoutPanel1.Controls.Add(roomButton);

                int totalButtons = tableLayoutPanel1.Controls.Count;
                int rows = (totalButtons + buttonsPerRow - 1) / buttonsPerRow;
                tableLayoutPanel1.RowCount = rows;

                tableLayoutPanel1.RowStyles.Clear();
                for (int i = 0; i < rows; i++)
                {
                    tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, buttonHeight + 10));
                }

                tableLayoutPanel1.ColumnStyles.Clear();
                for (int i = 0; i < tableLayoutPanel1.ColumnCount; i++)
                {
                    tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, buttonWidth + 10));
                }
            }
        }
      

        private void RoomButton_Click(object sender, EventArgs e)
        {
            /* var clickedButton = sender as Button;

             if (clickedButton != null)
             {
                 // Update selectedRoomID
                 selectedRoomID = clickedButton.Tag.ToString();
                 // Show room information
                 MessageBox.Show(clickedButton.Text, "Room Information");
             }
             else
             {
                 MessageBox.Show("No room is selected.");
             }
             */
            var clickedButton = sender as Button;

            if (clickedButton != null)
            {
                // Update selectedRoomID
                selectedRoomID = clickedButton.Tag.ToString();
                // Show context menu
                roomContextMenu.Show(Cursor.Position);
            }
            else
            {
                MessageBox.Show("No room is selected.");
            }

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

        private void button27_Click(object sender, EventArgs e)
        {
          
           
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}

