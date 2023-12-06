using ProPOS.Application.Models;
using ProPOS.Application.Repository;
using ProPOS.SharedKernel.Entities;

namespace ProPOS.Application.EntityRepository;

public interface ICountryRepository:IBaseRepository<Country,CountyVm,long>
{
}