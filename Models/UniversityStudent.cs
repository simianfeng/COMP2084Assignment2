using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class UniversityStudent
    {
        
        [Key]
        public int StudentID { get; set; }

        [Required]
        [Column(Order = 1, TypeName = "nvarchar(50)")]
        public string StudentName { get; set; }
        [Required]
        [Column(Order = 2, TypeName = "int")]
        public int StudentAge { get; set; }

        [Column(Order = 3, TypeName = "int")]
        public int StudentCampus { get; set; }

        [Column(Order = 4, TypeName = "int")]
        public int StudentMajor { get; set; }

    }
}
