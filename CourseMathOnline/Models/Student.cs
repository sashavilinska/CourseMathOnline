using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CourseMathOnline.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FullName { get; set; }
        public string EmaillAddress { get; set; }
        public string Phone { get; set; }
        public int CoursesId { get; set; }
        public Courses Courses { get; set; }
 
    }
}
