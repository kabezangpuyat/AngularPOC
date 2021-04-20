using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MNV.Domain.Entities
{
    public class Employee : BaseEntity
    {
        public long UserID { get; set; }
        public long DepartmentID { get; set; }
        public string EmployeeID { get; set; }
        public string PhotoFileName { get; set; }
        public DateTimeOffset StartDate { get; set; }

        public virtual User User { get; set; }
        public virtual Department Department { get; set; }
    }
}
