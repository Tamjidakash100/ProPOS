using AutoMapper;
using ProPOS.SharedKernel.Entities;
using ProPOS.SharedKernel.Interfaces;

namespace ProPOS.Application.Models;
[AutoMap(typeof(Country),ReverseMap = true)]
public class CountyVm:IEntityVM
{
    public long Id{ get;  set ;}
    public string Name { get; set; }=String.Empty;
}