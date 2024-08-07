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
    public partial class FormnQLNhanVien : Form
    {
        public FormnQLNhanVien()
        {
            InitializeComponent();
        }

        private void FormnQLNhanVien_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hotelManagementDataSet.STAFF' table. You can move, or remove it, as needed.
            this.sTAFFTableAdapter.Fill(this.hotelManagementDataSet.STAFF);
            // TODO: This line of code loads data into the 'hotelManagementDataSet.USP_LoadFullRoomType' table. You can move, or remove it, as needed.
            this.uSP_LoadFullRoomTypeTableAdapter.Fill(this.hotelManagementDataSet.USP_LoadFullRoomType);

        }


    }
}
