using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietPhieuXuatBLL
    {
        ChiTietPhieuXuatDAL dal;
        public ChiTietPhieuXuatBLL()
        {
            dal = new ChiTietPhieuXuatDAL();
        }
        public List<ChiTietPhieuXuatDTO> getAll()
        {
            return dal.getData();
        }

        public ChiTietPhieuXuatDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(ChiTietPhieuXuatDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(ChiTietPhieuXuatDTO data)
        {
            return dal.update(data);
        }
        public ChiTietPhieuXuatDTO findDataByCTPhieuXuat_SanPham(String idSanPham, String idPhieuXuat)
        {
            return dal.findDataByCTPhieuXuat_SanPham(idSanPham, idPhieuXuat);
        }
        public List<ChiTietPhieuXuatDTO> findDataByidPhieuXuat(String idPhieuXuat)
        {
            return dal.findDataByidPhieuXuat(idPhieuXuat);
        }
    }
}
