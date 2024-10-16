using MilestoneLogistics.web.Models.Domain;
using MilestoneLogistics.web.Models.ViewModels;

namespace MilestoneLogistics.web.Repositories
{
    public interface IBlogPostCommentRepository
    {
        Task<BlogPostComment> AddAsync(BlogPostComment blogPostComment);

        Task<IEnumerable<BlogPostComment>> GetCommentsByBlogIdAsync(Guid blogPostId);
    }
}
