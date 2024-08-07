using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace DAL
{
    [Table(Name = "ROOM")]
    public class Room
    {
       
       
            [Column(IsPrimaryKey = true, IsDbGenerated = true)]
            public int ID { get; set; }

            [Column]
            public string Name { get; set; }

            [Column]
            public int IDRoomType { get; set; }

            [Column]
            public int IDStatusRoom { get; set; }
        }
    }

