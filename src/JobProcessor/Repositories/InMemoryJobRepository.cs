using JobProcessor.Jobs;

namespace JobProcessor.Repositories;
public class InMemoryJobRepository
{
    private readonly Dictionary<Guid, Job> _jobs = new();

    public void AddJob(Job job)
    {
        _jobs[job.Id] = job;
    }

    public Job? GetJob(Guid id)
    {
        _jobs.TryGetValue(id, out var job);
        return job;
    }

    public IEnumerable<Job> GetPendingJobs()
    {
        return _jobs.Values.Where(job => job.Status == JobStatus.Pending);
    }
}
