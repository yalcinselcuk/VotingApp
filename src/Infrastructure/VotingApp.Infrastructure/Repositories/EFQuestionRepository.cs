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
    public class EFQuestionRepository : IQuestionRepository
    {
        private readonly VotingDbContext votingDbContext;

        public async Task CreateAsync(Question entity)
        {
            await votingDbContext.Questions.AddAsync(entity);
            await votingDbContext.SaveChangesAsync();
        }

        public async Task DeleteAync(int id)
        {
            var deletingQuestion = await votingDbContext.Questions.FindAsync(id);
            votingDbContext.Questions.Remove(deletingQuestion);
            await votingDbContext.SaveChangesAsync();
        }

        public Question? Get(int id)
        {
            return votingDbContext.Questions.FirstOrDefault(q => q.Id == id);
        }

        public IList<Question?> GetAll()
        {
            return votingDbContext.Questions.AsNoTracking().ToList();
        }

        public async Task<IList<Question?>> GetAllAsync()
        {
            return await votingDbContext.Questions.AsNoTracking().ToListAsync();
        }

        public IList<Question> GetAllWithPredicate(Expression<Func<Question, bool>> predicate)
        {
            return votingDbContext.Questions.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<Question?> GetAsync(int id)
        {
            return await votingDbContext.Questions.AsNoTracking().FirstOrDefaultAsync(q => q.Id == id);
        }

        public async Task UpdateAsync(Question entity)
        {
            votingDbContext.Questions.Update(entity);
            await votingDbContext.SaveChangesAsync();
        }
    }
}
