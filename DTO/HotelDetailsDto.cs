using System.Collections.Generic;

namespace DTO
{
    class HotelDetailsDto
    {
        public string Name { get; set; }
        public string Description { get; set; }

        public string Location { get; set; }
        public int Category { get; set; }
        public bool HasWifi { get; set; }
        public bool HasParking { get; set; }

        public string Phone { get; set; }

        public string Email { get; set; }

        public string Website { get; set; }

        public ICollection<Room> Rooms { get; set; }

    }
}
