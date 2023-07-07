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
    public class UserService : IUserService
    {
        private readonly IUserRepository userRepository;
        private readonly IMapper mapper;

        public UserService(IUserRepository userRepository, IMapper mapper)
        {
            this.userRepository = userRepository;
            this.mapper = mapper;
        }

        public async Task CreateUserAsync(CreateNewUserRequest createNewUserRequest)
        {
            var user = mapper.Map<User>(createNewUserRequest);
            await userRepository.CreateAsync(user);
        }

        public IEnumerable<UserResponse> GetUserResponse()
        {
            var users = userRepository.GetAll();
            var response = mapper.Map<IEnumerable<UserResponse>>(users);
            return response;
        }
        public async Task<UpdateUserRequest> GetUserForUpdateAsync(int id)
        {
            var user = await userRepository.GetAsync(id);
            return mapper.Map<UpdateUserRequest>(user);
        }


        public async Task<bool> UserIsExists(int userId)
        {
            return await userRepository.IsExistsAsync(userId);
        }

        public async Task UpdateUser(UpdateUserRequest updateUserRequest)
        {
            var user = mapper.Map<User>(updateUserRequest);
            await userRepository.UpdateAsync(user);
        }
        public async Task DeleteUser(DeleteUserRequest deleteUserRequest)
        {
            var user = mapper.Map<User>(deleteUserRequest);
            await userRepository.DeleteAsync(user);

        }
        public async Task<DeleteUserRequest> GetUserForDeleteAsync(int id)
        {
            var user = await userRepository.GetAsync(id);
            return mapper.Map<DeleteUserRequest>(user);
        }

        public async Task<int> CreateUserAndReturnIdAsync(CreateNewUserRequest createNewUserRequest)
        {
            var user = mapper.Map<User>(createNewUserRequest);
            await userRepository.CreateAsync(user);
            return user.Id;
        }
    }
}
