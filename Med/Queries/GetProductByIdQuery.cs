using MediatR;
using System;

namespace MediatRDemo.Med.Queries
{
    public class GetProductByIdQuery : IRequest<GetProductViewModel>
    {
        public Guid Id { get; set; }
    }
}
