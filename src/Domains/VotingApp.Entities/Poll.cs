using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Poll : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }

        public int CreatedById { get; set; }
        public User CreatedBy { get; set; }

        public ICollection<Question?> Questions { get; set; } 
    }
}
