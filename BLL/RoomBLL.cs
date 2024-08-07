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

        // Constructor accepting connection string
        public RoomBLL()
        {
            string connectionString = ConnectionManager.GetConnectionString();
            roomDAL = new RoomDAL(connectionString);
        }

        // Method to get all rooms
        public List<RoomDTO> GetRooms()
        {
            return roomDAL.GetRooms(); // Correctly calling the method from RoomDAL
        }

        public RoomDTO GetRoomByID(int roomID)
        {
            return roomDAL.GetRoomByID(roomID); // Ensure this method exists if you need it
        }
    }
}
