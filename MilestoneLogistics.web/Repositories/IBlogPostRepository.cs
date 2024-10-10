using MilestoneLogistics.web.Models.Domain;

namespace MilestoneLogistics.web.Repositories
{
    public interface IBlogPostRepository
    {
        Task<IEnumerable<BlogPost>> GetAllAsync();

        Task<BlogPost?> GetAsync(Guid id);

        Task<BlogPost> AddAsync(BlogPost blogpost);

        Task<BlogPost?> UpdateAsync(BlogPost blogpost);

        Task<BlogPost?> DeleteAsync(Guid id);
    }
}
