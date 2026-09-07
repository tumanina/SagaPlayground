namespace SagaOrchestrator.Database.Entities;

public enum SagaStatus
{
    Running,
    Completed,
    Compensating,
    Cancelled,
    Failed
}
