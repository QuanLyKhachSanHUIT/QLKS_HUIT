-- Bảng LoaiPhong
CREATE TABLE LoaiPhong (
    MaLoaiPhong INT PRIMARY KEY,
    TenLoaiPhong NVARCHAR(50),
    TheoGio DECIMAL(10, 2),
    QuaDem DECIMAL(10, 2),
    TheoNgay DECIMAL(10, 2),
    TheoThang DECIMAL(10, 2),
    PhuThuQuaGio DECIMAL(10, 2) ,
    SoGiuong INT,
    SoNguoi INT
);

-- Bảng Phong
CREATE TABLE Phong (
    MaPhong INT PRIMARY KEY,
    MaLoaiPhong INT,
    TenPhong NVARCHAR(50),
    TinhTrang NVARCHAR(50),
    GhiChu NVARCHAR(255) ,
    FOREIGN KEY (MaLoaiPhong) REFERENCES LoaiPhong(MaLoaiPhong)
);

-- Bảng Lau
CREATE TABLE Lau (
    MaLau INT PRIMARY KEY,
    TenLau NVARCHAR(50),
    SoPhong INT
);

-- Bảng PhongTrongLau
CREATE TABLE PhongTrongLau (
    MaLau INT,
    MaPhong INT,
    PRIMARY KEY (MaLau, MaPhong),
    FOREIGN KEY (MaLau) REFERENCES Lau(MaLau),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);

-- Bảng KhachHang
CREATE TABLE KhachHang (
    MaKhachHang INT PRIMARY KEY,
    TenKhachHang NVARCHAR(50),
    SoCCCD NVARCHAR(50),
    NamSinh DATE,
    GioiTinh NVARCHAR(10),
    DiaChi NVARCHAR(255),
    QuocTich NVARCHAR(50),
    GhiChu NVARCHAR(255) 
);

-- Bảng DatPhong
CREATE TABLE DatPhong (
    MaDatPhong INT PRIMARY KEY,
    MaKhachHang INT,
    MaPhong INT,
    NgayDen DATE,
    NgayRaDuKien DATE,
    TinhTrang NVARCHAR(50),
    PhuThuQuaGio DECIMAL(10, 2),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);

-- Bảng HoaDon
CREATE TABLE HoaDon (
    MaHoaDon INT PRIMARY KEY,
    MaDatPhong INT,
    NgayLapHoaDon DATE,
    TongTien DECIMAL(10, 2),
    TrangThai NVARCHAR(50),
    FOREIGN KEY (MaDatPhong) REFERENCES DatPhong(MaDatPhong)
);

-- Bảng ChiTietDichVu
CREATE TABLE ChiTietDichVu (
    MaChiTietDichVu INT PRIMARY KEY,
    MaHoaDon INT,
    MaDV INT,
    SoLuong INT,
    GiaBan DECIMAL(10, 2),
    ThanhTien AS (GiaBan * SoLuong) PERSISTED,
    FOREIGN KEY (MaHoaDon) REFERENCES HoaDon(MaHoaDon),
    FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV)
);


-- Bảng DanhSachKhachHangDangO
CREATE TABLE DanhSachKhachHangDangO (
    MaKhachHang INT,
    MaPhong INT,
    NgayDen DATE,
    NgayRaDuKien DATE,
    PRIMARY KEY (MaKhachHang, MaPhong),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);

-- Bảng DanhSachKhachHangDatPhong
CREATE TABLE DanhSachKhachHangDatPhong (
    CodeBook INT PRIMARY KEY,
    MaKhachHang INT,
    MaPhong INT,
    CheckIn DATE,
    CheckOut DATE,
    MaLoaiPhong INT,
    Gia DECIMAL(10, 2),
    TinhTrang NVARCHAR(50),
    FOREIGN KEY (MaKhachHang) REFERENCES KhachHang(MaKhachHang),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
    FOREIGN KEY (MaLoaiPhong) REFERENCES LoaiPhong(MaLoaiPhong)
);

-- Bảng NhomQuyen
CREATE TABLE NhomQuyen (
    MaQuyen INT PRIMARY KEY,
    TenQuyen NVARCHAR(50)
);

