using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game.Domain.Entities
{
    public class Word
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public required string _Word { get; set; }
        public required string Description { get; set; }
    }
}
