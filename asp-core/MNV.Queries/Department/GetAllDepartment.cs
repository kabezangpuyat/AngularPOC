using AutoMapper;
using MediatR;
using Microsoft.EntityFrameworkCore;
using MNV.Core.Database;
using MNV.Core.Exceptions;
using MNV.Core.Providers;
using MNV.Domain.Constants;
using MNV.Domain.Models.Department;
using MNV.Domain.Models.Queries;
using MNV.Domain.Models.Responses;
using MNV.Domain.Models.Responses.Department;
using MNV.Domain.Models.Responses.User;
using MNV.Domain.Models.User;
using MNV.Mappers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MNV.Queries.Department
{
    /// <summary>
    /// It handles our Query, handler except for response.
    /// We put those three in container for code discoverability purpose.
    /// 
    /// Benefits of using records is its immutable
    /// </summary>
    public static class GetAllDepartment
    {
        #region Query
        public class Query : CollectionQuery
        {
            public PagingModel Paging { get; set; }
        }
        #endregion

        #region Handler
        public class GetAllDepartmentHandler : QueryHandler, IRequestHandler<Query, QueryCollectionResponse>
        {
            public GetAllDepartmentHandler(IDataContext dataContext,
                IMapper mapper,
                ICurrentUserProvider currentUserProvider) : base(dataContext, mapper, currentUserProvider)
            {
            }
            public async Task<QueryCollectionResponse> Handle(Query request, CancellationToken cancellationToken)
            {
                var currentuser = _currentUserProvider.GetCurrentUser();
                var data = _dataContext.Department.AsQueryable();
                var count = data.Count();
                if (data is null)
                    throw new DataNoFoundException(ExceptionMessageConstants.DataNotFound);

                if (request.Paging.Page > 0 && request.Paging.PageSize > 0)
                    data = GetPaginated<Domain.Entities.Department>(data, request.Paging);

                var result = _mapper.Map<List<DepartmentViewModel>>(data);

                return await Task.FromResult(new GetAllDepartmentResponse() { Results = result, Total = count });
            }
        }
        #endregion
    }
}
