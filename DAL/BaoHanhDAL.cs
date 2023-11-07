using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class BaoHanhDAL
    {
        APIService<BaoHanhDTO> _cnn;
        public BaoHanhDAL()
        {
            _cnn = new APIService<BaoHanhDTO>();
        }
        public List<BaoHanhDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "BaoHanh");
        }
        public BaoHanhDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "BaoHanh/" + data);
        }
        public bool insert(BaoHanhDTO data)
        {
            return _cnn.store(Connect.apiUrl + "BaoHanh", data);
        }
        public bool update(BaoHanhDTO data)
        {
            return _cnn.update(Connect.apiUrl + "BaoHanh/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "BaoHanh/" + data);
        }
        public List<BaoHanhDTO> getDataByidPhieuXuat(String data)
        {
            return _cnn.index(Connect.apiUrl + "BaoHanh/" + data + "/getDataByidPhieuXuat");
        }
    }
}
