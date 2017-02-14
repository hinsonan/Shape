using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            //calls the test method of triangle
            TriangleTest();



            Console.ReadKey();
            
            

        }
        private static void TriangleTest()
        {
            //test all the methods of the triangle class
            Triangle tri = new Triangle(10, 15, 16);
            Console.WriteLine(tri.ToString());
            tri.Side1 = 2;
            tri.Side2 = 6;
            tri.Side3 = 10;
            Console.WriteLine(tri.ToString());
        }

    }
}
