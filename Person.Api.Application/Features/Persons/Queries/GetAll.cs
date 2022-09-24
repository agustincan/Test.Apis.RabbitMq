using MediatR;
using Repository.Core;

namespace Person.Api.Application.Features.Persons.Queries
{
    public class GetAllQuery: IRequest<GetAllResponse>
    {
        public GetAllQuery()
        {
            
        }
    }

    public class GetAllQueryHandler : IRequestHandler<GetAllQuery, GetAllResponse>
    {
        private readonly IUnitOfWork _unitOfWork;

        public GetAllQueryHandler(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<GetAllResponse> Handle(GetAllQuery request, CancellationToken cancellationToken)
        {
            var result = new GetAllResponse();
            result.Persons = await _unitOfWork.Repository<Domain.Entities.Person>().GetAllAsync();
            return result;
        }
    }    
}
