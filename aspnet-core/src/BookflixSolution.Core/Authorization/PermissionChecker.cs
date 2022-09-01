using Abp.Authorization;
using BookflixSolution.Authorization.Roles;
using BookflixSolution.Authorization.Users;

namespace BookflixSolution.Authorization
{
    public class PermissionChecker : PermissionChecker<Role, User>
    {
        public PermissionChecker(UserManager userManager)
            : base(userManager)
        {
        }
    }
}