-- Bảng NhanVien
CREATE TABLE NhanVien (
    MaNV INT PRIMARY KEY,
    TenTaiKhoan NVARCHAR(50),
    TenNV NVARCHAR(50),
    MaQuyen INT,
    FOREIGN KEY (MaQuyen) REFERENCES NhomQuyen(MaQuyen)
);

-- Bảng LoaiDV
CREATE TABLE LoaiDV (
    MaLoaiDV INT PRIMARY KEY,
    TenDV NVARCHAR(50)
);

-- Bảng DichVu
CREATE TABLE DichVu (
    MaDV INT PRIMARY KEY,
    MaLoaiDV INT,
    TenDoUong NVARCHAR(50),
    GiaBan DECIMAL(10, 2),
    SLTonDauKi INT,
    SLNhapTrongKy INT,
    SLDaBan INT,
    DoanhThuTrongKi DECIMAL(10, 2),
    SLTonCuoiKi AS (SLTonDauKi + SLNhapTrongKy - SLDaBan) PERSISTED,
    FOREIGN KEY (MaLoaiDV) REFERENCES LoaiDV(MaLoaiDV)
);

-- Bảng DVDaBan
CREATE TABLE DVDaBan (
    ThoiGianDV DATETIME,
    MaDV INT,
    GiaBan DECIMAL(10, 2),
    SLuongDV INT,
    SoTien DECIMAL(10, 2),
    MaPhong INT,
    MaNV INT,
    PRIMARY KEY (ThoiGianDV, MaDV, MaPhong),
    FOREIGN KEY (MaDV) REFERENCES DichVu(MaDV),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);

-- Bảng ThongKePhieuThu
CREATE TABLE ThongKePhieuThu (
    MaPhieuThu INT PRIMARY KEY,
    DienGiaiPhieuThu NVARCHAR(255),
    GhiChu NVARCHAR(255),
    SoTien DECIMAL(10, 2),
    HinhThuc NVARCHAR(50),
    NguoiTra NVARCHAR(50),
    NguoiTaoPhieu NVARCHAR(50)
);

-- Bảng ThongKePhieuChi
CREATE TABLE ThongKePhieuChi (
    MaPhieuChi INT PRIMARY KEY,
    NgayChungTu DATE,
    NgayTao DATE,
    DienGiaiChiPhi NVARCHAR(255),
    SoTien DECIMAL(10, 2),
    HinhThucTT NVARCHAR(50),
    LoaiChiPhi NVARCHAR(50),
    NguoiNhan NVARCHAR(50),
    NguoiTao NVARCHAR(50),
    GhiChu NVARCHAR(255)
);

-- Bảng DanhSachHoaDonNo
CREATE TABLE DanhSachHoaDonNo (
    MaHD INT PRIMARY KEY,
    MaPhong INT,
    TenKH NVARCHAR(50),
    ThoiGianNhanPhong DATETIME,
    TraPhongLuc DATETIME,
    KhoanKhac DECIMAL(10, 2),
    TraTruoc DECIMAL(10, 2),
    TongCong DECIMAL(10, 2),
    TrangThai NVARCHAR(50),
    HinhThuc NVARCHAR(50),
    NhanVienCheckIn NVARCHAR(50),
    NhanVienCheckOut NVARCHAR(50),
    FOREIGN KEY (MaPhong) REFERENCES Phong(MaPhong)
);

-- Bảng DoanhThuTheoHoaDon
CREATE TABLE DoanhThuTheoHoaDon (
    MaHD INT PRIMARY KEY,
    ThoiGianNhanPhong DATETIME,
    TraPhongLuc DATETIME,
    KhoanKhac DECIMAL(10, 2),
    TongCong DECIMAL(10, 2),
    TrangThai NVARCHAR(50),
    HinhThucTT NVARCHAR(50),
    NhanVienCheckIn NVARCHAR(50),
    NhanVienCheckOut NVARCHAR(50),
    FOREIGN KEY (MaHD) REFERENCES DanhSachHoaDonNo(MaHD)
);

