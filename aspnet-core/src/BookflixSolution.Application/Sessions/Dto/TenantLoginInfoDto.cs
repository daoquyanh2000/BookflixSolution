using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using BookflixSolution.MultiTenancy;

namespace BookflixSolution.Sessions.Dto
{
    [AutoMapFrom(typeof(Tenant))]
    public class TenantLoginInfoDto : EntityDto
    {
        public string TenancyName { get; set; }

        public string Name { get; set; }
    }
}
