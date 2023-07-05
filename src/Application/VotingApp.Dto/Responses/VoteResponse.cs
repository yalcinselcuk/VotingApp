using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Dto.Responses
{
    public class VoteResponse
    {
        public int Id { get; set; }
        public int OptionId { get; set; }
        public Option Option { get; set; }

        public int PollId { get; set; }
        public Poll Poll { get; set; }
        
    }
}
