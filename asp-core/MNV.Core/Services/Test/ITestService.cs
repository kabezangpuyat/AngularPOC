using MNV.Domain.Models.Test;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Services;

namespace MNV.Core.Services.Test
{
    public interface ITestService : IApplicationService
    {
        Task<TestDto> GetById(TestPayloadDto input);
    }
}
