using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            var A = new Matrix();
            A.Read();

            var B = new Matrix();
            B.Read();

            A.Sum(B);
            A.Write();

        }
    }

    class Matrix
    {
        public void Read()
        {
            var numbers = InputString();
            this.rows = (numbers[0] > 0) ? numbers[0] : 2;
            this.columns = (numbers[1] > 0) ? numbers[1] : 3;
            this.data = new double[rows, columns];
            for (int i = 0; i < this.rows; i++)
            {
                numbers = InputString();
                foreach (int number in numbers)
                    for (int j = 0; j < columns; j++)
                    {
                        this.data[i, j] = numbers[j];
                    }
            }
        }
        public void Sum(Matrix B)
        {
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    data[i,j] += B.data[i,j];
                }
            }
        }
        public void Write()
        {
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns - 1; j++)
                {
                    Console.Write(this.data[i, j] + " ");
                }
                Console.Write(data[i, this.columns - 1]);
                Console.WriteLine();
            }
        }
        public List<int> InputString()
        {
            string? inputLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inputLine))
                inputLine = "1 2";
            var numbers = new List<int>();
            numbers = inputLine.Split(' ').Select(int.Parse).ToList();
            return numbers;
        }
        public int rows;
        public int columns;
        public double[,] data;
    }
}