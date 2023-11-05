using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class PhieuNhapDTO
    {
        public int id { get; set; }
        public DateTime NgayNhap { get; set; }
        public int TongSoLuong { get; set; }
        public int TongTien { get; set; }
        public bool TinhTrang { get; set; }
        public bool TrangThai{ get; set; }
        public String idNhaCungCap { get; set; }
        public int idNhanVien { get; set; }
    }
}
