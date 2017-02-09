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
            Triangle t = new Triangle(10, 20, 30, 0, 0);
            Console.Write(t.Perimeter);
            RightTriangle rt = new RightTriangle(2,3);
            Console.Write(rt.Hypotenuse);
            Console.ReadKey();
            
            

        }
    }
}
