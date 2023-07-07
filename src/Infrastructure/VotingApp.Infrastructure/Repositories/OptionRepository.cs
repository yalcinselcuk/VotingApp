using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public class OptionRepository : IOptionRepository
    {
        public Task CreateAsync(Option entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAync(int id)
        {
            throw new NotImplementedException();
        }

        public Option? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Option?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Option?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Option> GetAllWithPredicate(Expression<Func<Option, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Option?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistsAsync(int optionId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Option entity)
        {
            throw new NotImplementedException();
        }
    }
}
