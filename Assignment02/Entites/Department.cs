using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02.Entites
{
    internal class Department
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [ForeignKey(nameof(Manager))]
        public int? Ins_Id { get; set; }
        [InverseProperty(nameof(Instrucotr.Manage))]
        public Instrucotr Manager { get; set; }
        public DateOnly HiringDate { get; set; }

        #region StudentDepartment
        [InverseProperty(nameof(Student.Department))]
        public ICollection<Student> students { get; set; } = new List<Student>();
        #endregion


        #region DepartmentIns
        [InverseProperty(nameof(Instrucotr.Department))]
        public ICollection<Instrucotr> instrucotrs  { get; set;} = new List<Instrucotr>();
        #endregion

    }
}
