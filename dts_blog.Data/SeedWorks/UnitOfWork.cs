using dts_blog.Core.SeedWorks;
using dts_blog.Data.EF;

namespace dts_blog.Data.SeedWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly dtsDbContext _context;

        public UnitOfWork(dtsDbContext context)
        {
            _context = context;
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
