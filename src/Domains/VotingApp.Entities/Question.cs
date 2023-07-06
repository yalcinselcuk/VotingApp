using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VotingApp.Entities
{
    public class Question :IEntity
    {
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }

        public ICollection<Option?> Options { get; set; }

    }
}
