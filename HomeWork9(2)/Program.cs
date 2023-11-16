using HomeWork9_2_.Classes;
using HomeWork9_2_.Classes.Games;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Team russia_team = new Team(BigRaces.ParticipatingCountries.Russia, "Валерий", "Михаил", "Елена", "Руслан", "Евгений", "Ксения", "Екатерина",
                "Людмила", "Томара", "Александр", "Дмитрий", "Константин", "Валентина", "Ростислав", "Наталья");
            Console.WriteLine(russia_team.ShowTeamMembers());

            Console.WriteLine();

            Team france_team = new Team(BigRaces.ParticipatingCountries.France, "Жоффруа", "Жорж", "Жулен", "Жан-Луи", "Ирен", "Изабель", "Сара",
                "Мариа", "Жизель", "Жаклин", "Риана", "Жерар", "Далиа", "Лина", "Жеральд");
            Console.WriteLine(france_team.ShowTeamMembers());

            Console.WriteLine();

            Team china_team = new Team(BigRaces.ParticipatingCountries.China, "Сюин", "Фан", "Ли", "Юн", "Чао", "Янь", "Цзе",
                "Минь", "Цзюань", "Вэй", "Лэй", "Ся", "Гуйин", "Фан", "Тао");
            Console.WriteLine(china_team.ShowTeamMembers());

            Console.WriteLine();

            Team kazakhstan_team = new Team(BigRaces.ParticipatingCountries.Kazakhstan, "Абай", "Абзал", "Айдар", "Айнур", "Аян", "Газиза", "Гарифолла",
                "Гафура", "Гулзара", "Дара", "Бану", "Бакир", "Базарайым", "Багила", "Думан");
            Console.WriteLine(kazakhstan_team.ShowTeamMembers());

            BigRaces.Create(russia_team, france_team, china_team, kazakhstan_team);

            Director.SetDirector("Оливье Ганьян");
            Director.AddGame(new Beach(), new Fishing(), new Mousetrap(), new Postmen(), new Sea(), new Slide());

            Console.WriteLine();

            BigRaces.JustPlay();
        }
    }
}
