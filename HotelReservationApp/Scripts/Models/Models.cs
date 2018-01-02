using DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelReservationApp.Scripts.Models
{
    //This class is used to select a date in reservation's view
    public class Models
    {
        [Key]
        public int IdReservation { get; set; }

        [Display(Name = "Choose the number of person")]
        [DataType(DataType.Text)]
        [Required]
        public string NbrPerson { get; set; }

        [Display(Name = "Choose a starting date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd,mm,yyyy}")]
        [Required]
        public DateTime StartDate { get; set; }

        [Display(Name = "Choose a ending date")]
        [DataType(DataType.Date)]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd,mm,yyyy}")]
        [Required]
        public DateTime EndDate { get; set; }

        [Display(Name = "Choose a name")]
        [DataType(DataType.Text)]
        public string Name { get; set; }

        [Display(Name = "Choose a firstname")]
        [DataType(DataType.Text)]
        public string Firstname { get; set; }

        public ICollection<Room> Rooms { get; set; }
    }
}