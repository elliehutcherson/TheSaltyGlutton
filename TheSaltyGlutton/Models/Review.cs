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
    public class Review
    {
        public Review()
        {
            this.CreateWhen = DateTime.Now;
        }

        [BsonId]
        public string Id { get; set; }

        [MinLength(length: 10, ErrorMessage = "Title must be longer than 10 characters")]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Review must have a restaurant")]
        public string RestaurantId { get; set; }

        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5")]
        [Required(ErrorMessage = "Review must have a rating")]
        public double Rating { get; set; }

        [MinLength(length: 100, ErrorMessage = "Review body must be longer than 100 characters")]
        [Required(ErrorMessage = "Review must have a body")]
        public string Body { get; set; }

        public List<ReviewPicture> ReviewPictures { get; set; }

        [DisplayName("Published")]
        public DateTime CreateWhen { get; set; }
    }
}
