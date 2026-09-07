namespace SagaOrchestrator.Database.Entities;

public enum StepStatus
{
    Pending,
    Running,
    Completed,
    Failed,
    Compensated
}
