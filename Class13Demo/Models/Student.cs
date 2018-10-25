using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Class13Demo.Models
{
    public class Student
    {
        public int ID { get; set; }//assigns a key

        [Display(Name ="First Name")]
        [StringLength(15, ErrorMessage ="15 characters or less required")]
        public string FirstName { get; set; }
        public string LastName { get; set; }

        [Required]
        [Range(18, 90, ErrorMessage ="Your age is not accepted")]
        public int Age { get; set; }

        public string FullName => $"{FirstName + LastName}";


        public ICollection<CourseEnrollments> Courses { get; set; }
        public ICollection<Transcript> Transcripts { get; set; }
    }


}
