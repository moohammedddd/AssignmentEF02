using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02.Entites
{
    internal class Topic
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string? Description { get; set; }
        public int? Duration { get; set; }
        public int? Course_ID { get; set; }
        public ICollection<Course> courses { get; set; } = new List<Course>();
    }
}
