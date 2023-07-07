using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Dto.Requests;
using VotingApp.Dto.Responses;

namespace VotingApp.Services
{
    public interface IPollService
    {
        IEnumerable<PollResponse> GetPollResponse();
        Task CreatePollAsync(CreateNewPollRequest createNewPollRequest);
        Task UpdatePoll(UpdatePollRequest updatePollRequest);
        Task DeletePoll(DeletePollRequest deletePollRequest);

        Task<DeletePollRequest> GetPollForDeleteAsync(int id);
        Task<UpdatePollRequest> GetPollForUpdateAsync(int id);
        Task<bool> PollIsExists(int pollId);
    }
}
