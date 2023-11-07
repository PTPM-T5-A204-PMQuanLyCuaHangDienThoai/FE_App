using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BaoHanhDTO
    {
        public int id { get; set; }
        public int idChiTietPhieuXuat { get; set; }
        public String LyDo { get; set; }
        public DateTime NgayBaoHanh { get; set; }
        public DateTime NgayTraHang { get; set; }
        public int idNhanVien { get; set; }
        public int idKhachHang { get; set; }
        public int ChiPhi{ get; set; }
        public bool TrangThai { get; set; }
        public int idPhieuXuat { get; set; }
    }
}
