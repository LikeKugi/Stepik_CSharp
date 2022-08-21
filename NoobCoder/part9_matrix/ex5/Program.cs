using System;
using System.Collections.Generic;
using System.Linq;

namespace MyProgram
{
    class Program
    {
        // (5*A + 2*B)*A
        // да, я овен по знаку зодиака. и это мой ОВНОКод
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            Console.WriteLine(" (5*A + 2*B)*A ");
            Console.WriteLine("----------------------------");
            var A = new Matrix();
            //Console.WriteLine("enter data for matrix A");
            A.Read();

            var B = new Matrix();
            //Console.WriteLine("enter data for matrix B");
            B.Read();

            var C =  A.MultiplyNumber(5);
            C = C.AddMatrix(B.MultiplyNumber(2));
            C = C.MultiplyMatrix(A);
            //Console.WriteLine("---------------------------------");
            C.Write();

        }
    }
    
    class Matrix
    {
    //-------------------------------------------------------------
        // create new matrix
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
    //-------------------------------------------------------------
        // add matrix to another matrix
        public Matrix AddMatrix(Matrix B)
        {   
            var ResAddMatrix = new Matrix();
            ResAddMatrix.rows = this.rows;
            ResAddMatrix.columns = this.columns;
            ResAddMatrix.data = new double[ResAddMatrix.rows, ResAddMatrix.columns];
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    ResAddMatrix.data[i,j] = this.data[i,j] + B.data[i,j];
                }
            }
            return ResAddMatrix;
        }
    //-------------------------------------------------------------
        // multiply matrix by value
        public Matrix MultiplyNumber(double n)
        {
            var ResMultNumb = new Matrix();
            ResMultNumb.rows = this.rows;
            ResMultNumb.columns = this.columns;
            ResMultNumb.data = new double[ResMultNumb.rows, ResMultNumb.columns];
            for (int i = 0; i < this.rows; i++)
            {
                for (int j = 0; j < this.columns; j++)
                {
                    ResMultNumb.data[i,j] = this.data[i,j] * n;
                }
            }
            return ResMultNumb;
        }
    //-------------------------------------------------------------
        // multiply matrix by another matrix
        public Matrix MultiplyMatrix(Matrix B)
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
    //-------------------------------------------------------------
        // output matrix
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
    //-------------------------------------------------------------
        // input line splited to List<double>
        // each number in list ==> to matrix
        // also used to get dimensions of matrix
        public List<double> InputString()
        {
            string? inputLine = Console.ReadLine();
            if (string.IsNullOrEmpty(inputLine))
                inputLine = "1 2";
            var numbers = new List<double>();
            numbers = inputLine.Split(' ').Select(double.Parse).ToList();
            return numbers;
        }
    //-------------------------------------------------------------
        // matrix and its rows/columns
        public int rows;
        public int columns;
        public double[,] data;
    //-------------------------------------------------------------
    }
}