-- Bảng DoanhThuTheoNgay
CREATE TABLE DoanhThuTheoNgay (
    Ngay DATE PRIMARY KEY,
    DaCheckIn INT,
    Booking INT,
    DaBan INT,
    CongSuat DECIMAL(10, 2),
    GiaBanTrungBinh DECIMAL(10, 2),
    DoanhThuPhong DECIMAL(10, 2),
    PhuThuQuaGio DECIMAL(10, 2)
);

-- Bảng ThongKeTaiKhoan
CREATE TABLE ThongKeTaiKhoan (
    MaNV INT PRIMARY KEY,
    SoNgayDaCheckIn INT,
    SoNgayDaCheckOut INT,
    DoanhThuPhong INT,
    ThuKhac DECIMAL(10, 2),
    TienDichVu DECIMAL(10, 2),
    TienThanhToan DECIMAL(10, 2),
    NhanVienNhanPhong NVARCHAR(50),
    NhanVienTraPhong NVARCHAR(50),
    FOREIGN KEY (MaNV) REFERENCES NhanVien(MaNV)
);
-- Bảng LoaiPhong
INSERT INTO LoaiPhong (MaLoaiPhong, TenLoaiPhong, TheoGio, QuaDem, TheoNgay, TheoThang, PhuThuQuaGio, SoGiuong, SoNguoi)
VALUES 
(1, N'Phòng Đơn', 100000, 300000, 500000, 10000000, 50000, 1, 1),
(2, N'Phòng Đôi', 200000, 600000, 1000000, 20000000, 100000, 2, 2);

-- Bảng Phong
INSERT INTO Phong (MaPhong, MaLoaiPhong, TenPhong, TinhTrang, GhiChu)
VALUES 
(1, 1, N'Phòng 101', N'Trống', N''),
(2, 2, N'Phòng 102', N'Có khách', N'Khách đến ngày 20/07/2024');

-- Bảng Lau
INSERT INTO Lau (MaLau, TenLau, SoPhong)
VALUES 
(1, N'Tầng 1', 10),
(2, N'Tầng 2', 10);

-- Bảng PhongTrongLau
INSERT INTO PhongTrongLau (MaLau, MaPhong)
VALUES 
(1, 1),
(1, 2),
(2, 1),
(2, 2);

-- Bảng KhachHang
INSERT INTO KhachHang (MaKhachHang, TenKhachHang, SoCCCD, NamSinh, GioiTinh, DiaChi, QuocTich, GhiChu)
VALUES 
(1, N'Nguyễn Văn A', N'0123456789', '1990-01-01', N'Nam', N'123 Đường ABC, TP.HCM', N'Việt Nam', N''),
(2, N'Tran Thi B', N'9876543210', '1995-05-05', N'Nữ', N'456 Đường XYZ, Hà Nội', N'Việt Nam', N'');

-- Bảng DatPhong
INSERT INTO DatPhong (MaDatPhong, MaKhachHang, MaPhong, NgayDen, NgayRaDuKien, TinhTrang, PhuThuQuaGio)
VALUES 
(1, 1, 1, '2024-07-20', '2024-07-22', N'Đã đặt', 100000),
(2, 2, 2, '2024-07-21', '2024-07-23', N'Đã đặt', 150000);

-- Bảng HoaDon
INSERT INTO HoaDon (MaHoaDon, MaDatPhong, NgayLapHoaDon, TongTien, TrangThai)
VALUES 
(1, 1, '2024-07-22', 1000000, N'Chưa thanh toán'),
(2, 2, '2024-07-23', 1500000, N'Chưa thanh toán');

-- Bảng ChiTietDichVu
INSERT INTO ChiTietDichVu (MaChiTietDichVu, MaHoaDon, MaDV, SoLuong, GiaBan)
VALUES 
(1, 1, 1, 2, 50000),
(2, 2, 2, 1, 100000);

-- Bảng DanhSachKhachHangDangO
INSERT INTO DanhSachKhachHangDangO (MaKhachHang, MaPhong, NgayDen, NgayRaDuKien)
VALUES 
(1, 1, '2024-07-20', '2024-07-22'),
(2, 2, '2024-07-21', '2024-07-23');

