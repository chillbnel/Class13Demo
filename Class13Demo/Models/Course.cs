using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class13Demo.Models
{
    public class Course
    {
        public int ID { get; set; }
        [Required]
        [Display(Name = "Course Name")]
        public String Name { get; set; }

        [Required]
        [EnumDataType(typeof(Technology))]
        public Technology Technology { get; set; }

        [Required]
        public double Price { get; set; }

        public ICollection<CourseEnrollments> Enrollments { get; set; }
        public ICollection<Transcript> Transcripts { get; set; }
    }

    public enum Technology
    {
        [Display(Name =".NET")]
        dotnet,
        python,
        java
    }
}
