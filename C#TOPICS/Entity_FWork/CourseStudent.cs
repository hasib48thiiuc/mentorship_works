using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity_FWork
{
    public class CourseStudent
    {
        public int CourseId { get; set;}

        public int StudentId { get; set;}
        public DateTime CourseEnrollTime { get; set;}

        public Course course { get; set; }

        public Student student { get; set; }

    }
}
