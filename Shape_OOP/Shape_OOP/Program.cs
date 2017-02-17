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
            Console.WriteLine("Triangle Test");
            //calls the test method of triangle
            TriangleTest();

            Console.WriteLine("");

            Console.WriteLine("Right Triangle Test");
            //calls the test method of right triangle
            RightTriangleTest();

            Console.WriteLine("");

            Console.WriteLine("Rectangle Test");
            //calls the test method of rectangle
            RectangleTest();

            Console.WriteLine("");

            Console.WriteLine("Square Test");
            //calls the test method of the square
            SquareTest();

            Console.WriteLine("");

            Console.WriteLine("Isoceles Trapezoid Test");
            //call the test isosceles trapezoid
            IsoscelesTrapezoidTest();

            Console.WriteLine("");

            Console.WriteLine("Regular Hexagon Test");
            //calls the test hexagon 
            RegularHexagonTest();

            Console.WriteLine("");

            Console.WriteLine("Circle Test");
            //calls the circle test
            CircleTest();



            Console.ReadKey();



        }
        private static void TriangleTest()
        {
            //test all the methods of the triangle class
            Triangle tri = new Triangle(10, 15, 16);
            Console.WriteLine(tri.ToString());
            Console.WriteLine("Area: " + tri.Area);
            Console.WriteLine("Perimeter" + tri.Perimeter);

            Console.WriteLine("");

            Triangle tri2 = new Triangle(9, 13, 14, 5, 2);
            Console.WriteLine(tri2.ToString());
            Console.WriteLine("Area: " + tri2.Area);
            Console.WriteLine("Perimeter" + tri2.Perimeter);
        }

        private static void RightTriangleTest()
        {
            //test the methods of the right triangle class
            RightTriangle rightTri = new RightTriangle(10, 15, 5, 3);
            Console.WriteLine(rightTri.ToString());

            Console.WriteLine("");

            RightTriangle rightTri2 = new RightTriangle(5, 11);
            Console.WriteLine(rightTri2.ToString());


        }

        private static void RectangleTest()
        {
            //test the methods of the rectangle class
            Rectangle rec = new Rectangle(20, 30, 2, 3);
            Console.WriteLine(rec.ToString());
            Console.WriteLine("Area: " + rec.Area);
            Console.WriteLine("Perimeter" + rec.Perimeter);

            Console.WriteLine("");

            Rectangle rec2 = new Rectangle(5, 10);
            Console.WriteLine(rec2.ToString());
            Console.WriteLine("Area: " + rec2.Area);
            Console.WriteLine("Perimeter" + rec2.Perimeter);

        }

        private static void SquareTest()
        {
            //test the square class
            Square sq = new Square(4, 2, 3);
            Console.WriteLine(sq.ToString());
            Console.WriteLine("Area: " + sq.Area);
            Console.WriteLine("Perimeter: " + sq.Perimeter);

            Console.WriteLine("");

            Square sq2 = new Square(5);
            Console.WriteLine(sq2.ToString());
            Console.WriteLine("Area: " + sq2.Area);
            Console.WriteLine("Perimeter: " + sq2.Perimeter);
        }

        private static void IsoscelesTrapezoidTest()
        {
            //test IsoscelesTrapezoid class
            IsoscelesTrapezoid trap = new IsoscelesTrapezoid(4, 7, 10, 5, 8);
            Console.WriteLine(trap.ToString());
            Console.WriteLine("Area: " + trap.Area);
            Console.WriteLine("Perimeter: " + trap.Perimeter);

            Console.WriteLine("");

            IsoscelesTrapezoid trap2 = new IsoscelesTrapezoid(4, 7, 10);
            Console.WriteLine(trap2.ToString());
            Console.WriteLine("Area: " + trap2.Area);
            Console.WriteLine("Perimeter: " + trap2.Perimeter);
        }

        private static void RegularHexagonTest()
        {
            //test the hexagon class
            RegularHexgon hex = new RegularHexgon(3, 4, 6);
            Console.WriteLine(hex.ToString());
            Console.WriteLine("Area: " + hex.Area);
            Console.WriteLine("Perimeter: " + hex.Perimeter);

            Console.WriteLine("");

            RegularHexgon hex2 = new RegularHexgon(12);
            Console.WriteLine(hex2.ToString());
            Console.WriteLine("Area: " + hex2.Area);
            Console.WriteLine("Perimeter: " + hex2.Perimeter);

        }

        private static void CircleTest()
        {
            //test the circle class
            Circle c = new Circle(5, 5, 5);
            Console.WriteLine(c.ToString());
            Console.WriteLine("Circumferance: " + c.Perimeter);
            Console.WriteLine("Area: " + c.Area);

            Console.WriteLine("");

            Circle c2 = new Circle(8);
            Console.WriteLine(c2.ToString());
            Console.WriteLine("Circumferance: " + c2.Perimeter);
            Console.WriteLine("Area: " + c2.Area);


        }
    }
}
