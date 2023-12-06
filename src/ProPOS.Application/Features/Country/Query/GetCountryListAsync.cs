using AutoMapper;
using MediatR;
using ProPOS.Application.EntityRepository;
using ProPOS.Application.Models;
using ProPOS.SharedKernel.Extensions.Pagging;
using ProPOS.SharedKernel.Extensions.Results;

namespace ProPOS.Application.Features.Country.Query;

public record GetCountryListAsync(int PageSize, int PageIndex, string SearchText) : IRequest<QueryResult<Paging<CountyVm>>>;

public class GetCountryListAsyncHandler(ICountryRepository countryRepository, IMapper mapper)
    : IRequestHandler<GetCountryListAsync, QueryResult<Paging<CountyVm>>>
{
    public async Task<QueryResult<Paging<CountyVm>>> Handle(GetCountryListAsync request, CancellationToken cancellationToken)
    {
        var result = await countryRepository.GetPageAsync(request.PageIndex, request.PageSize,
            p => (string.IsNullOrEmpty(request.SearchText) | p.Name.Contains(request.SearchText)),
            o => o.OrderBy(p => p.Id),
            se => se);

        var data = result.ToPagingModel<SharedKernel.Entities.Country, CountyVm>(mapper);

        return data switch
        {
            not null => new QueryResult<Paging<CountyVm>>(data, QueryResultTypeEnum.Success),
            _ => new QueryResult<Paging<CountyVm>>(null, QueryResultTypeEnum.NotFound)
        };
    }
}
