using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheSaltyGlutton.Models
{
    public class ReviewPicture
    {
        public ReviewPicture()
        {
            this.CreateWhen = DateTime.Now;
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [MaxLength(length: 100, ErrorMessage = "Review picture caption may not exceed 100 characters")]
        public string Caption { get; set; }

        public string Path { get; set; }

        public DateTime CreateWhen { get; set; }
    }
}
