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
        public string? Ins_Id { get; set; } 
        public DateOnly HiringDate { get; set; }
        

    }
}
