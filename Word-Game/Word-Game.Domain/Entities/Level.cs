using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Word_Game.Domain.Entities
{
    public class Level
    {
        public Guid Id { get; set; } = Guid.NewGuid();
        public string? Name { get; set; }
        public long? Coins { get; set; }
        public virtual List<Word>? Words { get; set; }
    }
}
