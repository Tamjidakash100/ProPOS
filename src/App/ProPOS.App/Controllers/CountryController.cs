using Microsoft.AspNetCore.Mvc;
using ProPOS.App.Controllers.Base;
using ProPOS.Application.Features.Country.Query;
using ProPOS.Application.Models;

namespace ProPOS.App.Controllers;

public class CountryController : ApiControllerBase
{
    [HttpGet]
    public async Task<ActionResult<CountyVm>> GetListAsync(int pageSize = 1, int pageNumber = 10, string searchText = null!)
    {
        return await HandelQueryAsync(new GetCountryListAsync(pageSize, pageNumber, searchText));
    }
}