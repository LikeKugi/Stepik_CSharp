using System;

namespace MyProgram
{
    class Program
    {
        static void Main(string[] args)
        {
        // Main starts here
            Console.Clear();

            RobotGenerator.Generate("kree", 5, 4, 3);

        }
    }
    class RobotGenerator
{
    // запчасти роботов, разделенные символом "\n".
    // каждая строка - отдельный робот
    private static string[] bots =
    {
        "     ___T_     \n    | o o |    \n    |__-__|    \n    /| []|\\    \n  ()/|___|\\()  \n     |_|_|     \n     /_|_\\     ",
        "    \\.===./    \n    | b d |    \n     \\_=_/     \n  o==|ooo|==o  \n     |___|     \n    .'._.'.    \n    |_| |_|    ",
        "     o___o     \n    //0-0\\\\    \n    |\\_-_/|    \n    /|(\\)|\\    \n   d |___| b   \n    . \\_/  .   \n   . .:::.. .  ",
        "     T___      \n     |[o]|     \n     \\_-_/     \n  7--|=0=|--<  \n     |___|     \n     // \\\\     \n    _\\\\ //_    ",
        "      )_(      \n     |ooo|     \n     |_#_|     \n .-._/___\\_.-. \n ;   \\___/   ; \n     (   )     \n    __) (__    ",
        "     |---|     \n     |6=6|     \n     |_o_|     \n}-. /\\--o/\\ .-{\n   \" |___| \"   \n      .\".      \n      |_|      ",
        "     .---.     \n    } - - {    \n     \\_0_/     \n   .=[::+]=.   \n ]=' [___] '=[ \n     /| |\\     \n    [_] [_]    ",
        "      Y__      \n    _/o o\\_    \n     \\_o_/     \n )=o=|L88|=o=( \n )=o=|___|=o=( \n  .  /___\\  .  \n. ..:::::::.  .",
        "     .===.     \n    //d d\\\\    \n    \\\\_u_//    \n    ,=|x|=.    \n    'c/_\\  'c  \n     /| |\\     \n    (0) (0)    ",
        "     _._._     \n    -)o o(-    \n     \\_=_/     \n()ooo|\\=/|ooo()\n     |___|     \n      |_|      \n     (ooo)     ",
        "    .=._,=.    \n   ' (q q) `   \n     _)-(_     \n.'c .\"|_|\". n`.\n'--'  /_\\  `--'\n    _// \\\\_    \n   /_o| |o_\\   ",
        "      .-.      \n   ._(u u)_.   \n     (_-_)     \n   .=(+++)=.   \no=\"  (___)  \"=o\n     (_|_)     \n     (o|o)     ",
        "     ,_,_,     \n     \\9 9/     \n     /_-_\\     \n   ,\"|+  |\".   \n   _\\|+__|/_   \n     /  |      \n    _\\  |_     ",
        "     .===./`   \n    /.n n.\\    \n    \"\\_=_/\"    \n  (m9\\:::/\\    \n     /___\\6    \n     [] []     \n    /:] [:\\    ",
        "      __i      \n     [p q]     \n      ]-[      \n >===]__o[===< \n     [o__]     \n     ]| |[     \n    [_| |_]    ",
        "   _ _,_,_ _   \n   \\( q p )/   \n     \\_\"_/     \n  .==|>o<|==:=L\n  '=c|___|     \n     /7 [|     \n   \\/7  [|_    "
    };


    public static void Generate(string name, int headId, int bodyId, int legsId)
    {
        string head = GetBodyPart(bots[headId], 0, 3);
        string body = GetBodyPart(bots[bodyId], 3, 5);
        string legs = GetBodyPart(bots[legsId], 5, 7);

        Console.WriteLine("Робот: " + name);
        Console.WriteLine(head + body + legs);
    }

    private static string GetBodyPart(string bot, int from, int to)
    {
        string[] layers = bot.Split('\n');
        string bodyPart = "";
        for (int i = from; i < to; i++)
        {
            bodyPart += layers[i] + "\n";
        }

        return bodyPart;
    }
}
}