using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Student
    {
        [Key]
        public Guid StudentID { get; set; }
        public string FirstName { get; set; }
        public string Gender { get; set; }

    }
}