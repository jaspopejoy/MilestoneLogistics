using Microsoft.AspNetCore.Identity;

namespace MilestoneLogistics.web.Repositories
{
    public interface IUserRepository
    {
        Task<IEnumerable<IdentityUser>> GetAll();
    }
}
