using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1Point
{
    internal class myLine
    {
       public myPoint begin;   // attributes
       public myPoint end;

        public myLine() { }
        public myLine(myPoint begin, myPoint end)  // incomming value
        {
            this.begin = begin;
            this.end = end;
        }
        public myPoint getBegin()
        {           
            return begin;
        } 
        public myPoint getEnd()
        {
           
            return end; 
        }
        public void setBegin(myPoint begin)
        {
           this. begin = begin;
        }
        public void setEnd(myPoint end)
        {
           this. end = end;
        }
        public double getLength()
        {
            double length = 0;
            length=Math.Sqrt(Math.Pow((end.x-begin.x),2)+Math.Pow((end.y-begin.y),2));
            return length;

        }
        public double getGradient()
        {
           double gradient = 0; 
           gradient= (end.y-begin.y)/(end.x-begin.x);

            return gradient;
        }
    }
}
