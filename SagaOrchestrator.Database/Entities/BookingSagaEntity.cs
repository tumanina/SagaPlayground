namespace SagaOrchestrator.Database.Entities;

public class BookingSagaEntity
{
    public Guid Id { get; set; }

    public Guid BookingId { get; set; }

    public SagaStatus Status { get; set; }

    public SagaStepType CurrentStep { get; set; }

    public DateTime CreatedAtUtc { get; set; }

    public DateTime UpdatedAtUtc { get; set; }

    public ICollection<SagaStepEntity> Steps { get; set; } = [];
}
