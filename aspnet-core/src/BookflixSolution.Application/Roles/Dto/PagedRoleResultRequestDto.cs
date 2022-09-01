using Abp.Application.Services.Dto;

namespace BookflixSolution.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

