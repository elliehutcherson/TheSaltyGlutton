using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheSaltyGlutton.Models
{
    public class Country
    {
        [BsonId]
        public int Id { get; set; } 

        public string Name { get; set; }

        [StringLength(3, ErrorMessage = "The Iso3 values cannot exceed 3 characters.")]
        public string Iso3 { get; set; }
        
        [StringLength(3, ErrorMessage = "The Iso2 values cannot exceed 2 characters.")]
        public string Iso2 { get; set; }
    }
}
