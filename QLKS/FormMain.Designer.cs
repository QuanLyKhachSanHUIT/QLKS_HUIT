namespace QLKS
{
    partial class FormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxchinhKichThuoc1 = new themControls.PictureBoxchinhKichThuoc();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnkhachsan1 = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btnSodokhachsan = new System.Windows.Forms.Button();
            this.btnLoaiPhongvaCaidat = new System.Windows.Forms.Button();
            this.btnDichvuvaKho = new System.Windows.Forms.Button();
            this.btnCongno = new System.Windows.Forms.Button();
            this.btnTienchivaPhieuthu = new System.Windows.Forms.Button();
            this.btnDoanhthu = new System.Windows.Forms.Button();
            this.btnThongke = new System.Windows.Forms.Button();
            this.btnKhachhang = new System.Windows.Forms.Button();
            this.btnNhanvien = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menukhachsanContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.menukhachsanTransition = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxchinhKichThuoc1)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.menukhachsanContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(89, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "SKYHOTEL";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1037, 44);
            this.panel1.TabIndex = 3;
            // 
            // pictureBoxchinhKichThuoc1
            // 
            this.pictureBoxchinhKichThuoc1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxchinhKichThuoc1.Image")));
            this.pictureBoxchinhKichThuoc1.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxchinhKichThuoc1.Name = "pictureBoxchinhKichThuoc1";
            this.pictureBoxchinhKichThuoc1.Size = new System.Drawing.Size(83, 44);
            this.pictureBoxchinhKichThuoc1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxchinhKichThuoc1.TabIndex = 4;
            this.pictureBoxchinhKichThuoc1.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Silver;
            this.flowLayoutPanel1.Controls.Add(this.btnSodokhachsan);
            this.flowLayoutPanel1.Controls.Add(this.menukhachsanContainer);
            this.flowLayoutPanel1.Controls.Add(this.btnLoaiPhongvaCaidat);
            this.flowLayoutPanel1.Controls.Add(this.btnDichvuvaKho);
            this.flowLayoutPanel1.Controls.Add(this.btnCongno);
            this.flowLayoutPanel1.Controls.Add(this.btnTienchivaPhieuthu);
            this.flowLayoutPanel1.Controls.Add(this.btnDoanhthu);
            this.flowLayoutPanel1.Controls.Add(this.btnThongke);
            this.flowLayoutPanel1.Controls.Add(this.btnKhachhang);
            this.flowLayoutPanel1.Controls.Add(this.btnNhanvien);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 44);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(269, 628);
            this.flowLayoutPanel1.TabIndex = 5;
            // 
            // btnkhachsan1
            // 
            this.btnkhachsan1.BackColor = System.Drawing.Color.Black;
            this.btnkhachsan1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnkhachsan1.ForeColor = System.Drawing.Color.White;
            this.btnkhachsan1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnkhachsan1.ImageIndex = 1;
            this.btnkhachsan1.ImageList = this.imageList1;
            this.btnkhachsan1.Location = new System.Drawing.Point(3, 3);
            this.btnkhachsan1.Name = "btnkhachsan1";
            this.btnkhachsan1.Size = new System.Drawing.Size(254, 50);
            this.btnkhachsan1.TabIndex = 7;
            this.btnkhachsan1.Text = "Khách sạn";
            this.btnkhachsan1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnkhachsan1.UseVisualStyleBackColor = false;
            this.btnkhachsan1.Click += new System.EventHandler(this.btnSodokhachsan_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "phongngu.png");
            this.imageList1.Images.SetKeyName(1, "hotel.png");
            this.imageList1.Images.SetKeyName(2, "money.png");
            this.imageList1.Images.SetKeyName(3, "dichvu.png");
            this.imageList1.Images.SetKeyName(4, "congno.png");
            this.imageList1.Images.SetKeyName(5, "phieuthu.png");
            this.imageList1.Images.SetKeyName(6, "doanhthu.png");
            this.imageList1.Images.SetKeyName(7, "money.png");
            this.imageList1.Images.SetKeyName(8, "khachhang.png");
            this.imageList1.Images.SetKeyName(9, "nhanvien.png");
            this.imageList1.Images.SetKeyName(10, "nhatky.png");
            // 
            // btnSodokhachsan
            // 
            this.btnSodokhachsan.BackColor = System.Drawing.Color.Black;
            this.btnSodokhachsan.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSodokhachsan.ForeColor = System.Drawing.Color.White;
            this.btnSodokhachsan.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSodokhachsan.ImageIndex = 0;
            this.btnSodokhachsan.ImageList = this.imageList1;
            this.btnSodokhachsan.Location = new System.Drawing.Point(3, 3);
            this.btnSodokhachsan.Name = "btnSodokhachsan";
            this.btnSodokhachsan.Size = new System.Drawing.Size(254, 55);
            this.btnSodokhachsan.TabIndex = 8;
            this.btnSodokhachsan.Text = "Sơ đồ Khách sạn";
            this.btnSodokhachsan.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSodokhachsan.UseVisualStyleBackColor = false;
            // 
            // btnLoaiPhongvaCaidat
            // 
            this.btnLoaiPhongvaCaidat.BackColor = System.Drawing.Color.Black;
            this.btnLoaiPhongvaCaidat.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoaiPhongvaCaidat.ForeColor = System.Drawing.Color.White;
            this.btnLoaiPhongvaCaidat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLoaiPhongvaCaidat.ImageIndex = 2;
            this.btnLoaiPhongvaCaidat.ImageList = this.imageList1;
            this.btnLoaiPhongvaCaidat.Location = new System.Drawing.Point(3, 125);
            this.btnLoaiPhongvaCaidat.Name = "btnLoaiPhongvaCaidat";
            this.btnLoaiPhongvaCaidat.Size = new System.Drawing.Size(254, 55);
            this.btnLoaiPhongvaCaidat.TabIndex = 9;
            this.btnLoaiPhongvaCaidat.Text = "Loại phòng và Cài đặt";
            this.btnLoaiPhongvaCaidat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLoaiPhongvaCaidat.UseVisualStyleBackColor = false;
            // 
            // btnDichvuvaKho
            // 
            this.btnDichvuvaKho.BackColor = System.Drawing.Color.Black;
            this.btnDichvuvaKho.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDichvuvaKho.ForeColor = System.Drawing.Color.White;
            this.btnDichvuvaKho.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDichvuvaKho.ImageIndex = 3;
            this.btnDichvuvaKho.ImageList = this.imageList1;
            this.btnDichvuvaKho.Location = new System.Drawing.Point(3, 186);
            this.btnDichvuvaKho.Name = "btnDichvuvaKho";
            this.btnDichvuvaKho.Size = new System.Drawing.Size(254, 55);
            this.btnDichvuvaKho.TabIndex = 10;
            this.btnDichvuvaKho.Text = "Dịch vụ và Kho";
            this.btnDichvuvaKho.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDichvuvaKho.UseVisualStyleBackColor = false;
            // 
            // btnCongno
            // 
            this.btnCongno.BackColor = System.Drawing.Color.Black;
            this.btnCongno.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCongno.ForeColor = System.Drawing.Color.White;
            this.btnCongno.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCongno.ImageIndex = 4;
            this.btnCongno.ImageList = this.imageList1;
            this.btnCongno.Location = new System.Drawing.Point(3, 247);
            this.btnCongno.Name = "btnCongno";
            this.btnCongno.Size = new System.Drawing.Size(254, 55);
            this.btnCongno.TabIndex = 11;
            this.btnCongno.Text = "Công nợ";
            this.btnCongno.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCongno.UseVisualStyleBackColor = false;
            // 
            // btnTienchivaPhieuthu
            // 
            this.btnTienchivaPhieuthu.BackColor = System.Drawing.Color.Black;
            this.btnTienchivaPhieuthu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTienchivaPhieuthu.ForeColor = System.Drawing.Color.White;
            this.btnTienchivaPhieuthu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTienchivaPhieuthu.ImageIndex = 5;
            this.btnTienchivaPhieuthu.ImageList = this.imageList1;
            this.btnTienchivaPhieuthu.Location = new System.Drawing.Point(3, 308);
            this.btnTienchivaPhieuthu.Name = "btnTienchivaPhieuthu";
            this.btnTienchivaPhieuthu.Size = new System.Drawing.Size(254, 55);
            this.btnTienchivaPhieuthu.TabIndex = 12;
            this.btnTienchivaPhieuthu.Text = "Tiền chi và phiếu thu";
            this.btnTienchivaPhieuthu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTienchivaPhieuthu.UseVisualStyleBackColor = false;
            // 
            // btnDoanhthu
            // 
            this.btnDoanhthu.BackColor = System.Drawing.Color.Black;
            this.btnDoanhthu.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDoanhthu.ForeColor = System.Drawing.Color.White;
            this.btnDoanhthu.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDoanhthu.ImageIndex = 6;
            this.btnDoanhthu.ImageList = this.imageList1;
            this.btnDoanhthu.Location = new System.Drawing.Point(3, 369);
            this.btnDoanhthu.Name = "btnDoanhthu";
            this.btnDoanhthu.Size = new System.Drawing.Size(254, 55);
            this.btnDoanhthu.TabIndex = 13;
            this.btnDoanhthu.Text = "Doanh thu";
            this.btnDoanhthu.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDoanhthu.UseVisualStyleBackColor = false;
            // 
            // btnThongke
            // 
            this.btnThongke.BackColor = System.Drawing.Color.Black;
            this.btnThongke.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThongke.ForeColor = System.Drawing.Color.White;
            this.btnThongke.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThongke.ImageIndex = 7;
            this.btnThongke.ImageList = this.imageList1;
            this.btnThongke.Location = new System.Drawing.Point(3, 430);
            this.btnThongke.Name = "btnThongke";
            this.btnThongke.Size = new System.Drawing.Size(254, 55);
            this.btnThongke.TabIndex = 14;
            this.btnThongke.Text = "Thống kê";
            this.btnThongke.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThongke.UseVisualStyleBackColor = false;
            // 
            // btnKhachhang
            // 
            this.btnKhachhang.BackColor = System.Drawing.Color.Black;
            this.btnKhachhang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKhachhang.ForeColor = System.Drawing.Color.White;
            this.btnKhachhang.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnKhachhang.ImageIndex = 8;
            this.btnKhachhang.ImageList = this.imageList1;
            this.btnKhachhang.Location = new System.Drawing.Point(3, 491);
            this.btnKhachhang.Name = "btnKhachhang";
            this.btnKhachhang.Size = new System.Drawing.Size(254, 55);
            this.btnKhachhang.TabIndex = 15;
            this.btnKhachhang.Text = "Khách hàng";
            this.btnKhachhang.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnKhachhang.UseVisualStyleBackColor = false;
            // 
            // btnNhanvien
            // 
            this.btnNhanvien.BackColor = System.Drawing.Color.Black;
            this.btnNhanvien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNhanvien.ForeColor = System.Drawing.Color.White;
            this.btnNhanvien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnNhanvien.ImageIndex = 9;
            this.btnNhanvien.ImageList = this.imageList1;
            this.btnNhanvien.Location = new System.Drawing.Point(3, 552);
            this.btnNhanvien.Name = "btnNhanvien";
            this.btnNhanvien.Size = new System.Drawing.Size(254, 55);
            this.btnNhanvien.TabIndex = 16;
            this.btnNhanvien.Text = "Nhân viên";
            this.btnNhanvien.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnNhanvien.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.ImageIndex = 0;
            this.button2.ImageList = this.imageList1;
            this.button2.Location = new System.Drawing.Point(3, 59);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(254, 55);
            this.button2.TabIndex = 8;
            this.button2.Text = "Danh Sách Khách Sạn";
            this.button2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // menukhachsanContainer
            // 
            this.menukhachsanContainer.BackColor = System.Drawing.Color.Black;
            this.menukhachsanContainer.Controls.Add(this.btnkhachsan1);
            this.menukhachsanContainer.Controls.Add(this.button2);
            this.menukhachsanContainer.Controls.Add(this.button3);
            this.menukhachsanContainer.Controls.Add(this.button4);
            this.menukhachsanContainer.Location = new System.Drawing.Point(3, 64);
            this.menukhachsanContainer.Name = "menukhachsanContainer";
            this.menukhachsanContainer.Size = new System.Drawing.Size(260, 55);
            this.menukhachsanContainer.TabIndex = 11;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.White;
            this.button3.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button3.ImageIndex = 0;
            this.button3.ImageList = this.imageList1;
            this.button3.Location = new System.Drawing.Point(3, 120);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(254, 55);
            this.button3.TabIndex = 9;
            this.button3.Text = "Danh Sách Lầu/Tầng";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Black;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.White;
            this.button4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button4.ImageIndex = 10;
            this.button4.ImageList = this.imageList1;
            this.button4.Location = new System.Drawing.Point(3, 181);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(254, 55);
            this.button4.TabIndex = 10;
            this.button4.Text = "Nhật ký sử dụng";
            this.button4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // menukhachsanTransition
            // 
            this.menukhachsanTransition.Tick += new System.EventHandler(this.khachsanTransition_Tick);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1037, 672);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.pictureBoxchinhKichThuoc1);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FormMain";
            this.Text = "frmMain";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxchinhKichThuoc1)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.menukhachsanContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private themControls.PictureBoxchinhKichThuoc pictureBoxchinhKichThuoc1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnkhachsan1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btnSodokhachsan;
        private System.Windows.Forms.Button btnLoaiPhongvaCaidat;
        private System.Windows.Forms.Button btnDichvuvaKho;
        private System.Windows.Forms.Button btnCongno;
        private System.Windows.Forms.Button btnTienchivaPhieuthu;
        private System.Windows.Forms.Button btnDoanhthu;
        private System.Windows.Forms.Button btnThongke;
        private System.Windows.Forms.Button btnKhachhang;
        private System.Windows.Forms.Button btnNhanvien;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.FlowLayoutPanel menukhachsanContainer;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Timer menukhachsanTransition;
    }
}

