using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Dto.Requests;
using VotingApp.Dto.Responses;
using VotingApp.Entities;

namespace VotingApp.Services
{
    public interface IUserService
    {
        IEnumerable<UserResponse> GetUserResponse();
        Task CreateUserAsync(CreateNewUserRequest createNewUserRequest1);
        Task<int> CreateUserAndReturnIdAsync(CreateNewUserRequest createNewUserRequest);
        Task UpdateUser(UpdateUserRequest updateUserRequest);
        Task DeleteUser(DeleteUserRequest deleteUserRequest);

        Task<DeleteUserRequest> GetUserForDeleteAsync(int id);
        Task<UpdateUserRequest> GetUserForUpdateAsync(int id);
        Task<bool> UserIsExists(int userId);
        User ValidateUser(string username, string password);
    }
}
