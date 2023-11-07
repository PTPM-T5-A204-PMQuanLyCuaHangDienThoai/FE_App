using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BaoHanhBLL
    {
        BaoHanhDAL dal;
        public BaoHanhBLL()
        {
            dal = new BaoHanhDAL();
        }
        public List<BaoHanhDTO> getAll()
        {
            return dal.getData();
        }

        public BaoHanhDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(BaoHanhDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(BaoHanhDTO data)
        {
            return dal.update(data);
        }
        public bool ktraTrungKey(String data)
        {
            return dal.findItem(data) == null ? false : true;
        }
        public List<BaoHanhDTO> getDataByidPhieuXuat(String data)
        {
            return dal.getDataByidPhieuXuat(data);
        }
    }
}
