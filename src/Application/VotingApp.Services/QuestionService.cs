using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Dto.Requests;
using VotingApp.Dto.Responses;
using VotingApp.Entities;
using VotingApp.Infrastructure.Repositories;

namespace VotingApp.Services
{
    public class QuestionService : IQuestionService
    {
        private readonly IQuestionRepository questionRepository;
        private readonly IMapper mapper;

        public QuestionService(IQuestionRepository questionRepository, IMapper mapper)
        {
            this.questionRepository = questionRepository;
            this.mapper = mapper;
        }

        public async Task CreateQuestionAsync(CreateNewQuestionRequest createNewQuestionRequest)
        {
            var question = mapper.Map<Question>(createNewQuestionRequest);
            await questionRepository.CreateAsync(question);
        }

        public IEnumerable<QuestionResponse> GetQuestionResponse()
        {
            var questions = questionRepository.GetAll();
            var response = mapper.Map<IEnumerable<QuestionResponse>>(questions);
            return response;
        }
        public async Task<UpdateQuestionRequest> GetQuestionForUpdateAsync(int id)
        {
            var question = await questionRepository.GetAsync(id);
            return mapper.Map<UpdateQuestionRequest>(question);
        }


        public async Task<bool> QuestionIsExists(int questionId)
        {
            return await questionRepository.IsExistsAsync(questionId);
        }

        public async Task UpdateQuestion(UpdateQuestionRequest updateQuestionRequest)
        {
            var question = mapper.Map<Question>(updateQuestionRequest);
            await questionRepository.UpdateAsync(question);
        }
    }
}
