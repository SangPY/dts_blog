using dts_blog.Data.EF;
using dts_blog.Data.SeedingData;
using Microsoft.EntityFrameworkCore;

namespace dts_blog.API
{
    public static class MigrationManager
    {
        public static WebApplication MigrateDatabase(this WebApplication app)
        {
            using (var scope = app.Services.CreateScope())
            {
                using (var context = scope.ServiceProvider.GetRequiredService<dtsDbContext>())
                {
                    context.Database.Migrate();
                    new DataSeeder().SeedAsync(context).Wait();
                }
            }
            return app;
        }

    }
}

