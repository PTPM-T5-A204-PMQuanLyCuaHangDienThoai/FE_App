using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class QuyenBLL
    {
        QuyenDAL dal;
        public QuyenBLL()
        {
            dal = new QuyenDAL();
        }
        public List<QuyenDTO> getAll()
        {
            return dal.getData();
        }

        public QuyenDTO findItem(String data)
        {
            return dal.findItem(data);
        }

        public bool insert(QuyenDTO data)
        {
            return dal.insert(data);
        }
        public bool delete(String key)
        {
            return dal.delete(key);
        }
        public bool update(QuyenDTO data)
        {
            return dal.update(data);
        }
        public bool ktraTrungKey(String data)
        {
            return dal.findItem(data) == null ? false : true;
        }
        public List<QuyenDTO> getDataIsNotAddByGroup(String idNhom)
        {
            return dal.getDataIsNotAddByGroup(idNhom);
        }
    }
}
