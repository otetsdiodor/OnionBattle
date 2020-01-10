using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionBattle.Domain.Core.GameDomain
{
    public class StepHistory : Entity
    {
        public Player User { get; set; }
        public Cell Cell { get; set; }
        public Game Game { get; set; }
    }
}
