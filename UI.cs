using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace task1Point
{
    internal class UI
    {
        public static string menu()
        {
            string choice = null;
           
                Console.WriteLine("1-Make a Line");
                Console.WriteLine("2-Update the Begining Point");
                Console.WriteLine("3-Update the End Point");
                Console.WriteLine("4-Show begin Point");
                Console.WriteLine("5-Show End Point");
                Console.WriteLine("6-Get the Length of Line");
                Console.WriteLine("7-Get the Gradient of Line");
                Console.WriteLine("8-Find the distance of Begin Point from Zero Co-ordinate");
                Console.WriteLine("9-Find the distance of End Point from Zero Co-ordinate");
                Console.WriteLine("10-Exit");
                choice = Console.ReadLine();

                return choice;           
        }
        public static myLine ch1()
        {
            Console.WriteLine("Enter the begining X-Co-ordinate of line ");
            int x= int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the begining Y-Co-ordinate of line ");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Ending X-Co-ordinate of line");
            int x2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Ending Y-Co-ordinate of line");
            int y2 = int.Parse(Console.ReadLine());

            myPoint start = new myPoint(x,y);
           
            myPoint end = new myPoint(x2,y2);

            myLine Line= new myLine(start, end);

            return Line;
        }
        public static void prnt(myLine Line)
        {
            Console.WriteLine("Line begining point are:" + "(" + Line.begin.x + "," + Line.begin.y + ")");
            Console.WriteLine("Line begining point are:" + "(" + Line.end.x + "," + Line.end.y + ")");

        }

        public static myPoint ch2()
        {
            Console.WriteLine("Enter new begining X-Co-ordinate of Line:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new begining Y-Co-ordinate of Line:");
            int y = int.Parse(Console.ReadLine());

            myPoint start = new myPoint(x, y);
            return start;

        }
        public static myPoint ch3()
        {
            Console.WriteLine("Enter new ending X-Co-ordinate of Line:");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter new ending Y-Co-ordinate of Line:");
            int y = int.Parse(Console.ReadLine());

            myPoint end = new myPoint(x, y);
            return end;

        }
        public static void prntUpdateStarting(myLine Line)
        {
            Console.WriteLine("Line begining point are:" + "(" + Line.begin.x + "," + Line.begin.y + ")");
           
        }
        public static void prntUpdateEnding(myLine Line)
        {
            Console.WriteLine("Line ending point are:" + "(" + Line.end.x + "," + Line.end.y + ")");
        }
        public static void ch6(double l)
        {
            Console.WriteLine("Length of the Line is:"+" "+l);
        }
        public static void ch7(double g)

        {
            Console.WriteLine("Gradient of the Line is:" + " " + g);
        }
        public static void ch8(double db)
        {
            Console.WriteLine("Distance of the Begining point from zero coordinate is:" + " " + db);
        }
        public static void ch9(double eb)
        {
            Console.WriteLine("Distance of the Ending point from zero coordinate is:" + " " + eb);
        }
    }




}
