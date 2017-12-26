using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using Newtonsoft.Json;
using DTO;

namespace BLL
{
    public class ReservationsRESTService
    {
        readonly string baseUrl = "http://localhost:3749/api/Reservations/";

        //This method is used to return all Reservation
        public List<Reservation> GetReservation()
        {
            string url = baseUrl;

            using (HttpClient client = new HttpClient())
            {
                Task<string> response = client.GetStringAsync(url);
                //TODO FIX JSON ERROR
                return JsonConvert.DeserializeObject<List<Reservation>>(response.Result);
                //Test Commit
            }
        }

    }
}
