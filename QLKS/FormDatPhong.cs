using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BLL;
using DAL;

namespace QLKS
{
    public partial class FormDatPhong : Form
    {
        private RoomBLL roomBLL;
        private int roomID; // ID của phòng cần hiển thị

        public FormDatPhong(int roomID)
        {
            InitializeComponent();
            this.roomID = roomID;
            roomBLL = new RoomBLL();

        }

        private void FormDatPhong_Load(object sender, EventArgs e)
        {
            LoadRoomData();
        }

        private void LoadRoomData()
        {
            RoomDTO room = roomBLL.GetRoomByID(roomID);

            if (room != null)
            {
                PopulateRoomDetails(room);
            }
            else
            {
                MessageBox.Show("Room not found.");
            }
        }

        private void PopulateRoomDetails(RoomDTO room)
        {
            lbIDPhong.Text = room.RoomID.ToString();
            lbNamePhong.Text = room.RoomName;
            lbLoaiPhong.Text = room.RoomType;
            lbLimitNguoi.Text = room.LimitPerson.ToString();
            label15.Text = room.Price.ToString(); // Hiển thị giá phòng
        }

        private void label15_Click(object sender, EventArgs e)
        {
        }


    }
}
