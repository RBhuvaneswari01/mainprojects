using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phaseendproject1
{
    public class OneDayTeam :Player, ITeam
    {
        public static List<Player> oneDayTeam = new List<Player>();

        public static int Capacity { get;  set; }

        public OneDayTeam()
        {
            OneDayTeam.Capacity = 11;
        }

        public void Add(Player player)
        {
            oneDayTeam.Add(player);
        }

        public  List<Player> GetAllPlayers()
        {
            
            return oneDayTeam;  
          
        }

        public Player GetPlayerById(int playerId)
        {
            Player p = null;

            foreach (var i in oneDayTeam)
            {
                if (i.playerid == playerId)
                {
                    p = i;
                    break;
                }
                else
                {
                    Console.WriteLine("Player ID not found.");
                }
            }
            return p;
        }

        public Player GetPlayerByName(string playerName)
        {
            Player p = null;

            foreach (var i in oneDayTeam)
            {
                if (i.playername == playerName)
                {
                    p = i;
                    break;
                }
                else
                {
                    Console.WriteLine("Player Name not found.");
                }
            }
            return p;
        }


        public void Remove(int playerId)
        {
            Player p = null;

            foreach (var i in oneDayTeam)
            {
                if (i.playerid == playerId)
                {
                    Console.WriteLine("Player{0} details is removed successfully", i.playerid);
                    p = i;
                }
            }
            oneDayTeam.Remove(p);
        }

    }
}
