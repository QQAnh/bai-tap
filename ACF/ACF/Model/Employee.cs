using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ACF.Model
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Salary { get; set; }
        public string Department { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public EmployeeStatus Status { get; set; }

        public Employee()
        {
            CreatedAt = DateTime.Now;
            UpdatedAt = DateTime.Now;
            Status = EmployeeStatus.Available;

        }

    }
    public enum EmployeeStatus
    {
        Available = 1,
        Deleted = 0
    }
}
