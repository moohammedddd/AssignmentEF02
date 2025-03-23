using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02.Entites
{
    internal class Instrucotr
    {
        [Key]
        public int Ins_Id { get; set; }
        public string Name { get; set; }
        [Required]
        public string Address { get; set; }
        public string Salary { get; set; }
        public int Bouns { get; set; }
        public int HourRate { get; set; }

        [ForeignKey("Department")]
        public int Dept_Id { get; set; }

        [InverseProperty(nameof(Entites.Department.Manager))]
        public Department Manage { get; set; }
        [InverseProperty(nameof(Entites.Department.instrucotrs))]
       public Department Department { get; set; }

        public ICollection<CoursIns> CoursIns { get; set; } = new HashSet<CoursIns>();
        
    }
}
