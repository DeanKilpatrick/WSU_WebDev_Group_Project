using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using ThreeSistersHotel.Models;

namespace ThreeSistersHotel.models
{
    public class Booking
    {
        public int ID { get; set; }
        
        [Display(Name ="Room ID")]
        public int RoomID { get; set; }
       
        [Display(Name = "Email")]
        public string CustomerEmail { get; set; }
        
        [Display(Name = "Check In Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime CheckIn { get; set; }
       
        [Display(Name = "Check Out Date")]
        [DisplayFormat(DataFormatString = "{0:dd-MM-yyyy}", ApplyFormatInEditMode = true)]
        [DataType(DataType.Date)]
        public DateTime CheckOut { get; set; }

        public decimal Cost { get; set; }

        //Navigation properties
        [Display(Name = "Room")]
        public Room TheRoom { get; set; }

        [Display(Name = "Customer")]
        public Customer TheCustomer { get; set; }
    }
}
