using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class PhieuXuatBLL
    {
        PhieuXuatDAL dal;
        public PhieuXuatBLL()
        {
            dal = new PhieuXuatDAL();
        }
        public List<PhieuXuatDTO> getAll()
        {
            return dal.getData();
        }

        public PhieuXuatDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(PhieuXuatDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(PhieuXuatDTO data)
        {
            return dal.update(data);
        }
        public bool ktraTrungKey(String data)
        {
            return dal.findItem(data) == null ? false : true; ;
        }
        public List<PhieuXuatDTO> getDataTheoTrangThai(bool TrangThai)
        {
            return dal.getDataTheoTrangThai(TrangThai ? 1 : 0);
        }
        public List<PhieuXuatDTO> getDataTheoTinhTrang(bool TinhTrang)
        {
            return dal.getDataTheoTinhTrang(TinhTrang ? 1 : 0);
        }
        public List<PhieuXuatDTO> getDataTheoTinhTrang_TrangThai(bool TinhTrang, bool TrangThai)
        {
            return dal.getDataTheoTinhTrang_TrangThai(TinhTrang ? 1 : 0, TrangThai ? 1 : 0);
        }
    }
}
