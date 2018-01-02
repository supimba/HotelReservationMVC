using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace DTO
{
    public class Hotel
    {
        [Key]
        public int IdHotel { get; set; }

        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        [MaxLength(50)]
        public string Location { get; set; }
        public int Category { get; set; }

        public bool HasWifi { get; set; }
        public bool HasParking { get; set; }
        [MaxLength(20)]
        public string Phone { get; set; }
        [MaxLength(50)]
        public string Email { get; set; }
        [MaxLength(100)]
        public string Website { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}
