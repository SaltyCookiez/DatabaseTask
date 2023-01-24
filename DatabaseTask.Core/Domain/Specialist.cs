using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Specialist
    {
        [Key]
        public Guid Id { get; set; }
        public string FirstName { get; set; }
        public string Surname { get; set; }
        public string Gender { get; set; }

        public int Salary { get; set; }
        public int Phone { get; set; }

        public Project ProjectKey { get; set; }
    }
}
