using System.Threading.Tasks;
using Abp.Application.Services;
using BookflixSolution.Sessions.Dto;

namespace BookflixSolution.Sessions
{
    public interface ISessionAppService : IApplicationService
    {
        Task<GetCurrentLoginInformationsOutput> GetCurrentLoginInformations();
    }
}
