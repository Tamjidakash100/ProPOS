using AutoMapper;
using Microsoft.EntityFrameworkCore;
using ProPOS.Application.Models;
using ProPOS.Application.Repository;
using ProPOS.Infraustructure.Persistence;
using ProPOS.SharedKernel.Entities;

namespace ProPOS.Application.EntityRepository.Base
{
    public class CountryRepository(IMapper mapper, ProPOSContext context)
        : BaseRepository<Country, CountyVm, long>(mapper, context);
}
