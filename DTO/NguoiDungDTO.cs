using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class NguoiDungDTO
    {
        public int id { get; set; }
        public String name { get; set; }
        public String TenDangNhap { get; set; }
        public String MatKhau { get; set; }
        public String XacNhanMatKhau { get; set; }
        public DateTime NgaySinh { get; set; }
        public String SDT { get; set; }
        public String DiaChi { get; set; }
        public String Email { get; set; }
        public DateTime NgayTao { get; set; }
        public DateTime NgayThayDoi { get; set; }
        public Boolean HoatDong { get; set; }
        public String idChucVu { get; set; }
        public String GioiTinh { get; set; }
        public String Anh { get; set; }
    }
}
