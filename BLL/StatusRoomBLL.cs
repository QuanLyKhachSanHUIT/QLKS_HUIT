﻿using DAL;
using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BLL
{
    public class StatusRoomBLL
    {
        private StatusRoomDAL statusRoomDAL;

        public StatusRoomBLL()
        {
            string connectionString = ConnectionManager.GetConnectionString();
            statusRoomDAL = new StatusRoomDAL(connectionString);
        }

        public StatusRoomDTO GetStatusRoomByID(int id)
        {
            return statusRoomDAL.GetStatusRoomByID(id);
        }
    }
}

