using CustomLibrary;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class AIDAL
    {
        APIService<AIDTO> _cnn;
        public AIDAL()
        {
            _cnn = new APIService<AIDTO>();
        }
        public List<AIDTO> getData()
        {
            return _cnn.index(Connect.apiUrl + "AI");
        }
        public AIDTO findItem(String data)
        {
            return _cnn.show(Connect.apiUrl + "AI/" + data);
        }
        public bool insert(AIDTO data)
        {
            return _cnn.store(Connect.apiUrl + "AI", data);
        }
        public bool update(AIDTO data)
        {
            return _cnn.update(Connect.apiUrl + "AI/" + data.id, data);
        }
        public bool delete(String data)
        {
            return _cnn.delete(Connect.apiUrl + "AI/" + data);
        }
        public List<AIDTO> get1000Data()
        {
            return _cnn.index(Connect.apiUrl + "AI/get1000Data");
        }
        public List<String> getHieuSuat()
        {
            return _cnn.getResponse(Connect.apiUrl + "AI/getHieuSuat");
        }
        public List<String> getCamera()
        {
            return _cnn.getResponse(Connect.apiUrl + "AI/getCamera");
        }
        public List<String> getPin()
        {
            return _cnn.getResponse(Connect.apiUrl + "AI/getPin");
        }
        public List<String> getTanSo()
        {
            return _cnn.getResponse(Connect.apiUrl + "AI/getTanSo");
        }
    }
}
