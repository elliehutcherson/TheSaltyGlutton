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
    public class State
    {
        [BsonId]
        public int Id { get; set; } 

        public string Name { get; set; }

        public string Abbreviation { get; set; }

        public int CountryId { get; set; }
    }
}
