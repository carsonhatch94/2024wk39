using _2024wk39.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

public interface IDatabaseService
{
    Task InitializeDatabaseAsync(string connectionString);
}

public class DatabaseService : IDatabaseService
{
    private readonly ApplicationDbContext _context;

    public DatabaseService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task InitializeDatabaseAsync(string connectionString)
    {
        await _context.Database.MigrateAsync();
    }
}
