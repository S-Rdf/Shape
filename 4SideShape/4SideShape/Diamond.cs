using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace _4SideShape
{
    class Diamond : _4SideShape
    {
        public Diamond(int diameter1, int diameter2):base(diameter1,diameter2) 
        {
        }

        public int Area(int diameter1, int diameter2)
        {
            return (diameter1 * diameter2)/2;
        }

        public double Environment(int diameter1, int diameter2)
        {
            return 4*(SideCalculate(diameter1, diameter2));           
        }

        private double SideCalculate(int diameter1, int diameter2)
        {
            return (Math.Sqrt(Math.Pow(diameter1, 2) + Math.Pow(diameter2, 2)))/2;
        }
    }
}
