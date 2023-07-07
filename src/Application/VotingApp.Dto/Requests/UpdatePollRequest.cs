using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VotingApp.Entities;

namespace VotingApp.Dto.Requests
{
    public class UpdatePollRequest
    {

        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public ICollection<Question?> Questions { get; set; }
    }
}
