using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02.Entites
{
    internal class CoursIns
    {
        [ForeignKey(nameof(Instrucotr))]
        public int Ins_Id { get; set; }
        public int Course_ID { get; set; }
        public int evaluation { get; set; }
        
        public ICollection<Instrucotr> Instrucotrs { get; set; } = new HashSet<Instrucotr>();

        public ICollection<Course> Courses { get; set;} = new HashSet<Course>();

    }
}
