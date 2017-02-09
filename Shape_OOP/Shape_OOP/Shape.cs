using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    abstract class Shape
    {
        //initialize struct
        public Position p = new Position();
        public Position Center { get; set; }

        //default constructor
        public Shape()
        {
           
        }
        //Constructor that passes in a new position
        public Shape(int x, int y):this(new Position(x,y))
        {
            
        }
        // makes the center the default 0,0
        public Shape(Position p)
        {
            Center = p;
        }
        //makes the abstract classes that will be used to calculate various shape properties
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
    }
}
