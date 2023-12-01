using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class AIBLL
    {
        AIDAL dal;
        public AIBLL()
        {
            dal = new AIDAL();
        }
        public List<AIDTO> getAll()
        {
            return dal.getData();
        }

        public AIDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(AIDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(AIDTO data)
        {
            return dal.update(data);
        }
        public bool ktraTrungKey(String data)
        {
            return dal.findItem(data) == null ? false : true;
        }
        public List<AIDTO> get1000Data()
        {
            return dal.get1000Data();
        }
        public List<String> getHieuSuat()
        {
            return dal.getHieuSuat();
        }
        public List<String> getCamera()
        {
            return dal.getCamera();
        }
        public List<String> getPin()
        {
            return dal.getPin();
        }
        public List<String> getTanSo()
        {
            return dal.getTanSo();
        }
    }
}
