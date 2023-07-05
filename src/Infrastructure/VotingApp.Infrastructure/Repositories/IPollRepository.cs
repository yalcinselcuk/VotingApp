using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public interface IPollRepository : IRepository<Poll>
    {
        public IEnumerable<Poll> GetPollByName(string name);
    }
}