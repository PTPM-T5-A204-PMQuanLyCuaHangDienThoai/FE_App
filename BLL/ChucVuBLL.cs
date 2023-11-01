using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChucVuBLL
    {
        ChucVuDAL dal;
        public ChucVuBLL()
        {
            dal = new ChucVuDAL();
        }
        public List<ChucVuDTO> getAll()
        {
            return dal.getData();
        }

        public ChucVuDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(ChucVuDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(ChucVuDTO data)
        {
            return dal.update(data);
        }
        public bool ktraTrungKey(String data)
        {
            return dal.findItem(data) == null ? false : true;
        }
    }
}
