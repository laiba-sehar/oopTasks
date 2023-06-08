using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1Point
{
    internal class myPoint
    {
        public myPoint() { }

        public myPoint(int x, int y) 
        {
           this.x = x;
           this.y = y;
        }
        public int x;
        public int y;

        public int getX()
        {
            return x;
        }
        public int getY()
        {
            return y;
        }
        public void setX(int x)
        {
            this.x = x;
        }
        public void setY(int y)
        {
            this.y = y;
        }
        public void setXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
      /*public double distanceWithCord(int x, int y)
        {

        }
        public double distanceWithObj(myPoint another)
        {

        }*/
        public double distanceFromZero()
        {
            double ditance = 0;
            ditance = Math.Sqrt(Math.Pow((x - 0), 2) + Math.Pow((y - 0), 2));
            return ditance;
        }

    }
}
