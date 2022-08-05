using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinearRegression
{
    class CoordinateList
    {
        public List<Coordinates> coordinates { get; set; }

        public int xTotal { get; private set; }
        public int yTotal { get; private set; }
        public int xyTotal { get; private set; }

        public double xSquaredTotal { get; private set; }
        public double ySquaredTotal { get; private set; }

        public CoordinateList()
        {
            coordinates = new List<Coordinates>();
            xTotal = 0;
            yTotal = 0;
            xyTotal = 0;
            xSquaredTotal = 0;
            ySquaredTotal = 0;
        }

        public void Add(Coordinates coordinate)
        {
            coordinates.Add(coordinate);
            xTotal = xTotal + coordinate.X;
            yTotal = yTotal + coordinate.Y;
            xyTotal = xyTotal + coordinate.XY;
            xSquaredTotal = xSquaredTotal + Math.Pow(coordinate.X, 2);
            ySquaredTotal = ySquaredTotal + Math.Pow(coordinate.Y, 2);
        }
    }
}
