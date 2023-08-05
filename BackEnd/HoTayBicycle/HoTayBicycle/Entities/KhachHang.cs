using System;
using System.Collections.Generic;

#nullable disable

namespace HoTayBicycle.Entities
{
    public partial class KhachHang
    {
        public KhachHang()
        {
            DonThues = new HashSet<DonThue>();
            TaiKhoans = new HashSet<TaiKhoan>();
        }

        public string MaKh { get; set; }
        public string TenKh { get; set; }
        public string DiaChi { get; set; }
        public string Sdt { get; set; }
        public string SoCccd { get; set; }

        public virtual ICollection<DonThue> DonThues { get; set; }
        public virtual ICollection<TaiKhoan> TaiKhoans { get; set; }
    }
}
