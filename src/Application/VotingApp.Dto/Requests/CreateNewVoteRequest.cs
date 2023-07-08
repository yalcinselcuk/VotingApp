using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Dto.Requests
{
    public class CreateNewVoteRequest
    {
        [Required]
        public string Value { get; set; }
        public int Count { get; set; }


    }
}
