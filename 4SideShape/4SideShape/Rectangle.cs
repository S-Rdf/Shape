using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4SideShape
{
    class Rectangle : _4SideShape
    {
        public Rectangle(int height, int width): base(height,width)
        {
        }


        public int Area (int height, int width)
        {
            return height*width;
        }

        public int Environment (int height, int width)
        {
            return 2 * (height + width);
        }



        public double DiameterCalculate(int side1, int side2)
        {
            return Math.Sqrt(Math.Pow(side1,2)+Math.Pow(side2,2));
        }


    }
}
