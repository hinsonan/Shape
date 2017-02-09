using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shape_OOP
{
    struct Position
    {
        //create properties of the struct
        public int x { get; set; }
        public int y { get; set; }

        //create constructor
        public Position(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        
    }
}
