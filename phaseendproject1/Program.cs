using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phaseendproject1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        repeat:
            Console.WriteLine("Menu 1 for add player, 2 for remove player, 3 for get player by id,4 for get players by name,5 get all players");
            int ch = Convert.ToInt32(Console.ReadLine());

            //bool status;
            //string temp;
            //status = false;


           // do
         // {
                switch (ch)
                {
                    case 1:
                        OneDayTeam team = new OneDayTeam();

                    if (OneDayTeam.oneDayTeam.Count <= OneDayTeam.oneDayTeam.Capacity)
                    {
                        Console.WriteLine("Enter Player ID");
                        team.playerid = Convert.ToInt32(Console.ReadLine());
                        Console.WriteLine("Enter Player Name:");
                        team.playername = Console.ReadLine();
                        Console.WriteLine("Enter Player Age:");
                        team.playerage = Convert.ToInt32(Console.ReadLine());
                        team.Add(team);
                        Console.WriteLine("You added player sucessfully");
                    }
                    else
                    {
                        Console.WriteLine("You cannot add more than 11 Players.");
                    }

                        break;
                    case 2:
                        
                        OneDayTeam team1 = new OneDayTeam();
                        Console.WriteLine("Enter PlayerID :");
                        int id = Convert.ToInt32(Console.ReadLine());
                        team1.Remove(id);
                        Console.WriteLine("You removed player sucessfully");

                        

                       
                        break;
                    case 3:
                        
                        OneDayTeam team2 = new OneDayTeam();
                        Console.WriteLine("Enter Player ID:");
                        int id1 = Convert.ToInt32(Console.ReadLine());
                        Player p = team2.GetPlayerById(id1);
                        Console.WriteLine("Player ID: " + p.playerid);
                        Console.WriteLine("Player Name: " + p.playername);
                        Console.WriteLine("Player Age: " + p.playerage);


                        

                       break;
                    case 4:
                        OneDayTeam team3 = new OneDayTeam();
                        Console.WriteLine("Enter Player Name:");
                        string name = Console.ReadLine();
                        Player p1 = team3.GetPlayerByName(name);
                        Console.WriteLine("Player ID: " + p1.playerid);
                        Console.WriteLine("Player Name: " + p1.playername);
                        Console.WriteLine("Player Age: " + p1.playerage);
                        break;
                    case 5:
                        Console.WriteLine("All Players details:");
                        List<Player> all = new List<Player>();
                        OneDayTeam o4 = new OneDayTeam();
                        all = o4.GetAllPlayers();
                        foreach (var i in all)
                        {
                            Console.WriteLine("Player ID: " + i.playerid);
                            Console.WriteLine("Player Name: " + i.playername);
                            Console.WriteLine("Player Age: " + i.playerage);
                        }
                        break;

                    default:
                        Environment.Exit(1);
                        break;
                }
            Console.WriteLine("Do you want to continue (yes/no)?");
            string ch1 = Console.ReadLine();
            if (ch1 == "yes")
            {
                goto repeat;
            }
            else if (ch1 == "no")
            {
                Environment.Exit(0);
            }
            
          
            Console.ReadLine();
        }
    }
}











