using OnionBattle.Domain.Core.ManageDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionBattle.Domain.Core.GameDomain
{
    public class Player : Entity
    {
        public Guid UserId { get;set }
        public User User { get; set; }
        public string UserName { get; set; }
        
        public Player(User user)
        {
            User = user;
        }
    }
}
