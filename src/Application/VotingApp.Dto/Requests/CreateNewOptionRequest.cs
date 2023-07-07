using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Dto.Requests
{
    public class CreateNewOptionRequest
    {
        [Required]
        public string Name { get; set; }
        public int Count { get; set; }

        public int PollId { get; set; }
        public Poll? Poll { get; set; }
    }
}
