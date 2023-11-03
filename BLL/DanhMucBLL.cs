using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class DanhMucBLL
    {
        DanhMucDAL dal;
        public DanhMucBLL()
        {
            dal = new DanhMucDAL();
        }
        public List<DanhMucDTO> getAll()
        {
            return dal.getData();
        }

        public DanhMucDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(DanhMucDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(DanhMucDTO data)
        {
            return dal.update(data);
        }
    }
}
