using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Dto.Requests;
using VotingApp.Dto.Responses;

namespace VotingApp.Services
{
    public interface IVoteService
    {
        IEnumerable<VoteResponse> GetVoteResponse();
        Task CreateVoteAsync(CreateNewVoteRequest createNewVoteRequest);
        Task<UpdateVoteRequest> GetVoteForUpdateAsync(int id);
        Task UpdateVote(UpdateVoteRequest updateVoteRequest);
        Task<bool> VoteIsExists(int voteId);
    }
}
