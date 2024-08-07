using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq;
using System.Configuration;
using DAL.DatasetQLKSTableAdapters;
namespace DAL
{
    public class DALNhanVien
    {

        private readonly QLKSDataContext QLKS;
        //  DatasetQLKS qlks = new DatasetQLKS();
        public DALNhanVien()
        {
            // Lấy chuỗi kết nối từ ConnectionManager
            string connectionString = ConnectionManager.GetConnectionString();

            // Khởi tạo QLKSDataContext với chuỗi kết nối
            QLKS = new QLKSDataContext(connectionString);

        }

        public List<STAFF> LoadStaff()
        {
            // return QLKS.STAFFs.Select(nv => nv).ToList<STAFF>();
            return QLKS.STAFFs.ToList();

        }
        public void AddStaff(STAFF staff)
        {
             QLKS.STAFFs.InsertOnSubmit(staff);
            QLKS.SubmitChanges();
        }

    }
}
