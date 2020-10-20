using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ThreeSistersHotel.Models
{
    public class MyDetailsViewModel
    {
        [Required]
        [StringLength(20, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z'-]*")]
        public string Surname { get; set; }

        [Required]
        [StringLength(20, MinimumLength = 2)]
        [RegularExpression(@"^[a-zA-Z'-]*")]
        public string GivenName { get; set; }

        [Required]
        [RegularExpression(@"\d{4}$")]
        [DataType(DataType.PostalCode)]
        public string PostCode { get; set; }
    }
}
