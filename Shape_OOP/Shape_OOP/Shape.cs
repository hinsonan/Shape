using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    abstract class Shape
    {
        private int xAxis;
        private int yAxis;
        public Shape()
        {
            xAxis = 0;
            yAxis = 0;
        }
        public Shape(int x, int y)
        {
            xAxis = x;
            yAxis = y;
        }
    }
}
