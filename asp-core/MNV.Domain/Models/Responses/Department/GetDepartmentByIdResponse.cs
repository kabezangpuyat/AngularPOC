using MNV.Domain.Models.Department;
using MNV.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Text;

namespace MNV.Domain.Models.Responses.User
{
    public class GetDepartmentByIdResponse : ICommandQueryResponse
    {
        public DepartmentViewModel Department { get; set; }
    }
}
