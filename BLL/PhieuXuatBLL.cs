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
        
        public List<PhieuXuatDTO> getDataTheoTinhTrang(int TinhTrang)
        {
            return dal.getDataTheoTinhTrang(TinhTrang);
        }
        public List<PhieuXuatDTO> getDataTheoTinhTrang_TrangThai(int TinhTrang, bool TrangThai)
        {
            return dal.getDataTheoTinhTrang_TrangThai(TinhTrang, TrangThai ? 1 : 0);
        }
        public List<PhieuXuatDTO> getDataTheoNgay(DateTime TinhTrang, DateTime TrangThai)
        {
            return dal.getDataTheoNgay(TinhTrang, TrangThai);
        }
        
        public List<PhieuXuatDTO> GetPhieuXuatsNhanVien(int ma)
        {
            return dal.GetPhieuXuatsNhanVien(ma);
        }
    }
}
