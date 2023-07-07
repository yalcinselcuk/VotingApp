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
    public class OptionService : IOptionService
    {
        private readonly IOptionRepository optionRepository;
        private readonly IMapper mapper;

        public OptionService(IOptionRepository optionRepository, IMapper mapper)
        {
            this.optionRepository = optionRepository;
            this.mapper = mapper;
        }

        public async Task CreateOptionAsync(CreateNewOptionRequest createNewOptionRequest)
        {
            var option = mapper.Map<Option>(createNewOptionRequest);
            await optionRepository.CreateAsync(option);
        }

        public IEnumerable<OptionResponse> GetOptionResponse()
        {
            var options = optionRepository.GetAll();
            var response = mapper.Map<IEnumerable<OptionResponse>>(options);
            return response;
        }
    }
}
