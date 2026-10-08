using JobProcessor.Jobs;
using JobProcessor.Repositories;

namespace JobProcessor.UnitTests;

public class InMemoryJobRepositoryTests
{
    [Fact]
    public void AddJob_GetJobById_ShouldReturnJob()
    {
        // Arrange
        var repository = new InMemoryJobRepository();
        var job = new Job { Id = Guid.NewGuid() };

        // Act
        repository.AddJob(job);
        var retrievedJob = repository.GetJob(job.Id);

        // Assert
        Assert.NotNull(retrievedJob);
    }

    [Fact]
    public void GetJob_WithUnknownId_ReturnsNull()
    {
        // Arrange
        var repository = new InMemoryJobRepository();
        var id = Guid.NewGuid();

        // Act
        var result = repository.GetJob(id);

        // Assert
        Assert.Null(result);
    }

    [Fact]
    public void GetPendingJobs_ShouldReturnOnlyPendingJobs()
    {
        // Arrange
        var repository = new InMemoryJobRepository();
        var pendingJob = new Job { Id = Guid.NewGuid(), Status = JobStatus.Pending };
        var completedJob = new Job { Id = Guid.NewGuid(), Status = JobStatus.Completed };
        repository.AddJob(pendingJob);
        repository.AddJob(completedJob);

        // Act
        var pendingJobs = repository.GetPendingJobs();

        // Assert
        Assert.Contains(pendingJob, pendingJobs);
        Assert.DoesNotContain(completedJob, pendingJobs);
        Assert.Equal(new[] { pendingJob }, pendingJobs);
    }
}
