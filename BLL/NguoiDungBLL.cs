using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NguoiDungBLL
    {
        NguoiDungDAL dal;
        public NguoiDungBLL()
        {
            dal = new NguoiDungDAL();
        }
        public List<NguoiDungDTO> getAll()
        {
            return dal.getData();
        }

        public NguoiDungDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(NguoiDungDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(NguoiDungDTO data)
        {
            return dal.update(data);
        }
        public bool ktraTrungKey(String data)
        {
            return dal.findItem(data) == null ? false : true;
        }
    }
}
