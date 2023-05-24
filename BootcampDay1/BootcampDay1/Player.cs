using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootcampDay1
{
    public abstract class Player : IPlayer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Sport { get; set; }
        public Guid LicenseID { get; set; }
        public Club club { get; set; }

        public virtual string GetPlayerSport(Player player)
        {
            return player.Sport;
        }
    }
}
