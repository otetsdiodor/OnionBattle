using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionBattle.Domain.Core.GameDomain
{
    public enum Direction
    {
        Horizontal,
        Vertical
    }
    public class Ship
    {
        public Guid Id { get; set; }
        public List<Cell> Coords { get; set; }
        public int Length { get; set; }
        public Direction Direction { get; set; }
        public Ship(int length)
        {
            Id = Guid.NewGuid();
            Length = length;
            Direction = Direction.Vertical;
        }
    }
}
