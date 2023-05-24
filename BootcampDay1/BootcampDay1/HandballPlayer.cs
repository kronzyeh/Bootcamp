using System;
using System.Collections.Generic;
using System.Text;

namespace BootcampDay1
{
    class HandballPlayer :  Player
    {
        public HandballPlayer(string firstName, Club club)
        {
            FirstName = firstName;
            Sport = "handball";
        }
        public override string GetPlayerSport(Player player)
        {
            return player.Sport;
        }
        public bool isLicensed(Guid id)
        {
            if (id == null) return false;
            return true;
        }
    }
}
