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
}
