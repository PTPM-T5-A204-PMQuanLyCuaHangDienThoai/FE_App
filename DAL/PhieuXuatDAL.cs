using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuXuatDAL
    {
        APIService<PhieuXuatDTO> _cnn;
        public PhieuXuatDAL()
        {
            _cnn = new APIService<PhieuXuatDTO>();
        }
        public List<PhieuXuatDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "PhieuXuat");
        }
        public PhieuXuatDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "PhieuXuat/" + data);
        }
        public bool insert(PhieuXuatDTO data)
        {
            return _cnn.store(Connect.apiUrl + "PhieuXuat", data);
        }
        public bool update(PhieuXuatDTO data)
        {
            return _cnn.update(Connect.apiUrl + "PhieuXuat/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "PhieuXuat/" + data);
        }
        public List<PhieuXuatDTO> getDataTheoTrangThai(int TrangThai)
        {
            return _cnn.index(Connect.apiUrl + "PhieuXuat/" + TrangThai + "/getDataTheoTrangThai");
        }
        public List<PhieuXuatDTO> getDataTheoTinhTrang(int TinhTrang)
        {
            return _cnn.index(Connect.apiUrl + "PhieuXuat/" + TinhTrang + "/getDataTheoTinhTrang");
        }
        public List<PhieuXuatDTO> getDataTheoTinhTrang_TrangThai(int TinhTrang, int TrangThai)
        {
            return _cnn.index(Connect.apiUrl + "PhieuXuat/" + TinhTrang + "/" + TrangThai + "/getDataTheoTinhTrang_TrangThai");
        }
    }
}
