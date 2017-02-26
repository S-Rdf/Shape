using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4SideShape
{
    class Square : _4SideShape
    {
        public Square(int side): base (side)
        {
        }

        public int Area(int side)
        {
            return side*side;
        }

        public int Environment(int side)
        {
            return 4*side;
        }
    }
}
