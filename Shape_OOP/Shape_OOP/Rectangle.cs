using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    class Rectangle : Quadrilateral
    {
        
        //initialize the properties
        public double Length { get; set; }
        public double Width { get; set; }

        //constructor that assigns length and width and position if the user specifies
        public Rectangle(double l, double w, int x = 0, int y = 0) 
        {
            Length = l;
            Width = w;
            p.x = x;
            p.y = y;

        }

        //area of rectangle
        public override double Area
        {
            get
            {
                return (Length * Width);
            }
        }

        //perimeter of rectangle
        public override double Perimeter
        {
            get
            {
                return ((Length * 2) + (Width * 2));
            }
        }

    }
}
