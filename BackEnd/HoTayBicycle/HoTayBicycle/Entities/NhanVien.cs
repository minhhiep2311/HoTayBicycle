using System;
using System.Collections.Generic;

#nullable disable

namespace HoTayBicycle.Entities
{
    public partial class NhanVien
    {
        public NhanVien()
        {
            DonThues = new HashSet<DonThue>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public string MaNv { get; set; }
        public string TenNv { get; set; }
        public decimal? Luong { get; set; }
        public string ChucVu { get; set; }

        public virtual ICollection<DonThue> DonThues { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
