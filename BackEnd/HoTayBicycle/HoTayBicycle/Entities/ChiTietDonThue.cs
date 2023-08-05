using System;
using System.Collections.Generic;

#nullable disable

namespace HoTayBicycle.Entities
{
    public partial class ChiTietDonThue
    {
        public string MaThue { get; set; }
        public string MaXe { get; set; }
        public int? SoLuongThue { get; set; }
        public string GhiChu { get; set; }

        public virtual DonThue MaThueNavigation { get; set; }
        public virtual XeDap MaXeNavigation { get; set; }
    }
}
