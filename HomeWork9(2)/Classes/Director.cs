using HomeWork9_2_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_2_.Classes
{
    public class Director
    {
        string Name { get; }

        Director(string name) 
        {
            Name = name;
        }

        private static Director director = null;

        public static Director SetDirector(string name)
        {
            if (director == null)
            {
                director = new Director(name);
            }
            return director;
        }

        public static void AddGame(IPlayGame game1, IPlayGame game2, IPlayGame game3, IPlayGame game4, IPlayGame game5, IPlayGame game6)
        {
            BigRaces.AddGame(game1);
            BigRaces.AddGame(game2);
            BigRaces.AddGame(game3);
            BigRaces.AddGame(game4);
            BigRaces.AddGame(game5);
            BigRaces.AddGame(game6);
        }
    }
}
