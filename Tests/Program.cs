using OnionBattle.Domain.Core.GameDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tests
{
    class Program
    {
        static void Main(string[] args)
        {
            var dan = new Player() { Name = "Dan" };
            var bob = new Player() { Name = "BOB" };
            var game = new Game(dan);
            game.AddPlayer(bob);
        }
    }
}
