using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public class VoteRepository : IVoteRepository
    {
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

        public Task<Vote?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
