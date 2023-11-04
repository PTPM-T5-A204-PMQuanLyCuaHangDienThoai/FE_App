using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhomDAL
    {
        APIService<NhomDTO> _cnn;
        public NhomDAL()
        {
            _cnn = new APIService<NhomDTO>();
        }
        public List<NhomDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "Nhom");
        }
        public NhomDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "Nhom/" + data);
        }
        public bool insert(NhomDTO data)
        {
            return _cnn.store(Connect.apiUrl + "Nhom", data);
        }
        public bool update(NhomDTO data)
        {
            return _cnn.update(Connect.apiUrl + "Nhom/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "Nhom/" + data);
        }
    }
}
