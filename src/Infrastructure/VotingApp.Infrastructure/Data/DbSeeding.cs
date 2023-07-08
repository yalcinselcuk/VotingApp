using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Data
{
    public static class DbSeeding
    {
        public static void SeedDatabase(VotingDbContext dbContext)
        {
            seedUserIfNotExist(dbContext);
            seedPollIfNotExist(dbContext);
            seedQuestionIfNotExist(dbContext);
            seedOptionIfNotExist(dbContext);
            seedVoteIfNotExist(dbContext);
        }

        
        private static void seedUserIfNotExist(VotingDbContext dbContext)
        {
            if (!dbContext.Users.Any())
            {
                var users = new List<User>()
                {
                    new User { FirstName = "Yalçın", LastName = "Selçuk", Email = "yalcinselcuk@gmail.com", Password = "123", Role = "Admin", UserName="selcuk"},
                    new User { FirstName = "Türkay", LastName = "Ürkmez", Email = "turkayurkmez@gmail.com", Password = "123", Role = "Admin", UserName="turko"},
                    new User { FirstName = "Turkcell", LastName = "A.Ş.", Email = "turkcell@gmail.com", Password = "123", Role = "Admin", UserName="turkcell"}
                };
                dbContext.Users.AddRange(users);
                dbContext.SaveChanges();
            }
        }
        private static void seedPollIfNotExist(VotingDbContext dbContext)
        {
            if (!dbContext.Polls.Any())
            {
                var polls = new List<Poll>()
                {
                    new Poll{ Title = "Araba", Description = "Arabalar hakkında anket", CreatedById = 1 },

                    new Poll{ Title = "Bilgisayar", Description = "Bilgisayar hakkında anket", CreatedById = 1 }

                };
                dbContext.Polls.AddRange(polls);
                dbContext.SaveChanges();
            }

        }
        private static void seedOptionIfNotExist(VotingDbContext dbContext)
        {
            if (!dbContext.Options.Any())
            {
                var options = new List<Option>()
                {
                    new Option {Name="BMW"},
                    new Option {Name="Audi"},
                    new Option {Name="Mercedes"},
                    new Option {Name="kırmızı"},
                    new Option {Name="sarı"},
                    new Option {Name="siyah"},
                    new Option {Name="Acer"},
                    new Option {Name="Lenovo"},
                    new Option {Name="Casper"},
                    new Option {Name="siyah"},
                    new Option {Name="beyaz"},
                    new Option {Name="krem"}

                };
                dbContext.Options.AddRange(options);
                dbContext.SaveChanges();
            }
        }
        private static void seedQuestionIfNotExist(VotingDbContext dbContext)
        {
            if (!dbContext.Questions.Any())
            {
                var questions = new List<Question>()
                {
                    new Question{ Title = "Hangi araba daha iyi" },
                    new Question{ Title="Hangi araba rengi daha iyi"},
                    new Question{ Title="Hangi pc daha iyi" },
                    new Question{ Title="Hangi pc rengi daha iyi" }
                };
                dbContext.Questions.AddRange(questions);
                dbContext.SaveChanges();
            }
        }
        private static void seedVoteIfNotExist(VotingDbContext dbContext)
        {
            if (!dbContext.Votes.Any())
            {
                var votes = new List<Vote>()
                {
                    new Vote {Value="BMW",Count=3},
                    new Vote {Value="Audi",Count=6},
                    new Vote {Value="Mercedes",Count=1},
                    new Vote {Value="kırmızı",Count=3},
                    new Vote {Value="sarı",Count=6},
                    new Vote {Value="siyah",Count=1},
                    new Vote {Value="Acer",Count=3},
                    new Vote {Value="Lenovo",Count=6},
                    new Vote {Value="Casper",Count=1},
                    new Vote {Value="siyah",Count=3},
                    new Vote {Value="beyaz",Count=6},
                    new Vote {Value="krem",Count=1}

                };
                dbContext.Votes.AddRange(votes);
                dbContext.SaveChanges();
            }
        }
    }
}
