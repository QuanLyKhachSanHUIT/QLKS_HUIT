﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace DAL
{
    public static class ConnectionManager
    {
        public static string GetConnectionString()
        {
            return ConfigurationManager.ConnectionStrings["HotelManagementConnectionString"].ConnectionString;
        }
    }
}
