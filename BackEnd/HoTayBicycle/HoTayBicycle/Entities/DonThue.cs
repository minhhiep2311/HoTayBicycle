using System;
using System.Collections.Generic;

#nullable disable

namespace HoTayBicycle.Entities
{
    public partial class DonThue
    {
        public string MaThue { get; set; }
        public string TrangThai { get; set; }
        public string MaKh { get; set; }
        public string MaNv { get; set; }
        public string MaDonThanhToan { get; set; }

        public virtual DonThanhToan MaDonThanhToanNavigation { get; set; }
        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual NhanVien MaNvNavigation { get; set; }
    }
}
