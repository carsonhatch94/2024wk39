using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using _2024wk39.Data;


public class DatabaseInitializer
{
    public static async Task InitializeDatabaseAsync(string connectionString)
    {
        var options = new DbContextOptionsBuilder<ApplicationDbContext>()
            .UseSqlServer(connectionString)
            .Options;

        using (var context = new ApplicationDbContext(options))
        {
            await context.Database.MigrateAsync();
        }
    }
}
