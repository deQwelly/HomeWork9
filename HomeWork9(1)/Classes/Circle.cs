using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_1_.Classes
{
    public class Circle : Point
    {
        double radius;
        double area;

        public Circle(double x, double y, Figure.Color color, Figure.VisibleStatus status, double radius) : base(x, y, color, status) 
        {
            this.radius = radius;
            area = Math.PI * radius * radius;
        }

        public double Area
        {
            get
            {
                return area;
            }
        }

        /*
        public override void MoveHorizontal(double step)
        {
            base.MoveHorizontal(step);
            Console.WriteLine("Окружность сместилась на указанный шаг в горизонтальном направлении");
        }

        public override void MoveVertical(double step)
        {
            base.MoveVertical(step);
            Console.WriteLine("Окружность сместилась на указанный шаг в вертикальном направлении");
        }
        */

        public override void GetInfo()
        {
            ///Console.WriteLine("Окружность: ");
            base.GetInfo();
            Console.WriteLine($"Радиус: {radius}, Площадь: {area}");
        }
    }
}
