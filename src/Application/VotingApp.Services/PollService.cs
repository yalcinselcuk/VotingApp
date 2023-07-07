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
    public class PollService : IPollService
    {
        private readonly IPollRepository pollRepository;
        private readonly IMapper mapper;

        public PollService(IPollRepository pollRepository, IMapper mapper)
        {
            this.pollRepository = pollRepository;
            this.mapper = mapper;
        }

        public  async Task CreatePollAsync(CreateNewPollRequest createNewPollRequest)
        {
            var poll = mapper.Map<Poll>(createNewPollRequest);
            await pollRepository.CreateAsync(poll);
        }

        public IEnumerable<PollResponse> GetPollResponse()
        {
            var polls = pollRepository.GetAll();
            var response = mapper.Map<IEnumerable<PollResponse>>(polls);
            return response;
        }
    }
}
