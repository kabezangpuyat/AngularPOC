using MNV.Domain.Models.Department;
using MNV.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace MNV.Domain.Models.Responses.Department
{
    public class CreateDepartmentResponse : ICommandQueryResponse
    {
        public CreateDepartmentResponse(DepartmentViewModel department)
        {
            Department = department;
        }
        public DepartmentViewModel Department { get; set; }
    }
}
