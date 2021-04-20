using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace MNV.Domain.Models.Requests
{
    public class CreateDepartmentRequest
    {
        public string Name { get; set; }
    }
}
