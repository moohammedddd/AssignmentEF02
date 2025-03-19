using System;
using System.Collections.Generic;
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
        public int? Top_ID { get; set; }

    }
}
