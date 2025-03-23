using Microsoft.EntityFrameworkCore.Infrastructure;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02.Entites
{
    internal class Student
    {
        public int Id { get; set; }
        public string Fname { get; set; }
        public string? Lname { get; set; }

        public int? Age { get; set; }
        public string Address { get; set; }

        public int? Dept_ID { get; set; }

        #region StudentDepartment
        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [InverseProperty(nameof(Department.students))]
        public Department Department { get; set; }
        #endregion

        #region StudentCourse
        public ICollection<StudentCourse> StudentCourses { get; set; } = new HashSet<StudentCourse>();
        #endregion



    }
}
