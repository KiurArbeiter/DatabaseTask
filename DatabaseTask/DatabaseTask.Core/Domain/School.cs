using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class School
    {
        [Key]
        public Guid SchoolID { get; set; }
        public string Address { get; set; }
        public string Name { get; set; }
        public IEnumerable<Employee> Employees { get; set; } = new List<Employee>();
        public IEnumerable<Class> Classes { get; set; } = new List<Class>();

    }
}