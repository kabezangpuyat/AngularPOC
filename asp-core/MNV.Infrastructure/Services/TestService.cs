using MNV.Core.Services.Test;
using MNV.Domain.Models.Test;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace MNV.Infrastructure.Services
{
    public class TestService : ITestService
    {
        public async Task<TestDto> GetById(TestPayloadDto input)
        {
            TestDto result = new TestDto { Id = 1, Name = "test" };

            return await Task.FromResult(result);
        }
    }
}
