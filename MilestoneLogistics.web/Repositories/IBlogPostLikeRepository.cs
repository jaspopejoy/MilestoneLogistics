using Microsoft.EntityFrameworkCore;
using MilestoneLogistics.web.Models.Domain;

namespace MilestoneLogistics.web.Repositories
{
    public interface IBlogPostLikeRepository
    {
        Task<BlogPostLike> AddLikeForBlog(BlogPostLike blogPostLike);

        Task<IEnumerable<BlogPostLike>> GetLikesForBlog(Guid blogPostId);

        Task<int> GetTotalLikes(Guid blogPostId);
    }
}
