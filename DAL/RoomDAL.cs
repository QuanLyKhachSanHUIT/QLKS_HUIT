using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;
 
namespace DAL
{
  
    public class RoomDAL
    {
        private QLKSDataContext context;

        public RoomDAL(string connectionString)
        {
            context = new QLKSDataContext(connectionString);
        }





        public List<RoomDTO> GetRooms()
        {
            return (from room in context.ROOMs
                    join status in context.STATUSROOMs on room.IDStatusRoom equals status.ID
                    select new RoomDTO
                    {
                        RoomID = room.ID,
                        RoomName = room.Name,
                        StatusName = status.Name // Assuming Status is a related entity
                    }).ToList();
        }

        public RoomDTO GetRoomByID(int roomID)
        {
            var room = (from r in context.ROOMs
                        join s in context.STATUSROOMs on r.IDStatusRoom equals s.ID
                        join rt in context.ROOMTYPEs on r.IDRoomType equals rt.ID
                        where r.ID == roomID
                        select new RoomDTO
                        {
                            RoomID = r.ID,
                            RoomName = r.Name,
                            StatusName = s.Name,
                            RoomType = rt.Name,  // Assuming RoomType is represented by Name
                            Status = s.Name,     // Assuming Status is represented by Name
                            LimitPerson = rt.LimitPerson // Assuming LimitPerson is in ROOMTYPEs
                        }).FirstOrDefault();

            return room;
        }
    }

}
