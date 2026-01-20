using dts_blog.Core.Domain.Content;
using dts_blog.Core.Repositories;
using dts_blog.Data.EF;
using dts_blog.Data.SeedWorks;
using Microsoft.EntityFrameworkCore;

namespace dts_blog.Data.Repositories
{
    public class PostRepository : RepositoryBase<Post, Guid>, IPostRepository
    {
        public PostRepository(dtsDbContext context) : base(context)
        {

        }

        public Task<List<Post>> GetPopularPostsAsync(int count)
        {
            return _context.Posts.OrderByDescending(x => x.ViewCount).Take(count).ToListAsync();
        }

    }
}
