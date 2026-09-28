using JobProcessor.Jobs;

namespace JobProcessor.Repositories;
public class InMemoryJobRepository
{
    private readonly Dictionary<Guid, Job> _jobs = new();
}
