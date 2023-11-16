using HomeWork9_2_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_2_.Classes
{
    public class BigRaces
    {
        public enum ParticipatingCountries
        {
            Russia, France, China, Kazakhstan
        }

        List<Team> teams = new List<Team>();
        static Queue<IPlayGame> games = new Queue<IPlayGame>();

        private BigRaces(Team team1, Team team2, Team team3, Team team4)
        {
            teams.Add(team1);
            teams.Add(team2);
            teams.Add(team3);
            teams.Add(team4);
        }

        private static BigRaces bigRaces = null;
        public static BigRaces Create(Team team1, Team team2, Team team3, Team team4)
        {
            if (bigRaces == null)
            {
                bigRaces = new BigRaces(team1, team2, team3, team4);
            }
            return bigRaces;
        }
        
        public static void AddGame(IPlayGame game)
        {
            games.Enqueue(game);
        }

        public static void JustPlay()
        {
            int[] wins = new int[6];
            for (int i = 0; i < 6; i ++)
            {
                wins[i] = games.Dequeue().PlayGame();
            }
            Console.WriteLine($"Большая гонка закончилась! Победу одержала команда {(ParticipatingCountries)wins.Max()}");
        }
    }
}
