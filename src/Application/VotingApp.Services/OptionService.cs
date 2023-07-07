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
        public async Task<UpdateOptionRequest> GetOptionForUpdateAsync(int id)
        {
            var option = await optionRepository.GetAsync(id);
            return mapper.Map<UpdateOptionRequest>(option);
        }


        public async Task<bool> OptionIsExists(int optionId)
        {
            return await optionRepository.IsExistsAsync(optionId);
        }

        public async Task UpdateOption(UpdateOptionRequest updateOptionRequest)
        {
            var option = mapper.Map<Option>(updateOptionRequest);
            await optionRepository.UpdateAsync(option);
        }

        public async Task DeleteOption(DeleteOptionRequest deleteOptionRequest)
        {
            var option = mapper.Map<Option>(deleteOptionRequest);
            await optionRepository.DeleteAsync(option);

        }
        public async Task<DeleteOptionRequest> GetOptionForDeleteAsync(int id)
        {
            var option = await optionRepository.GetAsync(id);
            return mapper.Map<DeleteOptionRequest>(option);
        }
    }
}
