using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhanQuyenBLL
    {
        PhanQuyenDAL dal;
        public PhanQuyenBLL()
        {
            dal = new PhanQuyenDAL();
        }
        public List<PhanQuyenDTO> getAll()
        {
            return dal.getData();
        }

        public PhanQuyenDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(PhanQuyenDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(PhanQuyenDTO data)
        {
            return dal.update(data);
        }
        public bool ktraTrungKey(String data)
        {
            return dal.findItem(data) == null ? false : true;
        }
        public List<PhanQuyenDTO> getDataByidNhom(String idNhom)
        {
            return dal.getDataByidNhom(idNhom);
        }
        public bool ktraQuyen(String data)
        {
            return dal.ktraQuyen(Login.user, data);
        }
    }
}
