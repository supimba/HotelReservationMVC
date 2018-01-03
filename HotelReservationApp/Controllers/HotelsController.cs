
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
    public class HotelsController : Controller
    {
        // GET: Hotel
        HotelsRESTService ser = new HotelsRESTService();

        DTO.Hotel h = new DTO.Hotel { };
        public ActionResult Index()
        {
           // ser.PostHotel(h);

            return View(ser.GetHotel());
        }

        public ActionResult ListHotels()
        {            

            return View(ser.GetHotel());
        }

        public ActionResult SearchHotel()
        {
            return View();
        }
        

    }
}