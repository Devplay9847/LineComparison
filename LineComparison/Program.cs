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
			double x1, y1, x2, y2;
			Console.WriteLine("Input line one x1: ");
			x1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Input line one y1: ");
			y1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Input line one x2: ");
			x2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Input line one x2: ");
			y2 = Convert.ToDouble(Console.ReadLine());
			double LengthofLine = 0;
			LengthofLine = Math.Sqrt((x2 - x1) * 2 + (y2 - y1) * 2);
			Console.WriteLine("Lenght of line =" + LengthofLine);
			Console.ReadLine();
		}
	}
}
