﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampDay1
{
    internal class BasketballPlayer : Player
    {
        public BasketballPlayer(string firstName, Club club)
        {
            FirstName = firstName;
            Sport = "basketball";
        }
        public override string GetPlayerSport(Player player)
        {
            return player.Sport;
        }
    }
}
