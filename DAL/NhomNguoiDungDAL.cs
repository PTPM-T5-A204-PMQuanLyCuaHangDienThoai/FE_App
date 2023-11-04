using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhomNguoiDungDAL
    {
        APIService<NhomNguoiDungDTO> _cnn;
        public NhomNguoiDungDAL()
        {
            _cnn = new APIService<NhomNguoiDungDTO>();
        }
        public List<NhomNguoiDungDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "NhomNguoiDung");
        }
        public NhomNguoiDungDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "NhomNguoiDung/" + data);
        }
        public bool insert(NhomNguoiDungDTO data)
        {
            return _cnn.store(Connect.apiUrl + "NhomNguoiDung", data);
        }
        public bool update(NhomNguoiDungDTO data)
        {
            return _cnn.update(Connect.apiUrl + "NhomNguoiDung/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "NhomNguoiDung/" + data);
        }
        public List<NhomNguoiDungDTO> getDataByidNhom(String idNhom)
        {
            return _cnn.index(Connect.apiUrl + "NhomNguoiDung/" + idNhom + "/getDataByidNhom");
        }
    }
}
