using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhaCungCapBLL
    {
        NhaCungCapDAL dal;
        public NhaCungCapBLL()
        {
            dal = new NhaCungCapDAL();
        }
        public List<NhaCungCapDTO> getAll()
        {
            return dal.getData();
        }

        public NhaCungCapDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(NhaCungCapDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(NhaCungCapDTO data)
        {
            return dal.update(data);
        }
        public NhaCungCapDTO ktraSDT(String data)
        {
            return dal.ktraSDT(data);
        }
        public NhaCungCapDTO ktraEmail(String data)
        {
            return dal.ktraEmail(data);
        }
    }
}
