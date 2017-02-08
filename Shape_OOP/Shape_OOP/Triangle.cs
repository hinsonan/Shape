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
        public double Base { get; set; }
        public double Height { get; set; }

        public Triangle(double side1, double side2, double side3, int x = 0, int y = 0)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            xAxis = 0;
            yAxis = 0;
        }

        public Triangle(double triBase, double triHeight, int x = 0, int y = 0)
        {
            Base = triBase;
            Height = triHeight;
            xAxis = x;
            yAxis = y;
        }

        public override double Area()
        {
            throw new NotImplementedException();
        }

        public override double Perimeter()
        {
            return (Side1 + Side2 + Side3);
        }

        
       

    }   
}
