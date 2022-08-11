using System;

namespace MyProgram
{
    class Program
    {   

        static void GetDecryption(string strToDecryp) {
            char leter = 'a';
            for (int i = 0; i < strToDecryp.Length; i++) {
                leter = Convert.ToChar(strToDecryp[i]/3);
                Console.Write(leter);
            }
            Console.WriteLine();
        }

        static void textToDecrypt() {
            GetDecryption("êōōĦÉōĬįŖuř``ೃಐ಴ೡಟ`ಱ೉ೕ೘ನಟc");
            GetDecryption("౩`ಜ೭ಜನ`శಐೃನ`ೃಱ಺಴ಐಱೃ೭`ಮಐಱ೤ಮ೉ಱ೭ೆ಺ೀc");
            GetDecryption("ౝೀಟಜ೉ಽೀಟಜನೆಟ`ಟಙ಺`ಽ಺ಮಐ`಺ಷ`ಷಟ`೉೘ಟಱ`ಷಐ`ೃಮಱಐಜc");
            GetDecryption("ౚೆಖಟೆ`ಷಐ`ೃಟಮೀಟೆಷೡಫ`ಖ಺ಽೀ಺ೃ®`ౣ಺ಮೀಐ೛ಟಷಷಐ೭`ಥಐಽನೃ೤`಴ಟೆ಺ಜ಺ಖ");
            GetDecryption("఼ಱ೭`ಽ಺ಱ೉ೕಟಷನ೭`ಓಐಱಱ಺ಖ`೉ಜಐಱನೆಟ`ೆಟಱ಺`಴ಟೆ಺ಜಐ`ನ`಺ೆಽೀಐಖ೤ೆಟ");
        }

        static void SayHello() => Console.WriteLine("Hello!"); // если у метода только одна инструкция

        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            textToDecrypt();
            SayHello();

        }
    }
}