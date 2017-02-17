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
        public double Side {
            get
            {
                return Side1;
            }
            set
            {
                Side1 = value;
            }
        }

        public Square(double side, int x = 0, int y = 0) : base(side,side, x, y)
        {
            Side1 = side;
            
        }

        public override string ToString()
        {
            return $"Side: {Side} Position: {Center}";
        }

    }
}
