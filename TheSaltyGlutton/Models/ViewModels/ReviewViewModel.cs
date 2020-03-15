using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace TheSaltyGlutton.Models.ViewModels
{
    public class ReviewViewModel
    {
        [MinLength(length: 10, ErrorMessage = "Title must be longer than 10 characters")]
        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        [Required(ErrorMessage = "Review must have a restaurant")]
        public string RestaurantName { get; set; }

        [Range(0, 5, ErrorMessage = "Rating must be between 0 and 5")]
        [Required(ErrorMessage = "Review must have a rating")]
        public double Rating { get; set; }

        [MinLength(length: 100, ErrorMessage = "Review body must be longer than 100 characters")]
        [Required(ErrorMessage = "Review must have a body")]
        public string Body { get; set; }

        [Required(ErrorMessage = "Each review is required to have a thumbnail")]
        public IFormFile Thumbnail { get; set; }

        public string ThumbnailCaption { get; set; }

        public List<IFormFile> Images { get; set; }

        public List<string> ImageCaptions { get; set; }
    }
}
