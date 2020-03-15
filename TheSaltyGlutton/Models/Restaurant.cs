using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheSaltyGlutton.Models
{
    [Table("Restaurants")]
    public class Restaurant
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [DisplayName("Restaurant")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Restaurants must have a name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Restaurants must have an address")]
        public string Address { get; set; }

        [Phone(ErrorMessage = "The submitted number was not valid")]
        public string Phone { get; set; }

        [Url(ErrorMessage = "The submitted url was not valid")]
        public string Website { get; set; }

        [ForeignKey("Country")]
        [Required(ErrorMessage = "Restaurants must have a country")]
        public int CountryId { get; set; }

        [ForeignKey("State")]
        public Nullable<int> StateId { get; set; }

        [ForeignKey("City")]
        [Required(ErrorMessage = "Restaurant must have a city")]
        public int CityId { get; set; }



        public virtual City City { get; set; } 
        public virtual State State { get; set; }
        public virtual Country Country { get; set; }

    }
}
