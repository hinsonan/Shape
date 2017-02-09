using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    class Triangle : Shape
    {
        
       
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        

        public Triangle(double side1, double side2, double side3, int x = 0, int y = 0)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            p.x = x;
            p.y = y;
        }

        

        public override double Area
        {
            get
            {
                double s = (Side1 + Side2 + Side3) / 2.0;
                return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
            }
        }

        public override double Perimeter
        {
            get
            {
                return (Side1 + Side2 + Side3);
            }
        }

        
       

    }   
}
