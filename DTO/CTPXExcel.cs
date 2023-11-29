using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class CTPXExcel
    {
        public String STT { get; set; }
        public int id { get; set; }
        public int idPhieuXuat { get; set; }
        public String idSanPham { get; set; }
        public String tenSanPham { get; set; }
        public int SoLuong { get; set; }
        public String GiaNhap { get; set; }
    }
}
