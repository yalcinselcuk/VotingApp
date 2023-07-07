using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Vote : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Value { get; set; }
        public int? OptionId { get; set; }
        public Option? Option { get; set; }

        public int? PollId { get; set; }
        public Poll? Poll { get; set; }
        public int? UserId { get; set; }//boş geçilebilir
        public User? User { get; set; }
    }
}
