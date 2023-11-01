using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class ChucVuDAL
    {
        APIService<ChucVuDTO> _cnn;
        public ChucVuDAL()
        {
            _cnn = new APIService<ChucVuDTO>();
        }
        public List<ChucVuDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "ChucVu");
        }
        public ChucVuDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "ChucVu/" + data);
        }
        public bool insert(ChucVuDTO data)
        {
            return _cnn.store(Connect.apiUrl + "ChucVu", data);
        }
        public bool update(ChucVuDTO data)
        {
            return _cnn.update(Connect.apiUrl + "ChucVu/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "ChucVu/" +  data);
        }
    }
}
