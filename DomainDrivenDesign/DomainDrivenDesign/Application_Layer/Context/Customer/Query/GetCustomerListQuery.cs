using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace Application_Layer.Context.Customer.Query
{
    public class GetCustomerListQuery : IRequest<string>
    {
        public class Handler : IRequestHandler<GetCustomerListQuery, string>
        {
            public Handler()
            {

            }

            public async Task<string> Handle(GetCustomerListQuery request, CancellationToken cancellationToken)
            {
                return "TEST REQUEST";
            }
        }
    }
}
