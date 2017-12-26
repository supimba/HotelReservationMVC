using System;
using System.Collections.Generic;

namespace DTO
{
    class ReservationDetailsDto
    {
        public string NbrPerson { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string Name { get; set; }
        public string Firstname { get; set; }
        public virtual ICollection<Room> Rooms { get; set; }
    }
}
