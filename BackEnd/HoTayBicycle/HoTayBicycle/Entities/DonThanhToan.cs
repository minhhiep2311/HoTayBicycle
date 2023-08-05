using System;
using System.Collections.Generic;

#nullable disable

namespace HoTayBicycle.Entities
{
    public partial class DonThanhToan
    {
        public DonThanhToan()
        {
            DonThues = new HashSet<DonThue>();
        }

        public string MaDonThanhToan { get; set; }
        public int? SoNgaySd { get; set; }
        public int? SoGioSd { get; set; }
        public DateTime? NgayKetThuc { get; set; }
        public string TrangThai { get; set; }
        public decimal? TongTien { get; set; }

        public virtual ICollection<DonThue> DonThues { get; set; }
    }
}
