using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    class Circle : Shape
    {
        public double Radius { get; set; }
        public double Diameter { get; set; }

        public Circle(double radius, int x = 0, int y =0)
        {
            Radius = radius;
            p.x = x;
            p.y = y;

        }
        public override double Area
        {
            get
            {
                return(Math.PI * (Radius * Radius));
            }
        }

        public override double Perimeter
        {
            get
            {
                return (2 * Math.PI * Radius);
            }
        }
    }
}
