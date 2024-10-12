using Microsoft.EntityFrameworkCore;
using MilestoneLogistics.web.Data;
using MilestoneLogistics.web.Models.Domain;

namespace MilestoneLogistics.web.Repositories
{
    public class BlogPostRepository : IBlogPostRepository
    {
        private readonly ApplicationDbContext _context;

        public BlogPostRepository(ApplicationDbContext context)
        {
            this._context = context;
        }

        public async Task<BlogPost> AddAsync(BlogPost blogpost)
        {
            await _context.AddAsync(blogpost);
            await _context.SaveChangesAsync();
            return blogpost;
        }

        public async Task<BlogPost?> DeleteAsync(Guid id)
        {
            var existingBlog = await _context.BlogPosts.FindAsync(id);

            if (existingBlog != null)
            {
                _context.BlogPosts.Remove(existingBlog);
                await _context.SaveChangesAsync();
                return existingBlog;
            }

            return null;
        }

        public async Task<IEnumerable<BlogPost>> GetAllAsync()
        {
            return await _context.BlogPosts.Include(x => x.Tags).ToListAsync();
        }

        public async Task<BlogPost?> GetAsync(Guid id)
        {
            return await _context.BlogPosts.Include(x => x.Tags).FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<BlogPost?> GetByUrlHandleAsync(string urlHandle)
        {
            return await _context.BlogPosts.Include(x => x.Tags).FirstOrDefaultAsync(y => y.UrlHandle == urlHandle);
        }

        public async Task<BlogPost?> UpdateAsync(BlogPost blogpost)
        {
            var existingBlog = await _context.BlogPosts.Include(x => x.Tags).FirstOrDefaultAsync(x => x.Id == blogpost.Id);

            if (existingBlog != null)
            {
                existingBlog.Id = blogpost.Id;
                existingBlog.Heading = blogpost.Heading;
                existingBlog.PageTitle = blogpost.PageTitle;
                existingBlog.Content = blogpost.Content;
                existingBlog.ShortDescription = blogpost.ShortDescription;
                existingBlog.Author = blogpost.Author;
                existingBlog.FeaturedImageUrl = blogpost.FeaturedImageUrl;
                existingBlog.UrlHandle = blogpost.UrlHandle;
                existingBlog.PublishedDate = blogpost.PublishedDate;
                existingBlog.Visible = blogpost.Visible;
                existingBlog.Tags = blogpost.Tags;

                await _context.SaveChangesAsync();
                return existingBlog;
            }

            return null;
        }
    }
}
