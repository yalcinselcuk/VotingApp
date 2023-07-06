using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Option : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int Count { get; set; }

        public int PollId { get; set; }
        public Poll? Poll { get; set; }

    }
}
