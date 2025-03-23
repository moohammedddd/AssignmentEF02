using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02.Entites
{
    internal class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int? Description { get; set; }
        public int? Duration { get; set; }
        [ForeignKey(nameof(Topic))]
        public int? Top_ID { get; set; }
        public Topic Topic { get; set; }
        public ICollection<StudentCourse> Students { get; set; } = new List<StudentCourse>();
        
        public ICollection<CoursIns> CoursIns { get; set; } = new List<CoursIns>();
    }
}
