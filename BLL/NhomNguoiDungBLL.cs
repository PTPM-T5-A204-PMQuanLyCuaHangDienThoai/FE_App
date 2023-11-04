using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class NhomNguoiDungBLL
    {
        NhomNguoiDungDAL dal;
        public NhomNguoiDungBLL()
        {
            dal = new NhomNguoiDungDAL();
        }
        public List<NhomNguoiDungDTO> getAll()
        {
            return dal.getData();
        }

        public NhomNguoiDungDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(NhomNguoiDungDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(NhomNguoiDungDTO data)
        {
            return dal.update(data);
        }
        public bool ktraTrungKey(String data)
        {
            return dal.findItem(data) == null ? false : true;
        }
        public List<NhomNguoiDungDTO> getDataByidNhom(String idNhom)
        {
            return dal.getDataByidNhom(idNhom);
        }
    }
}
