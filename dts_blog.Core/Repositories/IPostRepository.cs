using dts_blog.Core.Domain.Content;
using dts_blog.Core.SeedWorks;

namespace dts_blog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);

    }
}
