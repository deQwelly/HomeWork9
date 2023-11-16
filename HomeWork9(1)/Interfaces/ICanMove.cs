using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork9_1_.Interfaces
{
    public interface ICanMove
    {
        void MoveHorizontal(double step);
        void MoveVertical(double step);
    }
}
