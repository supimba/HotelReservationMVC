using System.Collections.Generic;

namespace DTO
{
    class RoomDetailsDto
    {
        public int IdRoom { get; set; }
        public int Number { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public decimal Price { get; set; }
        public bool HasTv { get; set; }
        public bool HasHairDryer { get; set; }
        public Hotel Hotel { get; set; }
        public virtual ICollection<Reservation> Reservations { get; set; }
    }
}
