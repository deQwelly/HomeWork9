using HomeWork9_1_.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_1_.Classes
{
    public abstract class Figure : ICanMove
    {
        public enum Color
        {
            Red, Green, Blue, Yellow, Black, White
        }
        public enum VisibleStatus
        {
            Visible, Invisible
        }

        double x, y;
        Color color;
        VisibleStatus status;

        public Figure(double x, double y, Color color, VisibleStatus status)
        {
            this.x = x;
            this.y = y;
            this.color = color;
            this.status = status;
        }

        public VisibleStatus Status
        {
            get
            {
                return status;
            }
        }

        public virtual void MoveHorizontal(double step)
        {
            x += step;
        }

        public virtual void MoveVertical(double step)
        {
            y += step;
        }

        public static void MoveHorizontal(ICanMove figure, double step) 
        {
            Figure o = figure as Figure;
            if (o != null)
            {
                o.x += step;
            }
        }

        public static void MoveVertical(ICanMove figure, double step)
        {
            Figure o = figure as Figure;
            if (o != null)
            {
                o.y += step;
            }
        }


        public void ChangeColor(Figure.Color color)
        {
            this.color = color;
        }

        public void ChangeVisibleStatus()
        {
            if (status == VisibleStatus.Visible)
            {
                status = VisibleStatus.Invisible;
            }
            else
            {
                status = VisibleStatus.Visible;
            }
        }

        public virtual void GetInfo()
        {
            Console.WriteLine($"Координаты: ({x}, {y})\n" +
                $"Цвет: {color}\n" +
                $"Статус видимости: {status}");
        }
    }
}
