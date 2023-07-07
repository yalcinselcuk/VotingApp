using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
        public Task CreateAsync(Question entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAync(int id)
        {
            throw new NotImplementedException();
        }

        public Question? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Question?> GetAll()
        {
            throw new NotImplementedException();
        }

        public Task<IList<Question?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Question> GetAllWithPredicate(Expression<Func<Question, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Question?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExistsAsync(int questionId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Question entity)
        {
            throw new NotImplementedException();
        }
    }
}
