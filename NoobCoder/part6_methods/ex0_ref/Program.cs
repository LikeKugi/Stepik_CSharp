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
            ExplainChangeValueRef(ref num);
            Console.WriteLine("num in exp = " + num);
            ClearingAfter();
        }

        static void ExplainChangeValueRef (ref int a) { // ref передаёт ссылку на переменную(примитив)
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
            ClearingAfter();
        }
        //----------------------------------------------

        //----------------------------------------------
        // CHANGING ARRAY IN METHODS
        //----------------------------------------------

        // change directly in method
        //----------------------------------------------
        static void ChangingArrayDirectly()
        {   
            Console.WriteLine("changing array in method directly");
            int[] foo = {27,-15,2,22,12,-55,11};
            Console.WriteLine("original array is:");
            foreach(int i in foo)
                Console.Write(i + " ");
            Console.WriteLine();
            bar(foo);
            Console.WriteLine("changed array is:");
            foreach(int i in foo)
                Console.Write(i + " ");
            ClearingAfter();
        }
        static void bar(int[] baz)
        {
            baz[0] = 666; // передается ссылка на массив.
            // любое действие в методе изменяет область памяти с исходным массивом
        }
        //----------------------------------------------

        // changing array with return
        //----------------------------------------------
        static void ChangingArrReturn()
        {
            Console.WriteLine("changing array with return");
            int[] foo = {1, 2, 3, 4};
            foreach(int i in foo)
                Console.Write(i + " ");
            Console.WriteLine();
            foo = bar(foo, 42); // в переменную записывается ссылка на новую область памяти
            foreach(int i in foo)
                Console.Write(i + " ");
            ClearingAfter();
        }
        static int[] bar(int[] baz, int newElem)
        {
            // новый массив и новая область памяти
            int newLength = baz.Length + 1;
            int [] quux = new int [newLength];
            for(int i = 0; i < baz.Length; i++)
                quux[i] = baz[i];
            quux[newLength - 1] = newElem;
            return quux; // возвращается ссылка на новую область памяти с новым массивом
        }
        //----------------------------------------------

        // changing array using 'ref'
        //----------------------------------------------
        static void ChangingArrayRef()
        {
            Console.WriteLine("changing array with 'ref' in method");
            int[] foo = {1, 2, 3, 4};
            foreach(int i in foo)
                Console.Write(i + " ");
            Console.WriteLine();
            barRef(ref foo, 42); // в функцию передаётся ссылка на переменную
            foreach(int i in foo)
                Console.Write(i + " ");
            ClearingAfter();
        }
        static void barRef(ref int[] baz, int newElem)
        {   
            // создаётся новый массив в новой области памяти
            int newLength = baz.Length + 1;
            int [] quux = new int [newLength];
            for(int i = 0; i < baz.Length; i++)
                quux[i] = baz[i];
            quux[newLength - 1] = newElem;
            baz = quux; // в переменной, на которую передали ссылку 
            // обновляется ссылка на новую область памяти с новым массивом
            // благодаря 'ref' в исходной переменной будет ссылка
            // на массив, объявленный в этом методе
        }
        //----------------------------------------------

        // changing array in method with 'out'
        //----------------------------------------------
        static void ChangingArrayOut()
        {   
            Console.WriteLine("changing array with 'out'");
            int[] foo = {1, 2, 3, 4};
            foreach(int i in foo)
                Console.Write(i + " ");
            Console.WriteLine();
            barOut(foo, out int[] qwe, 42); // директива out
            // значит, что из метода вернётся эта переменная
            // с тем значением, которое получилось в методе
            foreach(int i in qwe) // исходный массив не изменился
            // переменная с исходным массивом не менялась
            // теперь можно работать с новой переменной и новым массивом
            // которые получились благодаря 'out'
                Console.Write(i + " ");
            ClearingAfter();
        }
        static void barOut(int[] baz, out int[] quux, int newElem)
        {
            // директива 'out' объявляет переменную
            // теперь с ней можно работать в основном потоке
            // но значение у переменной необходимо задать
            int newLength = baz.Length + 1;
            quux = new int [newLength];
            for(int i = 0; i < baz.Length; i++)
                quux[i] = baz[i];
            quux[newLength - 1] = newElem;
        }
        //----------------------------------------------

        //----------------------------------------------
        // SOME TRICKS WITH 'OUT'
        //----------------------------------------------

        // example 'out'
        //----------------------------------------------
        static void UsingOut()
        {
            Console.WriteLine("Использование OUT");
            Console.WriteLine("product & sum from 'out' in method calling");
            int x = 5, y = 6;
            GetResult(x, y, out int sum, out int product);
            Console.WriteLine("sum = {0}", sum);
            Console.WriteLine("product = {0}", product);
            ClearingAfter();
        }
        static void GetResult(int a, int b, out int sum, out int product)
        // используя out можно возвращать несколько значений
        {
            sum = a + b;
            product = a * b;
        }
        //----------------------------------------------
        //----------------------------------------------
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();
            ExplanationRef();
            ExplanationArr();
            ChangingArrayDirectly();
            ChangingArrReturn();
            // ref и out должны быть объявлены как в вызове метода
            // так и в самом методе, который вызывается
            ChangingArrayRef();
            ChangingArrayOut();
            UsingOut();

        }

        static void ClearingAfter()
        // clear console after method
        {
            Console.WriteLine();
            Console.WriteLine("Any key to continue");
            Console.ReadKey();
            Console.Clear();
        }
    }
}