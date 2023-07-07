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
    public class EFOptionRepository : IOptionRepository
    {
        private readonly VotingDbContext votingDbContext;
        public EFOptionRepository(VotingDbContext votingDbContext)
        {
            this.votingDbContext = votingDbContext;
        }

        public async Task CreateAsync(Option entity)
        {
            await votingDbContext.Options.AddAsync(entity);
            await votingDbContext.SaveChangesAsync();
        }

        public async Task DeleteAsync(Option entity)
        {
            var deletingOption = await votingDbContext.Options.FindAsync(entity.Id);
            votingDbContext.Options.Remove(deletingOption);
            await votingDbContext.SaveChangesAsync();
        }

        public Option? Get(int id)
        {
            return votingDbContext.Options.FirstOrDefault(o => o.Id == id);
        }

        public IList<Option?> GetAll()
        {
            return votingDbContext.Options.AsNoTracking().ToList();
        }

        public async Task<IList<Option?>> GetAllAsync()
        {
            return await votingDbContext.Options.AsNoTracking().ToListAsync();
        }

        public IList<Option> GetAllWithPredicate(Expression<Func<Option, bool>> predicate)
        {
            return votingDbContext.Options.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<Option?> GetAsync(int id)
        {
            return await votingDbContext.Options.AsNoTracking().FirstOrDefaultAsync(o => o.Id == id);
        }

        public async Task<bool> IsExistsAsync(int optionId)
        {
            return await votingDbContext.Options.AnyAsync(o => o.Id == optionId);
        }

        public async Task UpdateAsync(Option entity)
        {
            votingDbContext.Options.Update(entity);
            await votingDbContext.SaveChangesAsync();
        }
    }
}
