using JobProcessor.Jobs;

namespace JobProcessor.Processing
{
    public class JobProcessor
    {
        public void ProcessJob(Job job)
        {
            job.Status = JobStatus.Processing;

            // Simulate job processing
            Console.WriteLine($"Processing job {job.Id}...");
            Thread.Sleep(1000); // Simulate some work

            job.Status = JobStatus.Completed;
            Console.WriteLine($"Job {job.Id} completed.");
        }
    }
}
