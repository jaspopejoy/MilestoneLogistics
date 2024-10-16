
using Microsoft.EntityFrameworkCore;
using MilestoneLogistics.web.Data;
using MilestoneLogistics.web.Models.Domain;

namespace MilestoneLogistics.web.Repositories
{
    public class BlogPostLikeRepository : IBlogPostLikeRepository
    {
        private readonly ApplicationDbContext _context;

        public BlogPostLikeRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<BlogPostLike> AddLikeForBlog(BlogPostLike blogPostLike)
        {
            await _context.BlogPostLike.AddAsync(blogPostLike);
            await _context.SaveChangesAsync();
            return blogPostLike;
        }

        public async Task<IEnumerable<BlogPostLike>> GetLikesForBlog(Guid blogPostId)
        {
            return await _context.BlogPostLike.Where(x => x.BlogPostId == blogPostId).ToListAsync();
        }

        public async Task<int> GetTotalLikes(Guid blogPostId)
        {
            return await _context.BlogPostLike.CountAsync(x => x.BlogPostId == blogPostId);
        }
    }
}
