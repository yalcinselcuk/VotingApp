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
            CreateMap<User, UserResponse>();
            CreateMap<Poll, PollResponse>();
            CreateMap<Option, OptionService>();
            CreateMap<Question, QuestionResponse>();
            CreateMap<Vote, VoteResponse>();

            CreateMap<CreateNewPollRequest, Poll>();
            CreateMap<CreateNewUserRequest, User>();
            CreateMap<CreateNewOptionRequest, Option>();
            CreateMap<CreateNewQuestionRequest, Question>();
            CreateMap<CreateNewVoteRequest, Vote>();

            CreateMap<UpdateOptionRequest, Option>().ReverseMap();
            CreateMap<UpdatePollRequest, Poll>().ReverseMap();
            CreateMap<UpdateQuestionRequest, Question>().ReverseMap();
            CreateMap<UpdateUserRequest, User>().ReverseMap();
            CreateMap<UpdateVoteRequest, Vote>().ReverseMap();

            CreateMap<DeleteOptionRequest, Option>().ReverseMap();
            CreateMap<DeletePollRequest, Poll>().ReverseMap();
            CreateMap<DeleteQuestionRequest, Question>().ReverseMap();
            CreateMap<DeleteUserRequest, User>().ReverseMap();
            CreateMap<DeleteVoteRequest, Vote>().ReverseMap();



        }

    }
}
