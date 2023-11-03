using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DanhMucDAL
    {
        APIService<DanhMucDTO> _cnn;
        public DanhMucDAL()
        {
            _cnn = new APIService<DanhMucDTO>();
        }
        public List<DanhMucDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "DanhMuc");
        }
        public DanhMucDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "DanhMuc/" + data);
        }
        public bool insert(DanhMucDTO data)
        {
            return _cnn.store(Connect.apiUrl + "DanhMuc", data);
        }
        public bool update(DanhMucDTO data)
        {
            return _cnn.update(Connect.apiUrl + "DanhMuc/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "DanhMuc/" + data);
        }
    }
}
