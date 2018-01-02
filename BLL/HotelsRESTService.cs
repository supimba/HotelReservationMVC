using DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace BLL
{
    public class HotelsRESTService
    {
        readonly string baseUrl = "http://localhost:3749/api/Hotels/";

        //This method is used to return all Hotel
        public List<Hotel> GetHotel()
        {
            string url = baseUrl;

            using (HttpClient client = new HttpClient())
            {
                Task<string> response = client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<List<Hotel>>(response.Result);
            }
        }

        public bool PostHotel(Hotel h)
        {
            string uri = baseUrl;
            using (HttpClient httpClient = new HttpClient())
            {
                string pro = JsonConvert.SerializeObject(h);
                StringContent frame = new StringContent(pro, Encoding.UTF8, "Application/json");
                Task<HttpResponseMessage> response = httpClient.PostAsync(uri, frame);
                return response.Result.IsSuccessStatusCode;
            }
        }
    }
}
