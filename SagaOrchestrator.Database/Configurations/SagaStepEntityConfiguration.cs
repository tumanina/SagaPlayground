using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using SagaOrchestrator.Database.Entities;

namespace PostgreSqlPlayground.Database.Configurations
{
    public class SagaStepEntityConfiguration : IEntityTypeConfiguration<SagaStepEntity>
    {
        public void Configure(EntityTypeBuilder<SagaStepEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Status)
                .HasConversion<string>();

            builder.Property(x => x.StepType)
                .HasConversion<string>();


            builder.HasOne(x => x.Saga)
                .WithMany(x => x.Steps)
                .HasForeignKey(x => x.SagaId);
        }
    }
}
