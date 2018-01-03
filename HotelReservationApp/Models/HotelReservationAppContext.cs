﻿using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace HotelReservationApp.Models
{
    public class HotelReservationAppContext : DbContext
    {
        // You can add custom code to this file. Changes will not be overwritten.
        // 
        // If you want Entity Framework to drop and regenerate your database
        // automatically whenever you change your model schema, please use data migrations.
        // For more information refer to the documentation:
        // http://msdn.microsoft.com/en-us/data/jj591621.aspx

        public HotelReservationAppContext() : base("name=HotelReservationAppContext")
        {
        }

        public System.Data.Entity.DbSet<DTO.Reservation> Reservations { get; set; }

        public System.Data.Entity.DbSet<DTO.Hotel> Hotels { get; set; }

        //public System.Data.Entity.DbSet<DTO.Room> Rooms { get; set; }

        public System.Data.Entity.DbSet<ModelRoom> Rooms { get; set;}
    }
}
