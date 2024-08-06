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
        private string connectionString;

        public RoomDAL()
        {
            connectionString = ConnectionManager.GetConnectionString();
        }



        public List<RoomDTO> GetRooms()
        {
            var rooms = new List<RoomDTO>();

            using (var connection = new SqlConnection(connectionString))
            {
                var query = @"
                    SELECT r.ID, r.Name, s.Name AS StatusName
                    FROM ROOM r
                    JOIN STATUSROOM s ON r.IDStatusRoom = s.ID";

                var command = new SqlCommand(query, connection);
                connection.Open();

                using (var reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        rooms.Add(new RoomDTO
                        {
                            RoomID = reader.GetInt32(0),
                            RoomName = reader.GetString(1),
                            StatusName = reader.GetString(2)
                        });
                    }
                }
            }

            return rooms;

        }
    }
     

}
