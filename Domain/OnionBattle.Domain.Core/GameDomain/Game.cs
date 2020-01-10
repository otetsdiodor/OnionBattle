﻿using OnionBattle.Domain.Core.ManageDomain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionBattle.Domain.Core.GameDomain
{
    public class Game
    {
        public Guid Id { get; set; }
        public List<Player> Players { get; set; }
        public List<GameHistory> GameHistory { get; set; }
        public bool IsEnded { get; set; }

        public Game(User creator)
        {
            Id = Guid.NewGuid();
            Players = new List<Player>();
            GameHistory = new List<GameHistory>();
            AddPlayer(creator);
        }

        public void AddPlayer(User user)
        {   
            var player = new Player(user);
            if (Players.Count < 2)
            {
                Players.Add(player);
                var gb = new GameBoard(player, 10);
                player.GameBoard = gb;
            }
        }

        public void PlaceShip(Guid playerId,Guid shipId, int x, int y)
        {
            var player = Players.FirstOrDefault(p => p.Id == playerId);
            if (player == null)
                throw new Exception("PLayer is null");

            player.GameBoard.PlaceShip()


        }

        public void Shoot(Player player,int x,int y)
        {
            player.GameBoard.Shoot(x, y);
        }
    }
}
