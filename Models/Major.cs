using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Major
    {
        [Key]
        public int MajorID { get; set; }
        [Required]
        [Column(Order = 1, TypeName = "nvarchar(50)")]
        public string MajorName { get; set; }
        [Required]
        [Column(Order = 2, TypeName = "int")]
        public int NumberOfProfs { get; set; }
        [Required]
        [Column(Order = 3, TypeName = "int")]
        public int MajorCapacity { get; set; }
        [Required]
        [Column(Order = 4, TypeName = "nvarchar(50)")]
        public string OfficeLocation { get; set; }
    }
}
