using Microsoft.EntityFrameworkCore;
using VotingApp.Services.Mappings;
using VotingApp.Services;
using VotingApp.Infrastructure.Repositories;
using VotingApp.Infrastructure.Data;

namespace VotingApp.API.Extensions
{
    public static class IoCExtensions
    {
        public static IServiceCollection AddInjections(this IServiceCollection services, string connectionString)
        {
            

            services.AddScoped<IPollService, PollService>();//calisacaği servisi söyledik
            services.AddScoped<IPollRepository, EFPollRepository>();

            services.AddScoped<IOptionService, OptionService>();//calisacaği servisi söyledik
            services.AddScoped<IOptionRepository, EFOptionRepository>();

            services.AddScoped<IQuestionService, QuestionService>();//calisacaği servisi söyledik
            services.AddScoped<IQuestionRepository, EFQuestionRepository>();

            services.AddScoped<IUserService, UserService>();//calisacaği servisi söyledik
            services.AddScoped<IUserRepository, EFUserRepository>();

            services.AddScoped<IVoteService, VoteService>();//calisacaği servisi söyledik
            services.AddScoped<IVoteRepository, EFVoteRepository>();

            
            services.AddAutoMapper(typeof(MapProfile));

            services.AddDbContext<VotingDbContext>(option => option.UseSqlServer(connectionString));
            return services;
        }
    }
}
