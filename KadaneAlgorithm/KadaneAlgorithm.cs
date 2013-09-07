using System;

namespace KadaneAlgorithm
{
    class KadaneAlgorithm
    {
        static void Main()
        {
            Console.WriteLine("Enter the length of the array");
            int lenght = int.Parse(Console.ReadLine());
            int[] array = new int[lenght];

            Console.WriteLine("Enter the Array indexes:");
            for (int i = 0; i < lenght; i++)
            {
                Console.Write("Array[{0}] ", i);
                array[i] = int.Parse(Console.ReadLine());
            }

            int currentSum = array[0];
            int startIndex = 0;
            int endIndex = 0;
            int tempStartIndex = 0;
            int maxSum = array[0];

            for (int i = 1; i < array.Length; i++)
            {
                if (currentSum < 0)
                {
                    currentSum = array[i];
                    tempStartIndex = i;
                }
                else
                {
                    currentSum += array[i];
                }
                if (currentSum > maxSum)
                {
                    maxSum = currentSum;

                    startIndex = tempStartIndex;
                    endIndex = i;
                }
            }

            Console.WriteLine("The best sum is: {0} ", maxSum);

            Console.WriteLine("The best sequence is:");

            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine(array[i]);
            }
        }
    }
}