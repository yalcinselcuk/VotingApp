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
        Task UpdateQuestion(UpdateQuestionRequest updateQuestionRequest);
        Task DeleteQuestion(DeleteQuestionRequest deleteQuestionRequest);

        Task<DeleteQuestionRequest> GetQuestionForDeleteAsync(int id);
        Task<UpdateQuestionRequest> GetQuestionForUpdateAsync(int id);
        Task<bool> QuestionIsExists(int questionId);
    }
}
