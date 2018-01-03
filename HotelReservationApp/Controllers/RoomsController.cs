using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DTO;
using HotelReservationApp.Models;
using System.Web.Mvc;
using BLL;

namespace HotelReservationApp.Controllers
{
    public class RoomsController : Controller
    {

        RoomsRESTService ser = new RoomsRESTService();// Access to the API

        DTO.Hotel h = new DTO.Hotel { };
        public ActionResult SearchRoom(ModelRoom mr)
        {
            return View(ser.GetRoomByDateLoc(mr.StartDate, mr.EndDate, mr.Location));
        }
    }
}