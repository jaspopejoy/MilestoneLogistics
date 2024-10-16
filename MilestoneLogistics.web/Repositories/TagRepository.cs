﻿using Microsoft.EntityFrameworkCore;
using MilestoneLogistics.web.Data;
using MilestoneLogistics.web.Models.Domain;

namespace MilestoneLogistics.web.Repositories
{
    public class TagRepository : ITagRepository
    {
        private readonly ApplicationDbContext _context;

        public TagRepository(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<Tag> AddAsync(Tag tag)
        {
            await _context.Tags.AddAsync(tag);
            await _context.SaveChangesAsync();
            return tag;
        }

        public async Task<Tag?> DeleteAsync(Guid id)
        {
            var existingTag = await _context.Tags.FindAsync(id);

            if (existingTag != null)
            {
                _context.Tags.Remove(existingTag);
                await _context.SaveChangesAsync();

                return existingTag;
            }
            return null;
        }

        public async Task<IEnumerable<Tag>> GetAllAsync(string? searchQurey,
                                                        string? sortBy,
                                                        string? sortDirection,
                                                        int pageNumber = 1,
                                                        int pageSize = 100)
        {
            var query = _context.Tags.AsQueryable();

            // filtering
            if(string.IsNullOrWhiteSpace(searchQurey) == false)
            {
                query = query.Where(x => x.Name.Contains(searchQurey) ||
                                         x.DisplayName.Contains(searchQurey));
            }

            //sorting
            if (string.IsNullOrWhiteSpace(sortBy) == false)
            {
                var isDesc = string.Equals(sortDirection, "Desc", StringComparison.OrdinalIgnoreCase);

                if (string.Equals(sortBy, "Name", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.Name) : query.OrderBy(x => x.Name);
                }
                if (string.Equals(sortBy, "DisplayName", StringComparison.OrdinalIgnoreCase))
                {
                    query = isDesc ? query.OrderByDescending(x => x.DisplayName) : query.OrderBy(x => x.DisplayName);
                }
            }
            //pagination
            //Skip 0 Take 5 -> Page 1 of 5 results
            //Skip 5 Take next 5 -> Page 2 of 5 results
            var skipResults = (pageNumber - 1) * pageSize;
            query = query.Skip(skipResults).Take(pageSize);
            
            return await query.ToListAsync();

        }

        public Task<Tag?> GetAsync(Guid id)
        {
            return _context.Tags.FirstOrDefaultAsync(x => x.Id == id);
        }

        public async Task<Tag?> UpdateAsync(Tag tag)
        {
            var existingTag = await _context.Tags.FindAsync(tag.Id);

            if (existingTag != null)
            {
                existingTag.Name = tag.Name;
                existingTag.DisplayName = tag.DisplayName;

                await _context.SaveChangesAsync();

                return existingTag;
            }

            return null;
        }

        public async Task<int> CountAsync()
        {
            return await _context.Tags.CountAsync();
        }
    }
}
