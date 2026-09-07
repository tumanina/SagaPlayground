namespace SagaOrchestrator.Database.Entities;

public class SagaStepEntity
{
    public Guid Id { get; set; }

    public Guid SagaId { get; set; }

    public BookingSagaEntity Saga { get; set; } = default!;

    public SagaStepType StepType { get; set; }

    public StepStatus Status { get; set; }

    public DateTime? StartedAtUtc { get; set; }

    public DateTime? CompletedAtUtc { get; set; }

    public string? Error { get; set; }

    public int RetryCount { get; set; }
}
