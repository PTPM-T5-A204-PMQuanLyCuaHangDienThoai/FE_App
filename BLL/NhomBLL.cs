using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhomBLL
    {
        NhomDAL dal;
        public NhomBLL()
        {
            dal = new NhomDAL();
        }
        public List<NhomDTO> getAll()
        {
            return dal.getData();
        }

        public NhomDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(NhomDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(NhomDTO data)
        {
            return dal.update(data);
        }
        public bool ktraTrungKey(String data)
        {
            return dal.findItem(data) == null ? false : true;
        }
    }
}
