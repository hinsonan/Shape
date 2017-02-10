using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    class Square : Rectangle
    {
        //initialze the property
        public double Side { get; set; }

        public Square(double side, int x = 0, int y = 0) : base(side,side)
        {
            Side = side;
            p.x = x;
            p.y = y;
        }

    }
}
