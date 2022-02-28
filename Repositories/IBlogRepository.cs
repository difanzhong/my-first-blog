using MyBlog.Models;
using System.Collections;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MyBlog.Repositories
{
    public interface IBlogRepository
    {
         Task<IEnumerable<Blog>> Get();
         Task<Blog> Get(int id);
         Task<Blog> Create(Blog blog);
         Task<Blog> Update(Blog blog);
         Task Delete(int id);
    }
}
