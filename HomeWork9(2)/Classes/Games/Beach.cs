using HomeWork9_2_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace HomeWork9_2_.Classes.Games
{
    public class Beach : IPlayGame
    {
        public int PlayGame()
        {
            Console.WriteLine("Игра пляж началась!");
            Random rnd = new Random();
            Thread.Sleep(1000);
            int winner_num = rnd.Next(0, 4);
            Console.WriteLine($"Игра пляж завершилась, команда {(BigRaces.ParticipatingCountries)winner_num} победила");
            return winner_num;
        }
    }
}
