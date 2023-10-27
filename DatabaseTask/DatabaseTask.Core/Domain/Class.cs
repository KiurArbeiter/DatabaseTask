using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Class
    {
        [Key]
        public Guid ClassID { get; set; }
        public string Name { get; set; }
        public string ChildrenCount { get; set; }
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
    }
}