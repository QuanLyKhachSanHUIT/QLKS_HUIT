using DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL
{
    public class StatusRoomDAL
    {
        private QLKSDataContext dataContext;

        public StatusRoomDAL(string connectionString)
        {
            dataContext = new QLKSDataContext(connectionString); // Pass the connection string to the constructor
        }


        // Lấy tất cả trạng thái phòng
        public StatusRoomDTO GetStatusRoomByID(int statusRoomID)
        {
            return dataContext.STATUSROOMs
                .Where(sr => sr.ID == statusRoomID)
                .Select(sr => new StatusRoomDTO
                {
                    ID = sr.ID,
                    Name = sr.Name
                }).FirstOrDefault();
        }

        // Existing methods
        public List<StatusRoomDTO> GetAllStatusRooms()
        {
            return dataContext.STATUSROOMs
                .Select(sr => new StatusRoomDTO
                {
                    ID = sr.ID,
                    Name = sr.Name
                }).ToList();
        }

    }
}



