using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Dto.Responses
{
    public class QuestionResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }

        public ICollection<Option> Options { get; set; }
    }
}
