using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using VotingApp.Dto.Responses;
using VotingApp.Entities;

namespace VotingApp.Services.Mappings
{
    public class MapProfile : Profile
    {
        public MapProfile() 
        {
            CreateMap<Poll, PollResponse>();
        }

    }
}
