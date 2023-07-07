using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Dto.Requests;
using VotingApp.Dto.Responses;

namespace VotingApp.Services
{
    public interface IUserService
    {
        IEnumerable<UserResponse> GetUserResponse();
        Task CreateUserAsync(CreateNewUserRequest createNewUserRequest1);
        Task<UpdateUserRequest> GetUserForUpdateAsync(int id);
        Task UpdateUser(UpdateUserRequest updateUserRequest);
        Task<bool> UserIsExists(int userId);
    }
}
