using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    class RegularHexgon : Shape
    {
        public double Side { get; set; }

        

        public RegularHexgon(double side, int x = 0, int y =  0):base(x,y)
        {
            Side = side;
            
        }

        public override double Area
        {
            get
            {
                return (((3*Math.Sqrt(3)) / 2) * (Side * Side));
            }
        }

        public override double Perimeter
        {
            get
            {
                return 6 * Side;
            }
        }

        public override string ToString()
        {
            return $"Side: {Side} Position: {Center}";
        }

    }
}
