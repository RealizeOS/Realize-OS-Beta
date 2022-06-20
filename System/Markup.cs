using System;
using System.Collections.Generic;
using System.Text;
using Realize;

namespace Realize.System
{
    class Markup
    {
        public static void Type(string user)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("$");
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write(user + "@");
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("slushy-test");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("> "); var input = Console.ReadLine();
            Kernel.CommandHandler(input, user);
        }
    }
}
