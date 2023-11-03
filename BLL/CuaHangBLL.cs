using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class CuaHangBLL
    {
        CuaHangDAL dal;
        public CuaHangBLL()
        {
            dal = new CuaHangDAL();
        }
        public List<CuaHangDTO> getAll()
        {
            return dal.getData();
        }

        public CuaHangDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(CuaHangDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(CuaHangDTO data)
        {
            return dal.update(data);
        }
        public CuaHangDTO ktraSDT(String data)
        {
            return dal.ktraSDT(data);
        }
        public CuaHangDTO ktraEmail(String data)
        {
            return dal.ktraEmail(data);
        }
    }
}
