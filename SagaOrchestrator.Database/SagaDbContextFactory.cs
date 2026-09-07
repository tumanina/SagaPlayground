using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace SagaOrchestrator.Database;

internal class SagaDbContextFactory : IDesignTimeDbContextFactory<SagaDbContext>
{
    public SagaDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<SagaDbContext>();
        optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=booking;Username=postgres;Password=postgres");

        return new SagaDbContext(optionsBuilder.Options);
    }
}

