using AutoMapper;
using dts_blog.Core.Repositories;
using dts_blog.Core.SeedWorks;
using dts_blog.Data.EF;
using dts_blog.Data.Repositories;

namespace dts_blog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly dtsDbContext _context;
        public IPostRepository Posts { get; private set; }

        public UnitOfWork(dtsDbContext context, IMapper mapper)
        {
            _context = context;
            Posts = new PostRepository(context, mapper);
        }

        public async Task<int> CompleteAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }

    }
}
