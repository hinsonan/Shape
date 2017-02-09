using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    abstract class Shape
    {
        public Position p = new Position();
        public Position Center { get; set; }
        public Shape()
        {
           
        }
        public Shape(int x, int y):this(new Position(x,y))
        {
            
        }

        public Shape(Position p)
        {
            Center = p;
        }
        public abstract double Area { get; }
        public abstract double Perimeter { get; }
    }
}
