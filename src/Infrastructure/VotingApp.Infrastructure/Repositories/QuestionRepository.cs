using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public class QuestionRepository : IQuestionRepository
    {
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

        public Task<Question?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
