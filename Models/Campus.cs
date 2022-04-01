using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Campus
    {
        [Key]
        public int CampusID { get; set; }
        [Required]
        [Column(Order = 1, TypeName = "nvarchar(50)")]
        public string CampusName { get; set; }
        [Required]
        [Column(Order = 2, TypeName = "nvarchar(50)")]
        public string CampusLocation { get; set; }
        [Required]
        [Column(Order = 3, TypeName = "int")]
        public int CampusCapacity { get; set; }
        [Required]
        [Column(Order = 4, TypeName = "int")]
        public int NumberOfProfs { get; set; }
    }
}
