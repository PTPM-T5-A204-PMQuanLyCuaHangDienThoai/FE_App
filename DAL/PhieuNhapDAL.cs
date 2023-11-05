using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhieuNhapDAL
    {
        APIService<PhieuNhapDTO> _cnn;
        public PhieuNhapDAL()
        {
            _cnn = new APIService<PhieuNhapDTO>();
        }
        public List<PhieuNhapDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "PhieuNhap");
        }
        public PhieuNhapDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "PhieuNhap/" + data);
        }
        public bool insert(PhieuNhapDTO data)
        {
            return _cnn.store(Connect.apiUrl + "PhieuNhap", data);
        }
        public bool update(PhieuNhapDTO data)
        {
            return _cnn.update(Connect.apiUrl + "PhieuNhap/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "PhieuNhap/" + data);
        }
        public List<PhieuNhapDTO> getDataTheoTrangThai(int TrangThai)
        {
            return _cnn.index(Connect.apiUrl + "PhieuNhap/" + TrangThai + "/getDataTheoTrangThai");
        }
    }
}
