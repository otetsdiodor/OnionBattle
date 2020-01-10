using OnionBattle.Domain.Core.ManageDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionBattle.Domain.Core.GameDomain
{
    public enum PlayerStatus
    {
        Active,
        Locked
    }

    public class Player
    {
        public Guid Id { get; set; }
        public User User { get; set; }
        public GameBoard GameBoard { get; set; }
        public PlayerStatus Status { get; set; }
        
        public Player(User user)
        {
            Id = Guid.NewGuid();
            User = user;
        }
    }
}
