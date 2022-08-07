using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            string? inpt_height = Console.ReadLine();
            if (inpt_height == null) {
                inpt_height = "10";
            }
            int height = int.Parse(inpt_height);

            //Пространство для вашего творчества
            int middle = height;
            int counter_height = 0; // current height
            int counter_width; // current pos in line
            
            //loop for height, where i == counter_height?
            for (int i = 0; i < height; i++) {
                counter_height = i;
                counter_width = 0;
                while (counter_width <= (middle + counter_height - 1)) {
                    if (counter_width < (middle - counter_height - 1)) {
                        Console.Write(" ");
                    }
                    else if ((counter_width >= (middle - counter_height - 1)) && (counter_width <= (middle + counter_height -1))) {
                        Console.Write("*");
                    }
                    else {
                        break;
                    }
                    counter_width++;
                }
                Console.WriteLine();
            }
        }
    }
}