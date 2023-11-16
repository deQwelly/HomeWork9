using HomeWork9_1_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_1_.Classes
{
    public class Point : Figure
    {
        public Point(double x, double y, Figure.Color color, Figure.VisibleStatus status) : base(x, y, color, status) { }

        /*
        public override void MoveHorizontal(double step)
        {
            base.MoveHorizontal(step);
            Console.WriteLine("Точка сместилась на указанный шаг в горизонтальном направлении");
        }

        
        public override void MoveVertical(double step)
        {
            base.MoveVertical(step);
            Console.WriteLine("Точка сместилась на указанный шаг в вертикальном направлении");
        }
        */

        public override void GetInfo()
        {
            ///Console.WriteLine("Точка: ");
            ///Figure o = this as Figure;
            base.GetInfo();
        }
    }
}
