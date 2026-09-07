using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SagaOrchestrator.Database.Entities;

namespace PostgreSqlPlayground.Database.Configurations
{
    public class BookingSagaEntityConfiguration : IEntityTypeConfiguration<BookingSagaEntity>
    {
        public void Configure(EntityTypeBuilder<BookingSagaEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status)
                .HasConversion<string>();

            builder.Property(x => x.CurrentStep)
                .HasConversion<string>();


            builder.HasMany(x => x.Steps)
                .WithOne(x => x.Saga)
                .HasForeignKey(x => x.SagaId);
        }
    }
}
