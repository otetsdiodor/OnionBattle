﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnionBattle.Domain.Core.GameDomain
{
    public class Ship : Entity
    {
        public List<Cell> Coords { get; set; }
        public int Length { get; set; }
        public Ship(int length)
        {
            Length = length;
        }
    }
}
