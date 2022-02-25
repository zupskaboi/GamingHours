using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GamingHours
{
    public class SteamIdData
    {
        public string steamid { get; set; }
    }
    public class SteamPlayerData
    {
        public string steamid { get; set; }
        public string personaname { get; set; }
        public string profileurl { get; set; }
        public string realname { get; set; }
    }
    
    public class SteamOwnedGamesData
    {
        public string steamid { get; set;}
        public string game_count { get; set; }
    }
}
