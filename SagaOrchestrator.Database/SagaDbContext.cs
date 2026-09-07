using Microsoft.EntityFrameworkCore;
using SagaOrchestrator.Database.Entities;

namespace SagaOrchestrator.Database;

public class SagaDbContext : DbContext
{
    public SagaDbContext(DbContextOptions<SagaDbContext> options)
        : base(options)
    {
    }

    public DbSet<BookingSagaEntity> Sagas { get; set; }

    public DbSet<SagaStepEntity> Steps { get; set; }
}