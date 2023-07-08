using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        Task<bool> IsExistsAsync(int userId);
        User? IsExistsUser(string username, string password);
    }
}
