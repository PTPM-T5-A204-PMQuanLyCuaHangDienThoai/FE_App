using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class CuaHangDAL
    {
        APIService<CuaHangDTO> _cnn;
        public CuaHangDAL()
        {
            _cnn = new APIService<CuaHangDTO>();
        }
        public List<CuaHangDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "CuaHang");
        }
        public CuaHangDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "CuaHang/" + data);
        }
        public bool insert(CuaHangDTO data)
        {
            return _cnn.store(Connect.apiUrl + "CuaHang", data);
        }
        public bool update(CuaHangDTO data)
        {
            return _cnn.update(Connect.apiUrl + "CuaHang/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "CuaHang/" + data);
        }
        public CuaHangDTO ktraSDT(String data)
        {
            return _cnn.show(Connect.apiUrl + "CuaHang/" + data + "/checkDuplicateSDT");
        }
        public CuaHangDTO ktraEmail(String data)
        {
            return _cnn.show(Connect.apiUrl + "CuaHang/" + data + "/checkDuplicateEmail");
        }
    }
}
