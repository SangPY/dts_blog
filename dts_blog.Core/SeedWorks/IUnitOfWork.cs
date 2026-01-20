using dts_blog.Core.Repositories;

namespace dts_blog.Core.SeedWorks
{
    public interface IUnitOfWork
    {
        Task<int> CompleteAsync();

        IPostRepository Posts { get; }
    }
}
