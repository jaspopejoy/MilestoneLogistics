using Microsoft.EntityFrameworkCore;
using MilestoneLogistics.web.Data;
using MilestoneLogistics.web.Models.Domain;
using MilestoneLogistics.web.Models.ViewModels;

namespace MilestoneLogistics.web.Repositories
{
    public class BlogPostCommentRepository : IBlogPostCommentRepository
    {
        private readonly ApplicationDbContext _context;

        public BlogPostCommentRepository(ApplicationDbContext context) 
        {
            _context = context;
        }

        public async Task<BlogPostComment> AddAsync(BlogPostComment blogPostComment)
        {
            await _context.BlogPostComment.AddAsync(blogPostComment);
            await _context.SaveChangesAsync();
            return blogPostComment;
        }

        public async Task<IEnumerable<BlogPostComment>> GetCommentsByBlogIdAsync(Guid blogPostId)
        {
            return await _context.BlogPostComment.Where(x => x.BlogPostId == blogPostId).ToListAsync();
        }
    }
}
