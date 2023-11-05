using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuNhapBLL
    {
        PhieuNhapDAL dal;
        public PhieuNhapBLL()
        {
            dal = new PhieuNhapDAL();
        }
        public List<PhieuNhapDTO> getAll()
        {
            return dal.getData();
        }

        public PhieuNhapDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(PhieuNhapDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(PhieuNhapDTO data)
        {
            return dal.update(data);
        }
        public bool ktraTrungKey(String data)
        {
            return dal.findItem(data) == null ? false : true; ;
        }
        public List<PhieuNhapDTO> getDataTheoTrangThai(bool TrangThai)
        {
            return dal.getDataTheoTrangThai(TrangThai ? 1 : 0);
        }
    }
}
