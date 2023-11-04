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
        public bool resetMatKhau(NguoiDungDTO data)
        {
            return dal.resetMatKhau(data);
        }
        public NguoiDungDTO ktraTenDangNhap(String data)
        {
            return dal.ktraTenDangNhap(data);
        }
        public NguoiDungDTO ktraSDT(String data)
        {
            return dal.ktraSDT(data);
        }
        public NguoiDungDTO ktraEmail(String data)
        {
            return dal.ktraEmail(data);
        }
        public bool checkLogin(NguoiDungDTO data)
        {
            return dal.checkLogin(data);
        }
        public List<NguoiDungDTO> getDataIsNotAddByGroup(String idNhom)
        {
            return dal.getDataIsNotAddByGroup(idNhom);
        }
    }
}
