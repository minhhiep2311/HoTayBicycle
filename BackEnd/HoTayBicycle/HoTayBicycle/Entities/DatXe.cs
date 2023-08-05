using System;
using System.Collections.Generic;

#nullable disable

namespace HoTayBicycle.Entities
{
    public partial class DatXe
    {
        public string MaKh { get; set; }
        public string MaXe { get; set; }
        public int? SoLuongDat { get; set; }
        public string YeuCau { get; set; }
        public DateTime? NgayHenLay { get; set; }
        public DateTime? NgayDatXe { get; set; }

        public virtual KhachHang MaKhNavigation { get; set; }
        public virtual XeDap MaXeNavigation { get; set; }
    }
}
