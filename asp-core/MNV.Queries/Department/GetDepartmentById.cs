using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MNV.Mappers;
using MNV.Core.Database;
using MNV.Core.Exceptions;
using MNV.Domain.Constants;
using MNV.Domain.Models.Responses;
using MNV.Domain.Models.Responses.User;
using MNV.Domain.Models.User;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MNV.Core.Providers;
using MNV.Domain.Entities;
using MNV.Domain.Models.Department;

namespace MNV.Queries.Department
{
    /// <summary>
    /// It handles our Query, handler and response.
    /// We put those three in container for code discoverability purpose.
    /// 
    /// Benefits of using records is its immutable
    /// </summary>
    public static class GetDepartmentById 
    {
        #region Query
        public class Query : IQuery 
        {
            public Query(long ID)
            {
                this.ID = ID;
            }
            public long ID { get; set; }
        }

        #endregion

        #region Handler
        public class GetDepartmentByIdHandler : QueryHandler, IRequestHandler<Query, ICommandQueryResponse>
        {
            public GetDepartmentByIdHandler(IDataContext dataContext,
                IMapper mapper,
                ICurrentUserProvider currentUserProvider) : base(dataContext, mapper, currentUserProvider)
            {
            }
            public async Task<ICommandQueryResponse> Handle(Query request, CancellationToken cancellationToken)
            {
                var currentuser = _currentUserProvider.GetCurrentUser();
                var data = await _dataContext.Department.FirstOrDefaultAsync(x => x.ID == request.ID);
                if (data is null)
                    throw new DataNoFoundException(ExceptionMessageConstants.DataNotFound);

                var model = _mapper.Map<DepartmentViewModel>(data);
                   
                var result = new GetDepartmentByIdResponse { Department = model };
                return await Task.FromResult(result);
            }
        }
        #endregion
    }
}
