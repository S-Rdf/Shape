using System;


namespace _4SideShape
{
    public abstract class Diamond : _4SideShape
    {
        public  Diamond(int diameter1, int diameter2):base(diameter1,diameter2) 
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

        private  double SideCalculate(int diameter1, int diameter2)
        {
            return (Math.Sqrt(Math.Pow(diameter1, 2) + Math.Pow(diameter2, 2)))/2;
        }

        
        public int Angle(int angle1)
        {
            return (180 - angle1);
        }

        public void Angle (int angle1, int angle2)
        {

        }

    }
}
