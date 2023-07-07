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
    public class VoteService : IVoteService
    {
        private readonly IVoteRepository voteRepository;
        private readonly IMapper mapper;

        public VoteService(IVoteRepository voteRepository, IMapper mapper)
        {
            this.voteRepository = voteRepository;
            this.mapper = mapper;
        }

        public async Task CreateVoteAsync(CreateNewVoteRequest createNewVoteRequest)
        {
            var vote = mapper.Map<Vote>(createNewVoteRequest);
            await voteRepository.CreateAsync(vote);
        }

        public IEnumerable<VoteResponse> GetVoteResponse()
        {
            var votes = voteRepository.GetAll();
            var response = mapper.Map<IEnumerable<VoteResponse>>(votes);
            return response;
        }
        public async Task<UpdateVoteRequest> GetVoteForUpdateAsync(int id)
        {
            var vote = await voteRepository.GetAsync(id);
            return mapper.Map<UpdateVoteRequest>(vote);
        }


        public async Task<bool> VoteIsExists(int voteId)
        {
            return await voteRepository.IsExistsAsync(voteId);
        }

        public async Task UpdateVote(UpdateVoteRequest updateVoteRequest)
        {
            var vote = mapper.Map<Vote>(updateVoteRequest);
            await voteRepository.UpdateAsync(vote);
        }

        public Task DeleteVote(DeleteVoteRequest deleteVoteRequest)
        {
            throw new NotImplementedException();
        }

        public Task<DeleteUserRequest> GetUserForDeleteAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
