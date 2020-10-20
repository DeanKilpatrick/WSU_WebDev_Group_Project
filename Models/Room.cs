using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThreeSistersHotel.models;

namespace ThreeSistersHotel.Models
{
    public class Room
    {
        [Display(Name = "Room Number")]
        public int ID { get; set; }

        [RegularExpression("^[123G]$")]
        [Display(Name = "Level")]
        public string Level { get; set; }

        [Display(Name = "Bed Count")]
        [Range(1, 3)]
        public int BedCount { get; set; }

        [DataType(DataType.Currency)]
        [Display(Name = "Price")]
        [Range(50.00, 300.00)]
        public decimal RoomPrice { get; set; }

        [Display(Name = "The Bookings")]
        public ICollection<Booking> Bookings { get; set; }
    }
}
