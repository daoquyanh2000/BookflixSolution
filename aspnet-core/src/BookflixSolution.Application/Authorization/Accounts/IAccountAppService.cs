using System.Threading.Tasks;
using Abp.Application.Services;
using BookflixSolution.Authorization.Accounts.Dto;

namespace BookflixSolution.Authorization.Accounts
{
    public interface IAccountAppService : IApplicationService
    {
        Task<IsTenantAvailableOutput> IsTenantAvailable(IsTenantAvailableInput input);

        Task<RegisterOutput> Register(RegisterInput input);
    }
}
