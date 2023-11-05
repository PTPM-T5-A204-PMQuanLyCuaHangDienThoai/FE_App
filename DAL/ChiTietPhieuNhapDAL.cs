using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietPhieuNhapDAL
    {
        APIService<ChiTietPhieuNhapDTO> _cnn;
        public ChiTietPhieuNhapDAL()
        {
            _cnn = new APIService<ChiTietPhieuNhapDTO>();
        }
        public List<ChiTietPhieuNhapDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "ChiTietPhieuNhap");
        }
        public ChiTietPhieuNhapDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "ChiTietPhieuNhap/" + data);
        }
        public bool insert(ChiTietPhieuNhapDTO data)
        {
            return _cnn.store(Connect.apiUrl + "ChiTietPhieuNhap", data);
        }
        public bool update(ChiTietPhieuNhapDTO data)
        {
            return _cnn.update(Connect.apiUrl + "ChiTietPhieuNhap/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "ChiTietPhieuNhap/" + data);
        }
        public ChiTietPhieuNhapDTO findDataByCTPhieuNhap_SanPham(String idSanPham, String idPhieuNhap)
        {
            return _cnn.show(Connect.apiUrl + "ChiTietPhieuNhap/" + idSanPham + "/" + idPhieuNhap + "/findDataByCTPhieuNhap_SanPham");
        }
        public List<ChiTietPhieuNhapDTO> findDataByidPhieuNhap(String idPhieuNhap)
        {
            return _cnn.index(Connect.apiUrl + "ChiTietPhieuNhap/" + idPhieuNhap + "/findDataByidPhieuNhap");
        }
    }
}
