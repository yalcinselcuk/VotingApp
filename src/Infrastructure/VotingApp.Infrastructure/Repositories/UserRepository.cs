using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public class UserRepository : IUserRepository
    {
        public User? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<User?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IList<User?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public Task<User?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
