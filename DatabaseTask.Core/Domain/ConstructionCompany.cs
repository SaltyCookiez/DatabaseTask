using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class ConstructionCompany
    {
        [Key]
        public Guid Id { get; set; }

        public string CompanyName { get; set; }
        public string Project { get; set; }

        public int Employees { get; set; }
        public int Specialists { get; set; }
        public int Phone { get; set; }
    }
}
