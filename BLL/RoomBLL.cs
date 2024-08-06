using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using DAL;
namespace BLL
{
    public class RoomBLL
    {
        private RoomDAL roomDAL;

        public RoomBLL()
        {
            roomDAL = new RoomDAL();
        }

        public List<RoomDTO> GetRooms()
        {
            return roomDAL.GetRooms();
        }

    }
}
