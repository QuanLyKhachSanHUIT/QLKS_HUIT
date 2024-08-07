using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTO;
using System.Data;
using System.Data.Linq;
using System.Windows.Forms;


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
                    join rt in context.ROOMTYPEs on room.IDRoomType equals rt.ID
                    select new RoomDTO
                    {
                        RoomID = room.ID,
                        RoomName = room.Name,
                        StatusName = status.Name,
                        RoomType = rt.Name,
                        LimitPerson = rt.LimitPerson,
                        Price = rt.Price
                    }).ToList();
        }

        public RoomDTO GetRoomByID(int roomID)
        {
            return (from r in context.ROOMs
                    join s in context.STATUSROOMs on r.IDStatusRoom equals s.ID
                    join rt in context.ROOMTYPEs on r.IDRoomType equals rt.ID
                    where r.ID == roomID
                    select new RoomDTO
                    {
                        RoomID = r.ID,
                        RoomName = r.Name,
                        StatusName = s.Name,
                        RoomType = rt.Name,
                        LimitPerson = rt.LimitPerson,
                        Price = rt.Price
                    }).FirstOrDefault();
        }
    }
}


    

    


