using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class SanPhamDAL
    {
        APIService<SanPhamDTO> _cnn;
        public SanPhamDAL()
        {
            _cnn = new APIService<SanPhamDTO>();
        }
        public List<SanPhamDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "SanPham");
        }
        public SanPhamDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "SanPham/" + data);
        }
        public bool insert(SanPhamDTO data)
        {
            return _cnn.store(Connect.apiUrl + "SanPham", data);
        }
        public bool update(SanPhamDTO data)
        {
            return _cnn.update(Connect.apiUrl + "SanPham/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "SanPham/" + data);
        }
        public List<SanPhamDTO> getDataTheoTrangThai(int TrangThai)
        {
            return _cnn.index(Connect.apiUrl + "SanPham/" + TrangThai + "/getDataTheoTrangThai");
        }
        public List<SanPhamDTO> findDataTheoTrangThai(int TrangThai, String data)
        {
            return _cnn.index(Connect.apiUrl + "SanPham/" + TrangThai + "/" + data + "/findDataTheoTrangThai");
        }
    }
}
