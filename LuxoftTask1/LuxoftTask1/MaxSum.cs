// Rupesh Kirmirwar
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuxoftTask1
{
    public class MaxSum
    {
        public int FindSum(int[] arr)
        {

            //Implemetation Logic
            //I have used recursive logic to calculate Max Sum of non adjecent elements in an array
            //Max Sum of non adjecent elements in any array will be  higher of, 
            //1) 1st element plus Max Sum of subset of array from 3rd to Last element Or 
            //2) 2nd element plus Max sum of subset of array from 4th to Last element

            //Max sum of array of one element will alway be that element.
            //Max Sum of array of two elements will be higher of the two elements.
            //Max Sum of array of three elements will be higher of (1st +3rd) or 2nd element. 

            //I have traverse the array from last to first element and calculated max sum of subset of array from current element to last element. 
            //And stored the values in separate array to reuse them in recursive logic, to avoid re calculation. 

            int[] maxSum = new int[arr.Length]; 

            //Calculation of Max Sum for last element
            maxSum[arr.Length-1] = arr[arr.Length - 1]; 

            //Calculation of Max Sum for sub array of last 2 elements
            if (arr[arr.Length - 2] > arr[arr.Length - 1]) 
            {
                maxSum[arr.Length - 2] = arr[arr.Length - 2]; 
            }
            else
            {
                maxSum[arr.Length - 2] = arr[arr.Length - 1]; 
            }

            //Calculation of max sum for sub array of last 3 elements
            if (arr[arr.Length - 3] + arr[arr.Length - 1] > arr[arr.Length - 2])
            {
                maxSum[arr.Length - 3] = arr[arr.Length - 3] + arr[arr.Length - 1]; 
            }
            else
            {
                maxSum[arr.Length - 3] = arr[arr.Length - 2];
            }

            //Max Sum of non adjecent elements in any array will be  higher of, 
            //1) 1st element plus Max Sum of subset of array from 3rd to Last element Or 
            //2) 2nd element plus Max sum of subset of array from 4th to Last element
            for (int i = arr.Length - 4; i >= 0; i--) //O(n-4)
            {
                if (arr[i] + maxSum[i + 2] > arr[i + 1] + maxSum[i + 3]) 
                {
                    maxSum[i] = arr[i] + maxSum[i + 2]; 
                }
                else
                {
                    maxSum[i] = arr[i + 1] + maxSum[i + 3];
                }
            }

            //maxSum[0] will have the Max Sum of non adjecent elements for complete array. 
            return maxSum[0]; //O(1)
        }
    }
}