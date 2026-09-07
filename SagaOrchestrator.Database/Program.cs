using Microsoft.EntityFrameworkCore;
using SagaOrchestrator.Database;

var connectionString = "Host=localhost;Port=5432;Database=booking;Username=postgres;Password=postgres";
var builder = new DbContextOptionsBuilder<SagaDbContext>();

builder.EnableSensitiveDataLogging()
       .UseNpgsql(connectionString,
                     opts =>
                     {
                         opts.CommandTimeout((int)TimeSpan.FromMinutes(120).TotalSeconds);
                         opts.EnableRetryOnFailure();
                     });

var dbContext = new SagaDbContext(builder.Options);
dbContext.Database.Migrate();