using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;
using VotingApp.Infrastructure.Data;

namespace VotingApp.Infrastructure.Repositories
{
    public class EFPollRepository : IPollRepository
    {
        private readonly VotingDbContext votingDbContext;
        public EFPollRepository(VotingDbContext votingDbContext)
        {
            this.votingDbContext = votingDbContext;
        }

        public async Task CreateAsync(Poll entity)
        {
            await votingDbContext.Polls.AddAsync(entity);
            await votingDbContext.SaveChangesAsync();
        }

        public async Task DeleteAync(int id)
        {
            var deletingPoll = await votingDbContext.Polls.FindAsync(id);
            votingDbContext.Polls.Remove(deletingPoll);
            await votingDbContext.SaveChangesAsync();
        }

        public Poll? Get(int id)
        {
            return votingDbContext.Polls.FirstOrDefault(p => p.Id == id);
        }

        public IList<Poll?> GetAll()
        {
            return votingDbContext.Polls.AsNoTracking().ToList();
        }

        public async Task<IList<Poll?>> GetAllAsync()
        {
            return await votingDbContext.Polls.AsNoTracking().ToListAsync();
        }

        public IList<Poll> GetAllWithPredicate(Expression<Func<Poll, bool>> predicate)
        {
            return votingDbContext.Polls.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<Poll?> GetAsync(int id)
        {
            return await votingDbContext.Polls.AsNoTracking().FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task UpdateAsync(Poll entity)
        {
            votingDbContext.Polls.Update(entity);
            await votingDbContext.SaveChangesAsync();
        }
        public IEnumerable<Poll> GetPollsByName(string name)
        {
            throw new NotImplementedException();
        }

    }
}
