using System;

namespace MyProgram
{
    class Program
    {
        /*
        * value type - int, bool, char...
        * примитивы - это значащий тип данных
        * в переменной хранится само значение
        * reference type - string, int[], string[]
        * array - это ссылочный тип данных
        * в переменной содержится не сам массив, а ссылка на область
        * памяти, в которой содержится массив (строка)
        */

        // using 'ref' in methods
        //-----------------------------------------------
        static void ExplanationRef() {
            int num = 5;
            Console.WriteLine("num after init = " + num);
            ChangeValueRef(ref num);
            Console.WriteLine("num in exp = " + num);
            Console.WriteLine("Any key to continue");
            Console.ReadKey();
            Console.Clear();
        }

        static void ChangeValueRef (ref int a) { // ref передаёт ссылку на переменную(примитив)
        // ref позволяет в методе изменять переменную из другого метода
        // в данном случае a === num, в том числе и в области памяти
            a = 10;
            Console.WriteLine("a == 'ref num'");
            Console.WriteLine("a = " + a);
        }
        //-----------------------------------------------

        // reference type array example
        //-----------------------------------------------
        static void ExplanationArr(){
            int[] foo = {1, 2, 3, 4, 5};
            Console.WriteLine();
            Console.WriteLine("foo array from initialization:");
            foreach (int el in foo) {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            int[] bar = foo; // в переменную bar передаётся ссылка
            // на ту же область памяти, что и в переменной foo
            bar[0] = 13; // изменение в бар меняет так же и foo
            Console.WriteLine("bar array:");
            foreach (int el in bar){
                Console.Write(el+ " ");
            }
            Console.WriteLine();
            Console.WriteLine("foo array:");
            foreach (int el in foo) {
                Console.Write(el + " ");
            }
            Console.WriteLine();
            Console.WriteLine("Any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
        //----------------------------------------------

        //----------------------------------------------
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            ExplanationRef();
            ExplanationArr();

        }
    }
}