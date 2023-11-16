using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_1_.Classes
{
    public class Rectangle : Point
    {
        float length, width;
        float area;

        public Rectangle(double x, double y, Figure.Color color, Figure.VisibleStatus status, float length, float width) : base(x, y, color, status)
        {
            this.length = length;
            this.width = width;
            area = length * width;
        }

        public float Area
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
            Console.WriteLine("Прямоугольник сместился на указанный шаг в горизонтальном направлении");
        }

        public override void MoveVertical(double step)
        {
            base.MoveVertical(step);
            Console.WriteLine("Прямоугольник сместился на указанный шаг в вертикальном направлении");
        }
        */

        public override void GetInfo()
        {
            ///Console.WriteLine("Прямоугольник: ");
            base.GetInfo();
            Console.WriteLine($"Длина: {length}, Ширина: {width}, Площадь: {area}");
        }
    }
}
