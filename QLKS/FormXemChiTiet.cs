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

namespace QLKS
{
    public partial class FormXemChiTiet : Form
    {
        public FormXemChiTiet(RoomDTO room)
        {
            InitializeComponent();
            PopulateRoomDetails(room);
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
        private void PopulateRoomDetails(RoomDTO room)
        {
            lbIDPhong.Text = room.RoomID.ToString();
            lbNamePhong.Text = room.RoomName;
            lbLoaiPhong.Text = room.RoomType;
            lbTinhTrangPhong.Text = room.Status;
            lbLimitNguoi.Text = room.LimitPerson.ToString();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void FormXemChiTiet_Load(object sender, EventArgs e)
        {

        }
    }
}
