using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionBattle.Domain.Core.GameDomain
{
    public class ResultStats
    {
        public int id { get; set; }
        public Player Winner { get; set; }
        public int CountOfSteps { get; set; }
        public Game Game { get; set; }
    }
}
