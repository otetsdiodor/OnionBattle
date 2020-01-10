using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionBattle.Domain.Core.GameDomain
{
    public enum CellState
    {
        Hidden, // Клетка, которая не стреляна
        Empty,
        Dead
    }

    public class Cell : Entity
    {
        public int X { get; set; }
        public int Y { get; set; }
        public CellState State { get; set; }
        public Cell(int x,int y)
        {
            X = x;
            Y = y;
            State = CellState.Hidden;
        }
    }
}
