using Microsoft.EntityFrameworkCore;
using MyBlog.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBlog.Repositories
{
    public class BlogRepository : IBlogRepository
    {
        private readonly BlogContext _context;
        public BlogRepository(BlogContext context)
        {
            _context = context;
        }
        public async Task<Blog> Create(Blog blog)
        {
            _context.Blogs.Add(blog);
            await _context.SaveChangesAsync();

            return blog;
        }

        public async Task Delete(int id)
        {
            var _blogToDelete = await _context.Blogs.FindAsync(id);
            _context.Blogs.Remove(_blogToDelete);
            await _context.SaveChangesAsync();  
        }
        public async Task<IEnumerable<Blog>> Get()
        {
            return await _context.Blogs.ToListAsync();
        }
        public async Task<Blog> Get(int id)
        {
            return await _context.Blogs.FindAsync(id);
        }
        public async Task<Blog> Update(Blog blog)
        {
            _context.Entry(blog).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            return blog;
        }
    }
}
