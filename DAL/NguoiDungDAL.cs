using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NguoiDungDAL
    {
        APIService<NguoiDungDTO> _cnn;
        public NguoiDungDAL()
        {
            _cnn = new APIService<NguoiDungDTO>();
        }
        public List<NguoiDungDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "NguoiDung");
        }
        public NguoiDungDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "NguoiDung/" + data);
        }
        public bool insert(NguoiDungDTO data)
        {
            return _cnn.store(Connect.apiUrl + "NguoiDung", data);
        }
        public bool update(NguoiDungDTO data)
        {
            return _cnn.update(Connect.apiUrl + "NguoiDung/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "NguoiDung/" + data);
        }
    }
}
