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
    public class EFUserRepository : IUserRepository
    {
        private readonly VotingDbContext votingDbContext;

        public async Task CreateAsync(User entity)
        {
            await votingDbContext.Users.AddAsync(entity);
            await votingDbContext.SaveChangesAsync();
        }

        public async Task DeleteAync(int id)
        {
            var deletingUser = await votingDbContext.Users.FindAsync(id);
            votingDbContext.Users.Remove(deletingUser);
            await votingDbContext.SaveChangesAsync();
        }

        public User? Get(int id)
        {
            return votingDbContext.Users.FirstOrDefault(u => u.Id == id);
        }

        public IList<User?> GetAll()
        {
            return votingDbContext.Users.AsNoTracking().ToList();
        }

        public async Task<IList<User?>> GetAllAsync()
        {
            return await votingDbContext.Users.AsNoTracking().ToListAsync();
        }

        public IList<User> GetAllWithPredicate(Expression<Func<User, bool>> predicate)
        {
            return votingDbContext.Users.AsNoTracking().Where(predicate).ToList();
        }

        public async Task<User?> GetAsync(int id)
        {
            return await votingDbContext.Users.AsNoTracking().FirstOrDefaultAsync(u => u.Id == id);
        }

        public async Task UpdateAsync(User entity)
        {
            votingDbContext.Users.Update(entity);
            await votingDbContext.SaveChangesAsync();
        }
    }
}
