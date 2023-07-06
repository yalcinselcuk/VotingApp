using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Infrastructure.Repositories
{
    public class FakePollRepository : IPollRepository
    {
        private List<Poll> _polls;

        public FakePollRepository()
        {
            _polls = new()
            {
                new Poll{ Id = 1, Title = "Araba", Description = "Arabalar hakkında anket", CreatedById = 1,
                    CreatedBy = new User { Id = 1, FirstName = "Yalçın", LastName = "Selçuk", Email = "yalcinselcukkk@outlook.com", Password = "123", Role = "Admin", UserName = "selçuk" },
                    Questions = new List<Question>(){
                                    new Question{Id = 1,  Title="Hangi araba daha iyi", 
                                        Options = new List<Option>(){
                                            new Option {Id=1, Name="BMW",Count=3, PollId=1 },
                                            new Option {Id=2, Name="Audi",Count=6, PollId=1 },
                                            new Option {Id=3, Name="Mercedes",Count=1, PollId=1  }
                                        }
                                    },
                                    new Question{Id = 2,  Title="Hangi araba rengi daha iyi",
                                        Options = new List<Option>(){
                                            new Option {Id=1, Name="kırmızı",Count=3, PollId=1 },
                                            new Option {Id=2, Name="sarı",Count=6, PollId=1 },
                                            new Option {Id=3, Name="siyah",Count=1, PollId=1  }
                                        }
                                    }
                    }
                    
                },
                new Poll{ Id = 2, Title = "Bilgisayar", Description = "Bilgisayar hakkında anket", CreatedById = 1,
                    CreatedBy = new User { Id = 1, FirstName = "Yalçın", LastName = "Selçuk", Email = "yalcinselcukkk@outlook.com", Password = "123", Role = "Admin", UserName = "selçuk" },
                    Questions = new List<Question>(){
                                    new Question{Id = 3,  Title="Hangi pc daha iyi",
                                        Options = new List<Option>(){
                                            new Option {Id=1, Name="Acer",Count=3, PollId=2 },
                                            new Option {Id=2, Name="Lenovo",Count=6, PollId=2 },
                                            new Option {Id=3, Name="Casper",Count=1, PollId=2  }
                                        }
                                    },
                                    new Question{Id = 4,  Title="Hangi pc rengi daha iyi",
                                        Options = new List<Option>(){
                                            new Option {Id=1, Name="siyah",Count=3, PollId=2 },
                                            new Option {Id=2, Name="beyaz",Count=6, PollId=2 },
                                            new Option {Id=3, Name="krem",Count=1, PollId=2 }
                                        }
                                    }
                    }
                }
            };
        }

        public Task CreateAsync(Poll entity)
        {
            throw new NotImplementedException();
        }

        public Task DeleteAync(int id)
        {
            throw new NotImplementedException();
        }

        public Poll? Get(int id)
        {
            throw new NotImplementedException();
        }

        public IList<Poll?> GetAll()
        {
            return _polls;
        }

        public Task<IList<Poll?>> GetAllAsync()
        {
            throw new NotImplementedException();
        }

        public IList<Poll> GetAllWithPredicate(Expression<Func<Poll, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Poll?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Poll> GetPollsByName(string name)
        {
            throw new NotImplementedException();
        }

        public Task UpdateAsync(Poll entity)
        {
            throw new NotImplementedException();
        }
    }
}
