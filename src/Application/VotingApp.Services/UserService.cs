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
    }
}
