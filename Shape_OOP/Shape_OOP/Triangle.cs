using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    class Triangle : Shape
    {
        
        //initialize the properties
        public double Side1 { get; set; }
        public double Side2 { get; set; }
        public double Side3 { get; set; }
        
        //set up the constructor
        public Triangle(double side1, double side2, double side3, int x = 0, int y = 0) : base(x,y)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            
            

        }

        
        //overides the area property so we can find our area
        public override double Area
        {
            get
            {
                double s = (Side1 + Side2 + Side3) / 2.0;
                return Math.Sqrt(s * (s - Side1) * (s - Side2) * (s - Side3));
            }
        }
        //overides the Perimeter property so we can add up the sides
        public override double Perimeter
        {
            get
            {
                return (Side1 + Side2 + Side3);
            }
        }

        public override string ToString()
        {
            return $"Side1: {Side1} Side2: {Side2} Side3: {Side3} Position: {Center}";
        }




    }   
}
