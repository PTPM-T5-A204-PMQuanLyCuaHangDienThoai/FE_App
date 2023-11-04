using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class QuyenDAL
    {
        APIService<QuyenDTO> _cnn;
        public QuyenDAL()
        {
            _cnn = new APIService<QuyenDTO>();
        }
        public List<QuyenDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "Quyen");
        }
        public QuyenDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "Quyen/" + data);
        }
        public bool insert(QuyenDTO data)
        {
            return _cnn.store(Connect.apiUrl + "Quyen", data);
        }
        public bool update(QuyenDTO data)
        {
            return _cnn.update(Connect.apiUrl + "Quyen/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "Quyen/" + data);
        }
        public List<QuyenDTO> getDataIsNotAddByGroup(String idNhom)
        {
            return _cnn.index(Connect.apiUrl + "Quyen/" + idNhom + "/getDataIsNotAddByGroup");
        }
    }
}
