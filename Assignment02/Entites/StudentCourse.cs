using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02.Entites
{
    internal class StudentCourse
    {
        [ForeignKey("Student")]
        public int St_ID {  get; set; }
        [ForeignKey("Course")]
        public int Couse_ID { get; set; }

        public int Grade {  get; set; }
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}
