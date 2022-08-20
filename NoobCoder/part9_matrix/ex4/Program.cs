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
            Console.WriteLine("enter data for matrix A");
            A.Read();

            var B = new Matrix();
            Console.WriteLine("enter data for matrix B");
            B.Read();

            var C =  A.Multiply(B);
            Console.WriteLine("---------------------------------");
            C.Write();

        }
    }

    class Matrix
    {
        public void Read()
        {
            // TODO: Comment CWN
            Console.WriteLine("input dimensions (rows)_(columns)");
            var numbers = InputString();
            this.rows = (numbers[0] > 0) ? (int)numbers[0] : 2;
            this.columns = (numbers[1] > 0) ? (int)numbers[1] : 3;
            this.data = new double[rows, columns];
            Console.WriteLine("input matrix");
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
        public Matrix Multiply(Matrix B)
        {
            Console.WriteLine("****************************");
            var Res = new Matrix();
            Res.rows = this.rows;
            Res.columns = B.columns;
            Res.data = new double[Res.rows, Res.columns];
            // перебор элементов Res
            double elem;
            for (int i = 0; i < Res.rows; i++) // строки
            {   
                Console.WriteLine("row ==> {0}", i);
                for (int j = 0; j < Res.columns; j++) // столбцы
                {
                    Console.WriteLine("column ==> {0}", j);
                    elem = 0;
                    for (int k = 0; k < B.rows; k++) // собрать элемент
                    {   
                        Console.Write("+  {1} * {2} ",elem, this.data[i,k], B.data[k,j]);
                        elem += this.data[i,k] * B.data[k,j];
                    }
                    Console.WriteLine();
                    Console.WriteLine("elem ==> {0}", elem);
                    Res.data[i,j] = elem;
                }
                Console.WriteLine("next row");
            }
            return Res;
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
        public List<double> InputString()
        {
            string? inputLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inputLine))
                inputLine = "1 2";
            var numbers = new List<double>();
            numbers = inputLine.Split(' ').Select(double.Parse).ToList();
            return numbers;
        }
        public int rows;
        public int columns;
        public double[,] data;
    }
}