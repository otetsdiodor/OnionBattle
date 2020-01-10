using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionBattle.Domain.Core.GameDomain
{
    public enum ShipState
    {
        Beaten,
        Full
    }

    public class Ship : Entity
    {
        public Guid? ResultStatsId { get; set; }
        //public ResultStats ResultStats { get; set; }
        public List<Coords> Coords { get; set; }
        public ShipState State { get; set; }
        public int Length { get; set; }
        public Ship(int length)
        {
            Length = length;
            State = ShipState.Full;
        }
    }
}
