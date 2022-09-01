using Abp.Application.Services;
using BookflixSolution.MultiTenancy.Dto;

namespace BookflixSolution.MultiTenancy
{
    public interface ITenantAppService : IAsyncCrudAppService<TenantDto, int, PagedTenantResultRequestDto, CreateTenantDto, TenantDto>
    {
    }
}

