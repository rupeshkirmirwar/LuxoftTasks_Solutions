using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuxoftTask2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Dead Pixel Groups Calculation utility!");
            Console.ReadLine();

            Console.WriteLine("Please enter monitor hight: ");
            int hight = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter monitor width: ");
            int width = Convert.ToInt32(Console.ReadLine());

            char[][] monitor = new char[hight][];

            for (int i=0;i<hight;i++)
            {
                monitor[i] = new char[width];
                for (int j=0;j<width;j++)
                {
                    Console.WriteLine("Please enter pixel value at [{0}][{1}]:",i,j);
                    monitor[i][j] = Convert.ToChar(Console.ReadLine());
                }
            }

            Console.WriteLine("The monitor your entered, looks like: ");
            for(int i=0; i<hight; i++)
            {
                for (int j=0;j<width; j++ )
                {
                    Console.Write("{0} ", monitor[i][j]);
                }
                Console.WriteLine();
            }

            DeadPixels obj = new DeadPixels();
            int deadPixelGroups = obj.CountGroups(monitor);

            Console.WriteLine("No of Dead Pixel Groups:{0}", deadPixelGroups);
            Console.ReadLine();
        }
    }
}
