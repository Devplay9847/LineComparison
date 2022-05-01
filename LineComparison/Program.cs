using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double x1, y1, x2, y2, x3, y3, x4, y4;
            Console.WriteLine("Input line one x1: ");
            x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input line one y1: ");
            y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input line one x2: ");
            x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input line one Y2: ");
            y2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input line one x3: ");
            x3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input line one Y3: ");
            y3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input line one X4: ");
            x4 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input line one Y4: ");
            y4 = Convert.ToDouble(Console.ReadLine());

            double LengthofLine1 = 0;
            double LengthofLine2 = 0;
            LengthofLine1 = Math.Sqrt((x2 - x1) * 2 + (y2 - y1) * 2);
            LengthofLine2 = Math.Sqrt((x4 - x3) * 2 + (y4 - y3) * 2);
           Console.WriteLine("Lenght of line =" + LengthofLine1);
          Console.ReadLine();
           Console.WriteLine("Lenght of line =" + LengthofLine2);
           Console.ReadLine();

            if (LengthofLine1 == LengthofLine2)
            {
                Console.WriteLine("Two Lines are Equal");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Two Lines are Not Equal");
                Console.ReadLine();
            }
                if (LengthofLine1 < LengthofLine2)
                {
                    Console.WriteLine("Line1 is less than Line2");
                Console.ReadLine();
            }
                else
                {
                    Console.WriteLine("Two Lines are Equal");
                Console.ReadLine();
            }
            
        }
    }
}

        
        
    
