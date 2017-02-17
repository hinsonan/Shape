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
        public double Length {
            get
            {
                return Side1;
            }
            set
            {
                Side1 = value;
            }
        }
        public double Width {
            get
            {
                return Side2;
            }
            set
            {
                Side2 = value;
            }

        }

        //constructor that assigns length and width and position if the user specifies
        public Rectangle(double l, double w, int x = 0, int y = 0):base(x,y) 
        {
            Side1 = l;
            Side2 = w;
           

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

        public override string ToString()
        {
            return $"Length: {Side1} Width: {Side2} Position: {Center}";
        }

    }
}
