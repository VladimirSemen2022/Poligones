using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poligones
{
    internal class MyException : Exception
    {
        public MyException(int num) : base ($"Your answer is wrong!\nPolygon has {num} corners!\n")
        {}
    }
}
