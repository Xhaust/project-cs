using JobProcessor.Jobs;
using JobProcessor.Processing;

namespace JobProcessor.UnitTests;

public class JobProcessingServiceTests
{
    [Fact]
    public async Task ProcessJobAsync_ShouldMarkJobAsCompleted()
    {
        // Arrange
        var processor = new JobProcessingService();
        var job = new Job();

        // Act
        await processor.ProcessJobAsync(job);

        // Assert
        Assert.Equal(JobStatus.Completed, job.Status);
    }
}