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
    public class EFVoteRepository : IVoteRepository
    {
        private readonly VotingDbContext votingDbContext;

        public EFVoteRepository(VotingDbContext votingDbContext)
        {
            this.votingDbContext = votingDbContext;
        }

        public async Task CreateAsync(Vote entity)
        {
            await votingDbContext.Votes.AddAsync(entity);
            await votingDbContext.SaveChangesAsync();
        }

        public async Task DeleteAync(int id)
        {
            var deletingVote = await votingDbContext.Votes.FindAsync(id);
            votingDbContext.Votes.Remove(deletingVote);
            await votingDbContext.SaveChangesAsync();
        }

        public Vote? Get(int id)
        {
            return votingDbContext.Votes.FirstOrDefault(v => v.Id == id);
        }

        public IList<Vote?> GetAll()
        {
            return votingDbContext.Votes.AsNoTracking().ToList();
        }

        public async Task<IList<Vote?>> GetAllAsync()
        {
            return await votingDbContext.Votes.AsNoTracking().ToListAsync();
        }

        public IList<Vote> GetAllWithPredicate(Expression<Func<Vote, bool>> predicate)
        {
            return votingDbContext.Votes.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<Vote?> GetAsync(int id)
        {
            return await votingDbContext.Votes.AsNoTracking().FirstOrDefaultAsync(v => v.Id == id);
        }

        public async Task<bool> IsExistsAsync(int voteId)
        {
            return await votingDbContext.Votes.AnyAsync(v => v.Id == voteId);
        }

        public async Task UpdateAsync(Vote entity)
        {
            votingDbContext.Votes.Update(entity);
            await votingDbContext.SaveChangesAsync();
        }
    }
}
