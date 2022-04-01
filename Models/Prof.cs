using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Prof
    {
        [Key]
        public int ProfID { get; set; }
        [Required]
        [Column(Order = 1, TypeName = "nvarchar(50)")]
        public string ProfName { get; set; }
        [Required]
        [Column(Order = 2, TypeName = "int")]
        public int ProfAge { get; set; }

        [Column(Order = 3, TypeName = "int")]
        public int ProfCampus { get; set; }

        [Column(Order = 4, TypeName = "int")]
        public int ProfMajor { get; set; }
    }
}
