using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class NhaCungCapDAL
    {
        APIService<NhaCungCapDTO> _cnn;
        public NhaCungCapDAL()
        {
            _cnn = new APIService<NhaCungCapDTO>();
        }
        public List<NhaCungCapDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "NhaCungCap");
        }
        public NhaCungCapDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "NhaCungCap/" + data);
        }
        public bool insert(NhaCungCapDTO data)
        {
            return _cnn.store(Connect.apiUrl + "NhaCungCap", data);
        }
        public bool update(NhaCungCapDTO data)
        {
            return _cnn.update(Connect.apiUrl + "NhaCungCap/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "NhaCungCap/" + data);
        }
        public NhaCungCapDTO ktraSDT(String data)
        {
            return _cnn.show(Connect.apiUrl + "NhaCungCap/" + data + "/checkDuplicateSDT");
        }
        public NhaCungCapDTO ktraEmail(String data)
        {
            return _cnn.show(Connect.apiUrl + "NhaCungCap/" + data + "/checkDuplicateEmail");
        }
    }
}
