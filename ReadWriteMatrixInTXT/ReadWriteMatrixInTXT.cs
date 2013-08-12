using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace ReadWriteMatrixInTXT
{
    class ReadWriteMatrixInTXT
    {
        static void Main(string[] args)
        {
            string fileName = @"testFile.txt";
            int[,] testMatrix = new int[10, 10];
            InitialiseMatrix(testMatrix);

            WriteOutInFile(testMatrix, fileName);

            Console.WriteLine("Sample values from array:");
            Console.WriteLine("[5, 5] is {0}", testMatrix[5, 5]);
            Console.WriteLine("[7,2] is {0}", testMatrix[7, 2]);
            Console.WriteLine();
            Console.WriteLine("Now after reading the values from the text file...");
            testMatrix = ReadFromFile(fileName);
            Console.WriteLine("[5, 5] is {0}", testMatrix[5, 5]);
            Console.WriteLine("[7,2] is {0}", testMatrix[7, 2]);
        }
        static int[,] ReadFromFile(string fileName)
        {
            StreamReader reader = new StreamReader(fileName);
            int width;
            int height;

            int.TryParse(reader.ReadLine(), out width);
            int.TryParse(reader.ReadLine(), out height);
            int[,] readValues = new int[width, height];

            for (int i = 0; i < readValues.GetLength(0); i++)
            {
                for (int j = 0; j < readValues.GetLength(1); j++)
                {
                    int.TryParse(reader.ReadLine(), out readValues[i, j]);
                }
            }
            reader.Close();
            return readValues;
        }
        static void WriteOutInFile(int[,] testValues, string fileName)
        {
            StreamWriter writer = new StreamWriter(fileName);
            writer.WriteLine(testValues.GetLength(0));
            writer.WriteLine(testValues.GetLength(1));

            for (int i = 0; i < testValues.GetLength(0); i++)
            {
                for (int j = 0; j < testValues.GetLength(1); j++)
                {
                    writer.WriteLine(testValues[i, j]);
                }
            }
            writer.Close();
        }
        static void InitialiseMatrix(int[,] testValues)
        {
            for (int i = 0; i < testValues.GetLength(0); i++)
            {
                for (int j = 0; j < testValues.GetLength(1); j++)
                {
                    testValues[i, j] = (i + 1) * (j + 1);
                }
            }
        }
    }
}