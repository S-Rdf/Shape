using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4SideShape
{
    public abstract class _4SideShape
    {
//-------------------------------------Constructors

        public _4SideShape(int side1)
        {
            Side1 = side1;
        }

       public _4SideShape(int side1, int side2)
        {
            Side1 = side1;
            Side2 = side2;
        }

        //-------------------------------------Properties

        private int _side1;
        public int Side1
        {
            get { return _side1; }
            set { _side1 = value; }
        }

        private int _side2;

        public int Side2
        {
            get { return _side2; }
            set { _side2 = value; }
        }

        //-----------------------------Methods
        //public abstract double DiameterCalculate(int side1, int side2);
    }
}
