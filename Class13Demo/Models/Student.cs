using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Class13Demo.Models
{
    public class Student
    {
        public int ID { get; set; }//assigns a key
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Age { get; set; }

        public ICollection<CourseEnrollments> Courses { get; set; }
        public ICollection<Transcript> Transcripts { get; set; }
    }


}
