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
        readonly string baseUrl = "http://localhost:12220/api/Reservations/";

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

        public bool PostReservation(Reservation r)
        {
            string uri = baseUrl;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(r);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> response = httpClient.PostAsync(uri, frame);
                return response.Result.IsSuccessStatusCode;
            }
        }
    }
}
