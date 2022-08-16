using System;
using System.Collections.Generic;

namespace MyProgram
{
    class Program
    {
        // 1 task
        // move point to the next word
        // abstract: 3 words, move point from 
        // 1 --> 2
        // 2 --> 1
        //-----------------------------------------
        // get line
        static string GetLine()
        {
            string? line = Console.ReadLine();
            if (string.IsNullOrEmpty(line))
                line = "Казнить, нельзя помиловать!";
            return line;
        }
        // split string to array
        
        //-----------------------------------------
        static void GetIndex ( string line, out int indexPoint, out List<int>indexSpaces)
        {
            indexPoint = line.IndexOf(',');
            int curentIndex = indexPoint;
            indexSpaces = new List<int>();
            while (curentIndex < line.Length)
            {
                indexSpaces.Add(line.IndexOf(' ', curentIndex));
                curentIndex++;
            }
        }
        // сам перенос
        static string MovePoint (string line)
        {
            GetIndex(line, out int indexPoint, out List<int> indexSpaces);
            var lineList = line.ToCharArray();
            int moveToPoint = FindClearSpace(indexPoint,indexSpaces);
            Console.WriteLine($"move to = {moveToPoint}; from = {indexPoint}");
            int rangeMoving = (moveToPoint > indexPoint) ? moveToPoint : indexPoint;
            string outLine = "";
            for (int i = 0; i < rangeMoving; i++)
            {
                if (i != indexPoint)
                    outLine += lineList[i];
            }
            outLine += lineList[indexPoint];
            for (int i = rangeMoving; i < lineList.Length; i++)
            {
                if (i != indexPoint)
                    outLine += lineList[i];
            }
            Console.WriteLine(outLine);
            return outLine;
        }
        // поиск куда перенести
        static int FindClearSpace(int indexPoint, List<int>indexSpaces)
        {
            foreach (int indexSpace in indexSpaces)
            {
                if (indexSpace != indexPoint + 1)
                    return indexSpace;
            }
            return indexPoint+1;
        }
        //-----------------------------------------
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            string line = GetLine();
            MovePoint(line);
        }
    }
}