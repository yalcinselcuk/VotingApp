using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Dto.Requests
{
    public class DeleteOptionRequest
    {
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public int? VoteId { get; set; }
        public ICollection<Vote?> Votes { get; set; }
    }
}
