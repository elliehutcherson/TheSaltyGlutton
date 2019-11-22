using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheSaltyGlutton.Models
{
    [Table("Countries")] 
    public class Country
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; } 

        [Column("Name", TypeName = "varchar(100)")]
        public string Name { get; set; }

        [Column("Iso3", TypeName = "char(3)")]
        [StringLength(3, ErrorMessage = "The Iso3 values cannot exceed 3 characters.")]
        public string Iso3 { get; set; }
        
        [Column("Iso2", TypeName = "char(2)")]
        [StringLength(3, ErrorMessage = "The Iso2 values cannot exceed 2 characters.")]
        public string Iso2 { get; set; }

        public virtual ICollection<State> States { get; set; }
    }
}
