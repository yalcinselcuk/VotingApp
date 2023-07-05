using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Dto.Responses
{
    public class OptionResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Count { get; set; }

        public int PollId { get; set; }
        public Poll Poll { get; set; }
    }
}
