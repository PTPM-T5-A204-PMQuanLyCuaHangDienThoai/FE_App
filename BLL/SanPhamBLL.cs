using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class SanPhamBLL
    {
        SanPhamDAL dal;
        public SanPhamBLL()
        {
            dal = new SanPhamDAL();
        }
        public List<SanPhamDTO> getAll()
        {
            return dal.getData();
        }

        public SanPhamDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(SanPhamDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(SanPhamDTO data)
        {
            return dal.update(data);
        }
        public bool ktraTrungKey(String data)
        {
            return dal.findItem(data) == null ? false : true;
        }
    }
}
