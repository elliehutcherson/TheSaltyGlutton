using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheSaltyGlutton.Models
{
    public class Restaurant
    {
        public Restaurant()
        {
            CreateWhen = DateTime.Now;
        }

        [BsonId]
        public string Id { get; set; }

        [DisplayName("Restaurant")]
        [Required(AllowEmptyStrings = false, ErrorMessage = "Restaurants must have a name")]
        public string Name { get; set; }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Restaurants must have an address")]
        public string Address { get; set; }

        [Phone(ErrorMessage = "The submitted number was not valid")]
        public string Phone { get; set; }

        [Url(ErrorMessage = "The submitted url was not valid")]
        public string Website { get; set; }

        [Required(ErrorMessage = "Restaurants must have a country")]
        public int CountryId { get; set; }

        public int? StateId { get; set; }

        [Required(ErrorMessage = "Restaurant must have a city")]
        public int CityId { get; set; }

        [DisplayName("Creation Date")]
        public DateTime CreateWhen { get; set; }
    }
}
