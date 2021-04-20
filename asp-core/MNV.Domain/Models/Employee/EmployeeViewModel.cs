using MNV.Domain.Models.Department;
using MNV.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace MNV.Domain.Models.Employee
{
    public class EmployeeViewModel
    {
        public long ID { get; set; }
        public string EmployeeID { get; set; }
        public string PhotoName { get; set; }
        public string StaartDate { get; set; }
        public UserViewModel User { get; set; }
        public List<DepartmentViewModel> Departments { get; set; } 
        public bool Active { get; set; }
    }
}
