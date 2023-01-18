using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DatabaseTask.Core.Domain
{
    public class Project
    {
        [Key]
        public Guid Id { get; set; }
        public string Task { get; set; }
        public string ProjectName { get; set; }

        public int EmployeeCount { get; set; }
        public int ProjectCost { get; set; }

        public DateTime Deadline { get; set; }

        public ConstructionCompany ConstructionCompanyId { get; set; }
    }
}
