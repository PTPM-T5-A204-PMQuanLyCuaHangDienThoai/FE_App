using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class PhanQuyenDAL
    {
        APIService<PhanQuyenDTO> _cnn;
        public PhanQuyenDAL()
        {
            _cnn = new APIService<PhanQuyenDTO>();
        }
        public List<PhanQuyenDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "PhanQuyen");
        }
        public PhanQuyenDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "PhanQuyen/" + data);
        }
        public bool insert(PhanQuyenDTO data)
        {
            return _cnn.store(Connect.apiUrl + "PhanQuyen", data);
        }
        public bool update(PhanQuyenDTO data)
        {
            return _cnn.update(Connect.apiUrl + "PhanQuyen/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "PhanQuyen/" + data);
        }
        public List<PhanQuyenDTO> getDataByidNhom(String idNhom)
        {
            return _cnn.index(Connect.apiUrl + "PhanQuyen/" + idNhom + "/getDataByidNhom");
        }
        public bool ktraQuyen(NguoiDungDTO nguoiDung, String idQuyen)
        {
            return _cnn.ktraQuyen(Connect.apiUrl + "PhanQuyen/" + nguoiDung.id + "/" + idQuyen + "/checkQuyen").ToString().Contains("true") ? true : false;
        }
    }
}
