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
        Task<UpdateOptionRequest> GetOptionForUpdateAsync(int id);
        Task UpdateOption(UpdateOptionRequest updateOptionRequest);
        Task<bool> OptionIsExists(int optionId);
    }
}