-- Bảng DanhSachKhachHangDatPhong
INSERT INTO DanhSachKhachHangDatPhong (CodeBook, MaKhachHang, MaPhong, CheckIn, CheckOut, MaLoaiPhong, Gia, TinhTrang)
VALUES 
(1, 1, 1, '2024-07-20', '2024-07-22', 1, 500000, N'Đã đặt'),
(2, 2, 2, '2024-07-21', '2024-07-23', 2, 1000000, N'Đã đặt');

-- Bảng NhomQuyen
INSERT INTO NhomQuyen (MaQuyen, TenQuyen)
VALUES 
(1, N'Quản lý'),
(2, N'Nhân viên');

-- Bảng NhanVien
INSERT INTO NhanVien (MaNV, TenTaiKhoan, TenNV, MaQuyen)
VALUES 
(1, N'admin', N'Nguyễn Văn Admin', 1),
(2, N'user', N'Tran Thi User', 2);

-- Bảng LoaiDV
INSERT INTO LoaiDV (MaLoaiDV, TenDV)
VALUES 
(1, N'Nước uống'),
(2, N'Đồ ăn');

-- Bảng DichVu
INSERT INTO DichVu (MaDV, MaLoaiDV, TenDoUong, GiaBan, SLTonDauKi, SLNhapTrongKy, SLDaBan, DoanhThuTrongKi)
VALUES 
(1, 1, N'Coca Cola', 10000, 50, 100, 30, 300000),
(2, 2, N'Bánh mì', 20000, 20, 50, 10, 400000);

-- Bảng DVDaBan
INSERT INTO DVDaBan (ThoiGianDV, MaDV, GiaBan, SLuongDV, SoTien, MaPhong, MaNV)
VALUES 
('2024-07-20 10:00:00', 1, 10000, 2, 20000, 1, 1),
('2024-07-21 11:00:00', 2, 20000, 1, 20000, 2, 2);

-- Bảng ThongKePhieuThu
INSERT INTO ThongKePhieuThu (MaPhieuThu, DienGiaiPhieuThu, GhiChu, SoTien, HinhThuc, NguoiTra, NguoiTaoPhieu)
VALUES 
(1, N'Thu tiền phòng', N'', 500000, N'Tiền mặt', N'Nguyễn Văn A', N'Nguyễn Văn Admin'),
(2, N'Thu tiền dịch vụ', N'', 100000, N'Tiền mặt', N'Tran Thi B', N'Tran Thi User');

-- Bảng ThongKePhieuChi
INSERT INTO ThongKePhieuChi (MaPhieuChi, NgayChungTu, NgayTao, DienGiaiChiPhi, SoTien, HinhThucTT, LoaiChiPhi, NguoiNhan, NguoiTao, GhiChu)
VALUES 
(1, '2024-07-20', '2024-07-20', N'Mua văn phòng phẩm', 200000, N'Tiền mặt', N'Văn phòng phẩm', N'Nguyễn Văn A', N'Nguyễn Văn Admin', N''),
(2, '2024-07-21', '2024-07-21', N'Trả tiền điện', 500000, N'Chuyển khoản', N'Điện lực', N'Tran Thi B', N'Tran Thi User', N'');

-- Bảng DanhSachHoaDonNo
INSERT INTO DanhSachHoaDonNo (MaHD, MaPhong, TenKH, ThoiGianNhanPhong, TraPhongLuc, KhoanKhac, TraTruoc, TongCong, TrangThai, HinhThuc, NhanVienCheckIn, NhanVienCheckOut)
VALUES 
(1, 1, N'Nguyễn Văn A', '2024-07-20 14:00:00', '2024-07-22 12:00:00', 0, 500000, 1000000, N'Chưa thanh toán', N'Tiền mặt', N'Nguyễn Văn Admin', N'Tran Thi User'),
(2, 2, N'Tran Thi B', '2024-07-21 14:00:00', '2024-07-23 12:00:00', 0, 1000000, 1500000, N'Chưa thanh toán', N'Tiền mặt', N'Nguyễn Văn Admin', N'Tran Thi User');
