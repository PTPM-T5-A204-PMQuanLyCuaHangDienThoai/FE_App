using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class ChiTietPhieuNhapBLL
    {
        ChiTietPhieuNhapDAL dal;
        public ChiTietPhieuNhapBLL()
        {
            dal = new ChiTietPhieuNhapDAL();
        }
        public List<ChiTietPhieuNhapDTO> getAll()
        {
            return dal.getData();
        }

        public ChiTietPhieuNhapDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(ChiTietPhieuNhapDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(ChiTietPhieuNhapDTO data)
        {
            return dal.update(data);
        }
        public ChiTietPhieuNhapDTO findDataByCTPhieuNhap_SanPham(String idSanPham, String idPhieuNhap)
        {
            return dal.findDataByCTPhieuNhap_SanPham(idSanPham, idPhieuNhap);
        }
        public List<ChiTietPhieuNhapDTO> findDataByidPhieuNhap(String idPhieuNhap)
        {
            return dal.findDataByidPhieuNhap(idPhieuNhap);
        }
    }
}
