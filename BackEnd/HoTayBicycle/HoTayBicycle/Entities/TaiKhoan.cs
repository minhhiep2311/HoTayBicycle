using System;
using System.Collections.Generic;

#nullable disable

namespace HoTayBicycle.Entities
{
    public partial class TaiKhoan
    {
        public string IdTaiKhoan { get; set; }
        public string TenDangNhap { get; set; }
        public string MatKhau { get; set; }
        public string MaKh { get; set; }
        public string MaNv { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
