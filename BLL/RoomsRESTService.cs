using DTO;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace BLL
{
    public class RoomsRESTService
    {
        readonly string baseUrl = "http://localhost:12220/api/Rooms/";

        //Method used to return all Rooms
        public List<Room> GetRoom()
        {
            string url = baseUrl;

            using (HttpClient client = new HttpClient())
            {
                Task<string> response = client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<List<Room>>(response.Result);
            }
        }

        //Method used to return rooms by dates and location
        public List<Room> GetRoomByDateLoc(DateTime startDate, DateTime endDate, String loc)
        {
            string url = baseUrl + "GetAvaibleRoomsByLocation/" + startDate.Year + "-" + startDate.Month + "-" + startDate.Day + 
                "-" + endDate.Year + "-" + endDate.Month + "-" + endDate.Day + "-" + loc;

            using (HttpClient client = new HttpClient())
            {
                Task<string> response = client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<List<Room>>(response.Result);
            }
        }

        //Method used to return rooms by id
        public Room GetRoomById(int id)
        {
            string url = baseUrl + "GetRooms/" + id;

            using (HttpClient client = new HttpClient())
            {

                Task<string> response = client.GetStringAsync(url);
                return JsonConvert.DeserializeObject<Room>(response.Result);
            }
        }

    }
}
