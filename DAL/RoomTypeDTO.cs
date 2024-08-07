using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class RoomTypeDTO
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public int LimitPerson { get; set; }
        public int Price { get; set; }
    }
}
