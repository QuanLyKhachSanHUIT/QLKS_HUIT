using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;

namespace BLL
{
    public class BLLNhanVien
    {
        private readonly DALNhanVien danv;
       

        public BLLNhanVien()
        {
            danv = new DALNhanVien();
        }
        public List<STAFF> LoadStaff()
        {
            return danv.LoadStaff();
        }
        public void AddStaff(STAFF staff)
        {
            danv.AddStaff(staff);
        }
    }
}
