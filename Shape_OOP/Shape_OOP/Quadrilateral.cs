using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    abstract class Quadrilateral : Shape
    {
        //initialize the properties
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        public double Side4 { get; set; }

        //constructor
        public Quadrilateral(int x = 0, int y = 0):base(x,y)
        {
            
        }


    }
}
