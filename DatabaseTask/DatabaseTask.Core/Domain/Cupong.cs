using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Cupong
    {
        [Key]
        public Guid CupongID { get; set; }
        public int Worth { get; set; }
        public bool Usable { get; set; }
        public IEnumerable<Student> Students { get; set; } = new List<Student>();
    }
}