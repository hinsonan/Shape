using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    class RightTriangle : Triangle
    {
        public double Hypotenuse { get; set; }
        public double Base {
            get
            {
                return Side1;

            }
            set
            {
                Side1 = value;
            }
        }
        public double Height { get; set; }

        public RightTriangle(double b, double h, int x = 0, int y = 0): base(b, h, 0)
        {
            Base = b;
            Height = h;
        }
    }
}
