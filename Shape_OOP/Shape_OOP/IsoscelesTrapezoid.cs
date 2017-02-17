using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    class IsoscelesTrapezoid : Quadrilateral
    {
        public double Base1 { get; set; }
        public double Base2 { get; set; }
        public double Altitude { get; set; }

        

        public IsoscelesTrapezoid(double base1, double base2, double altitude, int x = 0, int y = 0):base(x,y)
        {
            Base1 = base1;
            Base2 = base2;
            Altitude = altitude;
          
            
        }

        public override double Area
        {
            get
            {
                return (.5 * (Base1 + Base2) * Altitude);
            }
        }

        public override double Perimeter
        {
            get
            {
                return (Base1 + Base2 + (Altitude*2));
            }
        }

        public override string ToString()
        {
            return $"Base1: {Base1} Base2: {Base2} Altitude: {Altitude} Position: {Center}";
        }


    }
}
