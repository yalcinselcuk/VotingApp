using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public class VoteRepository : IVoteRepository
    {
        public Task CreateAsync(Vote entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAsync(Vote entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAync(int id)
        {
            throw new NotImplementedException();
        }

        public Vote? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Vote?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Vote?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Vote> GetAllWithPredicate(Expression<Func<Vote, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Vote?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistsAsync(int voteId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Vote entity)
        {
            throw new NotImplementedException();
        }
    }
}
