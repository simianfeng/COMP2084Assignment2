using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment2.Models
{
    public class Course
    {
        [Key]
        public int CourseID { get; set; }
        [Required]
        [Column(Order = 1, TypeName = "nvarchar(50)")]
        public string CourseCode { get; set; }
        [Required]
        [Column(Order = 2, TypeName = "nvarchar(50)")]
        public string CourseName { get; set; }

        [Column(Order = 3, TypeName = "int")]
        public int CourseCampus { get; set; }

        [Column(Order = 4, TypeName = "int")]
        public int CourseProf { get; set; }

    }
}
