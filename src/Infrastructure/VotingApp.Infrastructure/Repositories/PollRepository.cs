using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public class PollRepository : IPollRepository
    {
        public Task CreateAsync(Poll entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAync(int id)
        {
            throw new NotImplementedException();
        }

        public Poll? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Poll?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Poll?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Poll> GetAllWithPredicate(Expression<Func<Poll, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Poll?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Poll> GetPollsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Poll entity)
        {
            throw new NotImplementedException();
        }
    }
}
