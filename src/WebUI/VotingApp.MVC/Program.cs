using VotingApp.Infrastructure.Repositories;
using VotingApp.Services;
using VotingApp.Services.Mappings;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();
builder.Services.AddScoped<IPollService, PollService>();//calisacaği servisi söyledik
builder.Services.AddScoped<IPollRepository, EFPollRepository>();

builder.Services.AddScoped<IOptionService, OptionService>();//calisacaği servisi söyledik
builder.Services.AddScoped<IOptionRepository, EFOptionRepository>(); 

builder.Services.AddScoped<IQuestionService, QuestionService>();//calisacaği servisi söyledik
builder.Services.AddScoped<IQuestionRepository, EFQuestionRepository>(); 

builder.Services.AddScoped<IUserService, UserService>();//calisacaği servisi söyledik
builder.Services.AddScoped<IUserRepository, EFUserRepository>();

builder.Services.AddScoped<IVoteService, VoteService>();//calisacaği servisi söyledik
builder.Services.AddScoped<IVoteRepository, EFVoteRepository>();

builder.Services.AddAutoMapper(typeof(MapProfile));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
