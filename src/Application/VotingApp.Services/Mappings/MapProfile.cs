using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using VotingApp.Dto.Requests;
using VotingApp.Dto.Responses;
using VotingApp.Entities;

namespace VotingApp.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<Poll, PollResponse>();
            CreateMap<User, UserResponse>();
            CreateMap<Option, OptionService>();
            CreateMap<Question, QuestionResponse>();
            CreateMap<Vote, VoteResponse>();

            CreateMap<CreateNewPollRequest, Poll>();
            CreateMap<CreateNewUserRequest, User>();
            CreateMap<CreateNewOptionRequest, Option>();
            CreateMap<CreateNewQuestionRequest, Question>();
            CreateMap<CreateNewVoteRequest, Vote>();

        }

    }
}
