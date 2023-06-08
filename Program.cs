using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task1Point
{
    internal class Program
    {
        static void Main(string[] args)
        {
            myLine line = new myLine();
            myPoint start = new myPoint();
            string choice = null;
            do
            {
               choice = UI.menu();
                if (choice == "1")
                {
                    Console.Clear();
                    line = UI.ch1();
                    UI.prnt(line);
                }
                else if (choice == "2")
                {
                    Console.Clear();
                    start = UI.ch2();
                    line.setBegin(start);
                }
                else if (choice == "3")
                {
                    Console.Clear();
                    start = UI.ch3();
                    line.setEnd(start);
                }
                else if (choice == "4")
                {
                    Console.Clear();
                    UI.prntUpdateStarting(line);
                }
                else if (choice == "5")
                {
                    Console.Clear();
                    UI.prntUpdateEnding(line);
                }
                else if (choice == "6")
                {
                    Console.Clear();
                    double length =line. getLength();
                    UI.ch6(length);
                }
                else if (choice == "7")
                {
                    Console.Clear();
                    double grad=line.getGradient();
                    UI.ch7(grad);
                }
                else if (choice == "8")
                {
                    Console.Clear();
                    line.setBegin(start);
                    double disB= start.distanceSFromZero();
                    UI.ch7(disB);
                }
                else if (choice == "9")
                {
                    Console.Clear();
                    line.setEnd(start);
                    double eb = start.distanceEFromZero();
                    UI.ch9(eb);
                }


            } while(choice != "10");
            
        }
    }
}
