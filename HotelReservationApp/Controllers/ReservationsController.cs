
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Description;
using DTO;
using HotelReservationApp.Models;
using System.Web.Mvc;
using BLL;

namespace HotelReservationApp.Controllers
{
    public class ReservationsController : Controller
    {
        // GET: Reservation
        ReservationsRESTService ser = new ReservationsRESTService();
        public ActionResult CreateReservation()
        {
            //DTO.Reservation r = new DTO.Reservation {  };
            //ser.PostReservation(r);

            return View();//ser.GetReservation());
        }
    }
}