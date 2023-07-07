using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Dto.Requests;
using VotingApp.Dto.Responses;

namespace VotingApp.Services
{
    public interface IQuestionService
    {
        IEnumerable<QuestionResponse> GetQuestionResponse();
        Task CreateQuestionAsync(CreateNewQuestionRequest createNewQuestionRequest);
    }
}
