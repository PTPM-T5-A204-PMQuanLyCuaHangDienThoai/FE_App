using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChiTietPhieuXuatDAL
    {
        APIService<ChiTietPhieuXuatDTO> _cnn;
        public ChiTietPhieuXuatDAL()
        {
            _cnn = new APIService<ChiTietPhieuXuatDTO>();
        }
        public List<ChiTietPhieuXuatDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "ChiTietPhieuXuat");
        }
        public ChiTietPhieuXuatDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "ChiTietPhieuXuat/" + data);
        }
        public bool insert(ChiTietPhieuXuatDTO data)
        {
            return _cnn.store(Connect.apiUrl + "ChiTietPhieuXuat", data);
        }
        public bool update(ChiTietPhieuXuatDTO data)
        {
            return _cnn.update(Connect.apiUrl + "ChiTietPhieuXuat/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "ChiTietPhieuXuat/" + data);
        }
        public ChiTietPhieuXuatDTO findDataByCTPhieuXuat_SanPham(String idSanPham, String idPhieuXuat)
        {
            return _cnn.show(Connect.apiUrl + "ChiTietPhieuXuat/" + idSanPham + "/" + idPhieuXuat + "/findDataByCTPhieuXuat_SanPham");
        }
        public List<ChiTietPhieuXuatDTO> findDataByidPhieuXuat(String idPhieuXuat)
        {
            return _cnn.index(Connect.apiUrl + "ChiTietPhieuXuat/" + idPhieuXuat + "/findDataByidPhieuXuat");
        }
    }
}
