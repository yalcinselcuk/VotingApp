using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public interface IPollRepository : IRepository<Poll>
    {
        public Task<IEnumerable<Poll>> GetPollsByName(string name);
        Task<bool> IsExistsAsync(int pollId);
    }
}