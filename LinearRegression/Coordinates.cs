using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    class Coordinates
    {
        public int X { get; set; }
        public int Y { get; set; }

        public int XY { get; set; }

        public Coordinates(int x, int y)
        {
            X = x;
            Y = y;
            XY = x * y;
        }
    }
}
