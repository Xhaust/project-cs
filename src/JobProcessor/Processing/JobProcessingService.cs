using JobProcessor.Jobs;

namespace JobProcessor.Processing
{
    public class JobProcessingService
    {
        public async Task ProcessJobAsync(Job job)
        {
            job.Status = JobStatus.Processing;
            try
            {
                // Simulate job processing
                Console.WriteLine($"Processing job {job.Id}...");
                await Task.Delay(1000); // Simulate some work

                job.Status = JobStatus.Completed;
                Console.WriteLine($"Job {job.Id} completed.");
            }
            catch
            {
                job.Status = JobStatus.Failed;
                throw;
            }
        }
    }
}
