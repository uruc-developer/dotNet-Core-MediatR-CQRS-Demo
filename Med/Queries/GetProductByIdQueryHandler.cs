using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace MediatRDemo.Med.Queries
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, GetProductViewModel>
    {
        public Task<GetProductViewModel> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var sGuid = Guid.NewGuid();

            var pViewModel =new GetProductViewModel()
            {
                
                Id = sGuid,
                Name = "Book_" //+ sGuid.ToString().Substring(3)
            };

            return Task.FromResult(pViewModel);
            //Get product from repository
        }
    }
}
