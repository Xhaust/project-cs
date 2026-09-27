namespace JobProcessor.Jobs;

public class Job
{
    public Guid Id { get; init; } = Guid.NewGuid();
    public JobStatus Status { get; set; } = JobStatus.Pending;
    public DateTimeOffset CreatedAt { get; init; } = DateTimeOffset.UtcNow;
}
