using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    class Triangle : Shape
    {


        public Triangle(double side1, double side2, double side3, int x = 0, int y = 0)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            xAxis = x;
            yAxis = y;
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
            throw new NotImplementedException();
        }


        public double Side1
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
        public double Side2
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
        public double Side3
        {
            get
            {
                return Side3;
            }
            set
            {
                Side3 = value;
            }
        }
        public double Base
        {
            get
            {
                return Base;
            }
            set
            {
                Base = value;
            }
        }
        public double Height
        {
            get
            {
                return Height;
            }
            set
            {
                Height = value;
            }
        }

    }   
}
