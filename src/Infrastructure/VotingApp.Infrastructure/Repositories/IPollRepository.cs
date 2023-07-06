using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public interface IPollRepository : IRepository<Poll>
    {
        public IEnumerable<Poll> GetPollsByName(string name);
    }
}