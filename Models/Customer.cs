using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using ThreeSistersHotel.models;

namespace ThreeSistersHotel.Models
{
    public class Customer
    {

        [Key, Required]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z'-]*")]
        public string Surname { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z'-]*")]
        [Display(Name = "Given Name")]
        public string GivenName { get; set; }

        [Required]
        [RegularExpression(@"\d{4}$")]
        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }

        public ICollection<Booking> TheBookings { get; set; }
    }
}
