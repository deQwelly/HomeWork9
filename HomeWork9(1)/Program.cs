using HomeWork9_1_.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_1_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Упражнение 10.1
            Console.WriteLine("Упражнение 10.1: Создать интерфейс ICipher, который определяет методы поддержки шифрования строк");

            ACipher str = new ACipher("abc-EFD");
            Console.WriteLine("\nАлгоритм ACipher: ");
            Console.WriteLine($"Закодированное сообщение {str.Encode()}");
            Console.WriteLine($"Декодированное сообщение {str.Decode()}");

            Console.WriteLine("\nАлгоритм BCipher: ");
            BCipher s = new BCipher("abc-DEF");
            Console.WriteLine($"Закодированное сообщение {s.Encode()}");
            Console.WriteLine($"Декодированное сообщение {s.Decode()}");

            ///Домашнее задание 10.1
            Console.WriteLine("\nДомашнее задание 10.1: Создать класс Figure для работы с геометрическими фигурами");

            Point point = new Point(0, 0, Figure.Color.White, Figure.VisibleStatus.Visible);
            point.MoveHorizontal(5);
            Figure.MoveVertical(point, 5);
            point.GetInfo();

            Console.WriteLine();

            Circle circle = new Circle(0, 0, Figure.Color.Red, Figure.VisibleStatus.Invisible, 5);
            circle.ChangeVisibleStatus();
            Console.WriteLine($"Площадь окружности: {circle.Area}");
            circle.MoveVertical(10.2);
            circle.GetInfo();

            Console.WriteLine();

            Rectangle rectangle = new Rectangle(0, 0, Figure.Color.Yellow, Figure.VisibleStatus.Visible, 5, 5);
            rectangle.MoveVertical(10);
            Figure.MoveVertical(rectangle, 15);
            Console.WriteLine(rectangle.Area);
            rectangle.GetInfo();
        }
    }
}
