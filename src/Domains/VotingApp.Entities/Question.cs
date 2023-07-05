using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Question :IEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Option> Options { get; set; }

    }
}
