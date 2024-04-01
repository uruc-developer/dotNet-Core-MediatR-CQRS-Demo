using MediatR;
using Microsoft.AspNetCore.Server.IIS.Core;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo.Med.Queries
{
    public class GetAllProductQuery : IRequest<List<GetProductViewModel>>
    {

        // Handler
        public class GetAllProductQueryHandler : IRequestHandler<GetAllProductQuery, List<GetProductViewModel>>
        {
            //Handler
            public Task<List<GetProductViewModel>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
            {
                var model1 = new GetProductViewModel() { Id = Guid.NewGuid(), Name = "Monitor" };
                var model2 = new GetProductViewModel() { Id = Guid.NewGuid(), Name = "Book" };

                return Task.FromResult(new List<GetProductViewModel> { model1,model2});
            }
        }
    }
}
