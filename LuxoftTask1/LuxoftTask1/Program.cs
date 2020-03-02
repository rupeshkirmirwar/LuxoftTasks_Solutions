using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuxoftTask1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to MaxSum calculation utility! Press Enter to continue..");
            Console.ReadLine();
            Console.WriteLine("Please enter length of the Array:");
            int l = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[l]; 
            for (int i=0; i<l;i++)
            {
                Console.WriteLine("Enter the number at position {0} in the array:", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("Array to calculate MaxSum is:");
            for(int i=0;i<l; i++)
            {
                Console.Write("{0} ",arr[i]);
            }
            Console.WriteLine();
            Console.ReadLine();
            MaxSum obj = new MaxSum();
            int maxSum = obj.FindSum(arr);

            Console.WriteLine("Maximum sum of subset of non adjacent elements in the array is : {0}", maxSum);
            Console.ReadLine();

        }
    }
}
