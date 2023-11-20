using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuXuatDTO
    {
        public int id { get; set; }
        public DateTime NgayXuat { get; set; }
        public int TongSoLuong { get; set; }
        public int TongTien { get; set; }
        public int TinhTrang { get; set; }
        public bool TrangThai { get; set; }
        public String idKhachHang { get; set; }
        public int idNhanVien { get; set; }
    }
}
