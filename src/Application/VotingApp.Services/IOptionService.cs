using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Dto.Requests;
using VotingApp.Dto.Responses;

namespace VotingApp.Services
{
    public interface IOptionService
    {
        IEnumerable<OptionResponse> GetOptionResponse();
        Task CreateOptionAsync(CreateNewOptionRequest createNewOptionRequest);
        Task UpdateOption(UpdateOptionRequest updateOptionRequest);
        Task DeleteOption(DeleteOptionRequest deleteOptionRequest);
        Task<DeleteOptionRequest> GetOptionForDeleteAsync(int id);
        Task<UpdateOptionRequest> GetOptionForUpdateAsync(int id);
        Task<bool> OptionIsExists(int optionId);
    }
}
