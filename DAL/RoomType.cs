using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;

namespace DAL
{
    [Table(Name = "ROOMTYPES")]

    public class RoomType
    {
        [Column(IsPrimaryKey = true, IsDbGenerated = true)]
        public int ID { get; set; }

        [Column]
        public string Name { get; set; }

        [Column]
        public int LimitPerson { get; set; }

        [Column]
        public int Price { get; set; }
    }
}
