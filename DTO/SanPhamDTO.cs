using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class SanPhamDTO
    {
        public String id { get; set; }
        public String name { get; set; }
        public int SoLuongTon { get; set; }
        public int GiaGoc { get; set; }
        public int GiaKhuyenMai { get; set; }
        public String MoTa { get; set; }
        public float ManHinh { get; set; }
        public String DoPhanGiai { get; set; }
        public int TanSoQuet { get; set; }
        public String CameraSau { get; set; }
        public String CameraTruoc { get; set; }
        public String CPU { get; set; }
        public String GPU { get; set; }
        public String RAM { get; set; }
        public String ROM { get; set; }
        public bool Flash { get; set; }
        public int Pin { get; set; }
        public String Sim { get; set; }
        public String HeDieuHanh { get; set; }
        public int HoTroMang { get; set; }
        public bool KhangNuoc { get; set; }
        public DateTime ThoiDiemRaMat { get; set; }
        public bool TrangThai { get; set; }
        public int ThoiGianBaoHanh { get; set; }
        public int ThoiGianDoiTra { get; set; }
        public String idDanhMuc { get; set; }
        public String idNhaCungCap { get; set; }
        public String Anh { get; set; }
    }
}
