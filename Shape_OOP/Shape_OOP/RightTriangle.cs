using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    class RightTriangle : Triangle
    {
        //initialize the properties

        //the Hypotenuse needs to be read only because you cant set the hypotenuse without re setting the Base and Height
        public double Hypotenuse
        {
            get
            {
                Side3 = Math.Sqrt(((Side1 * Side1) + (Side2 * Side2)));
                return Side3;
            }
            
        }
        public double Base
        {
            get
            {
                return Side1;

            }
            set
            {
                Side1 = value;
            }
        }

        public double Height
        {
            get
            {
                return Side2;
            }
            set
            {
                Side2 = value;

            }
            
        }
        
        //constructor for this class
        public RightTriangle(double b, double h, int x = 0, int y = 0): base(b, h, 0)
        {
            Base = b;
            Height = h;            
            p.x = x;
            p.y = y;
        }
    }
}
