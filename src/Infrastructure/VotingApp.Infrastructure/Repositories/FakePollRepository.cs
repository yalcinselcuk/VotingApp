using System;
using System.Collections.Generic;
using System.Linq;
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
                    CreatedBy = new User { Id = 1, FirstName = "Yalçın", LastName = "Selçuk", Email = "yalcinselcukkk@outlook.com", Password = "123", Role = "Admin", UserName = "selçuk" } 
                },
                new Poll{ Id = 2, Title = "Yemekler", Description = "Yemekler hakkında anket", CreatedById = 1,
                    CreatedBy = new User { Id = 1, FirstName = "Yalçın", LastName = "Selçuk", Email = "yalcinselcukkk@outlook.com", Password = "123", Role = "Admin", UserName = "selçuk" }
                },
                new Poll{ Id = 2, Title = "Bilgisayar", Description = "Bilgisayar hakkında anket", CreatedById = 1,
                    CreatedBy = new User { Id = 1, FirstName = "Yalçın", LastName = "Selçuk", Email = "yalcinselcukkk@outlook.com", Password = "123", Role = "Admin", UserName = "selçuk" }
                }
            };
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

        public Task<Poll?> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Poll> GetPollByName(string name)
        {
            throw new NotImplementedException();
        }
    }
}
