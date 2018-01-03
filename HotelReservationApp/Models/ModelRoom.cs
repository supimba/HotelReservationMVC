using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace HotelReservationApp.Models
{
    public class ModelRoom
    {
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

        [Display(Name = "Choose a location")]
        [DataType(DataType.Text)]
        [Required]
        public String Location { get; set; }
    }
}