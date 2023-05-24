using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampDay1
{
    internal class FootballPlayer : Player
    {
        public FootballPlayer(string firstName, Club club)
        {
            FirstName = firstName;
            Sport = "football";
        }
        public override string GetPlayerSport(Player player)
        {
            return player.Sport;
        }
        public float GetStats(float goals, int chances)
        {
            return goals / chances;
        }
    }
}
