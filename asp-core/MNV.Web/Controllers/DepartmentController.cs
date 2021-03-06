using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using MNV.Domain.Models.Queries;
using MNV.Domain.Models.User;
using MNV.Queries.User;
using MNV.Commands.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MNV.Domain.Models.Requests;
using MNV.Domain.Constants;
using MNV.Queries.Department;
using MNV.Commands.Department;

namespace MNV.Web.Controllers
{
    public class DepartmentController : _BaseController
    {
        #region Constructor(s)
        public DepartmentController(IMediator mediator) : base(mediator)
        {
        }
        #endregion


        #region IActionResult(s)
        [HttpGet("get-all")]
        public async Task<IActionResult> GetAll(int? page = null, int? pagesize = null)
        {
            var collection = new GetAllDepartment.Query() { Paging = new PagingModel { Page = page ?? 0, PageSize = pagesize ?? 0 } };
            return await ExecuteCollectionQuery(collection)
                .ConfigureAwait(false);
        }

        [HttpGet("get-by-id/{id}")]
        public async Task<IActionResult> GetById(long id)
        {
            return await ExecuteQuery(new GetDepartmentById.Query(id))
                .ConfigureAwait(false);
        }

        [HttpPost("create")]
        public async Task<IActionResult> Create(CreateDepartmentRequest model)
        {
            var command = new CreateDepartment.Command { CreateDepartmentRequest = model };
            return await ExecuteCommand(command)
                .ConfigureAwait(false);
        }

        #endregion
    }
}
