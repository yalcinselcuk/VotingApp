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
            //seedVoteIfNotExist(dbContext);
            seedUserIfNotExist(dbContext);
            seedQuestionIfNotExist(dbContext);
            seedPollIfNotExist(dbContext);
            seedOptionIfNotExist(dbContext);
        }

        //private static void seedVoteIfNotExist(VotingDbContext dbContext)
        //{
        //    if (!dbContext.Votes.Any())
        //    {
        //        var votes = new List<Vote>()
        //        {
        //            new Vote{ Id = 1, OptionId = 1, PollId=1 },

        //        };
        //        dbContext.Votes.AddRange(votes);
        //        dbContext.SaveChanges();
        //    }
        //}
        private static void seedUserIfNotExist(VotingDbContext dbContext)
        {
            if (!dbContext.Users.Any())
            {
                var users = new List<User>()
                {
                    new User { Id = 1, FirstName = "Yalçın", LastName = "Selçuk", Email = "yalcinselcuk@gmail.com", Password = "123", Role = "Admin", UserName="selcuk"},
                    new User { Id = 2, FirstName = "Türkay", LastName = "Ürkmez", Email = "turkayurkmez@gmail.com", Password = "123", Role = "Admin", UserName="turko"},
                    new User { Id = 3, FirstName = "Turkcell", LastName = "A.Ş.", Email = "turkcell@gmail.com", Password = "123", Role = "Admin", UserName="turkcell"}
                };
            }
        }
        private static void seedQuestionIfNotExist(VotingDbContext dbContext)
        {
            if (!dbContext.Questions.Any())
            {
                var questions = new List<Question>()
                {
                    new Question{Id = 1, Title = "Hangi araba daha iyi", 
                                            Options = new List<Option>(){
                                                new Option {Id=1, Name="BMW",Count=3, PollId=1 },
                                                new Option {Id=2, Name="Audi",Count=6, PollId=1 },
                                                new Option {Id=3, Name="Mercedes",Count=1, PollId=1  }
                                            }
                    },
                    new Question{Id = 2,  Title="Hangi araba rengi daha iyi", 
                                            Options = new List<Option>(){
                                                new Option {Id=4, Name="kırmızı",Count=3, PollId=1 },
                                                new Option {Id=5, Name="sarı",Count=6, PollId=1 },
                                                new Option {Id=6, Name="siyah",Count=1, PollId=1  }
                                            }
                    },
                    new Question{Id = 3,  Title="Hangi pc daha iyi", 
                                            Options = new List<Option>(){
                                                new Option {Id=7, Name="Acer",Count=3, PollId=2 },
                                                new Option {Id=8, Name="Lenovo",Count=6, PollId=2 },
                                                new Option {Id=9, Name="Casper",Count=1, PollId=2  }
                                            }
                    },
                    new Question{Id = 4,  Title="Hangi pc rengi daha iyi",
                                            Options = new List<Option>(){
                                                new Option {Id=10, Name="siyah",Count=3, PollId=2 },
                                                new Option {Id=11, Name="beyaz",Count=6, PollId=2 },
                                                new Option {Id=12, Name="krem",Count=1, PollId=2 }
                                            }
                    }
                };
            }
        }
        private static void seedPollIfNotExist(VotingDbContext dbContext)
        {
            if (!dbContext.Polls.Any())
            {
                var polls = new List<Poll>()
                {
                    new Poll{ Id = 1, Title = "Araba", Description = "Arabalar hakkında anket", CreatedById = 1,
                        CreatedBy = new User { Id = 1, FirstName = "Yalçın", LastName = "Selçuk", Email = "yalcinselcukkk@outlook.com", Password = "123", Role = "Admin", UserName = "selçuk" },
                        Questions = new List<Question>(){
                                        new Question{Id = 1,  Title="Hangi araba daha iyi",
                                            Options = new List<Option>(){
                                                new Option {Id=1, Name="BMW",Count=3, PollId=1 },
                                                new Option {Id=2, Name="Audi",Count=6, PollId=1 },
                                                new Option {Id=3, Name="Mercedes",Count=1, PollId=1 }
                                            }
                                        },
                                        new Question{Id = 2,  Title="Hangi araba rengi daha iyi",
                                            Options = new List<Option>(){
                                                new Option {Id=4, Name="kırmızı",Count=3, PollId=1 },
                                                new Option {Id=5, Name="sarı",Count=6, PollId=1 },
                                                new Option {Id=6, Name="siyah",Count=1, PollId=1 }
                                            }
                                        }
                        }

                    },
                    new Poll{ Id = 2, Title = "Bilgisayar", Description = "Bilgisayar hakkında anket", CreatedById = 1,
                        CreatedBy = new User { Id = 1, FirstName = "Yalçın", LastName = "Selçuk", Email = "yalcinselcukkk@outlook.com", Password = "123", Role = "Admin", UserName = "selçuk" },
                        Questions = new List<Question>(){
                                        new Question{Id = 3,  Title="Hangi pc daha iyi",
                                            Options = new List<Option>(){
                                                new Option {Id=7, Name="Acer",Count=3, PollId=2 },
                                                new Option {Id=8, Name="Lenovo",Count=6, PollId=2 },
                                                new Option {Id=9, Name="Casper",Count=1, PollId=2 }
                                            }
                                        },
                                        new Question{Id = 4,  Title="Hangi pc rengi daha iyi",
                                            Options = new List<Option>(){
                                                new Option {Id=10, Name="siyah",Count=3, PollId=2 },
                                                new Option {Id=11, Name="beyaz",Count=6, PollId=2 },
                                                new Option {Id=12, Name="krem",Count=1, PollId=2 }
                                            }
                                        }
                        }
                    }
                };
            }

        }
        private static void seedOptionIfNotExist(VotingDbContext dbContext)
        {
            if (!dbContext.Options.Any())
            {
                var options = new List<Option>()
                {
                    new Option {Id=1, Name="BMW",Count=3, PollId=1 },
                    new Option {Id=2, Name="Audi",Count=6, PollId=1 },
                    new Option {Id=3, Name="Mercedes",Count=1, PollId=1 },
                    new Option {Id=4, Name="kırmızı",Count=3, PollId=1 },
                    new Option {Id=5, Name="sarı",Count=6, PollId=1 },
                    new Option {Id=6, Name="siyah",Count=1, PollId=1 },
                    new Option {Id=7, Name="Acer",Count=3, PollId=2 },
                    new Option {Id=8, Name="Lenovo",Count=6, PollId=2 },
                    new Option {Id=9, Name="Casper",Count=1, PollId=2 },
                    new Option {Id=10, Name="siyah",Count=3, PollId=2 },
                    new Option {Id=11, Name="beyaz",Count=6, PollId=2 },
                    new Option {Id=12, Name="krem",Count=1, PollId=2 }

                };
            }
        }

    }
}
