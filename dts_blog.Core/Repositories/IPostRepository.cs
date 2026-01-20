using dts_blog.Core.Domain.Content;
using dts_blog.Core.Models;
using dts_blog.Core.Models.Content;
using dts_blog.Core.SeedWorks;

namespace dts_blog.Core.Repositories
{
    public interface IPostRepository : IRepository<Post, Guid>
    {
        Task<List<Post>> GetPopularPostsAsync(int count);

        Task<PagedResult<PostInListDto>> GetPostsPagingAsync(string? keyword, Guid? categoryId, int pageIndex = 1, int pageSize = 10);
    }
}
