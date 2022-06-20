
using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;
using Cosmos.HAL;
using System.Threading;
using Cosmos.Common;
using System.IO;
using Cosmos.System.FileSystem.VFS;
using Cosmos.System.FileSystem;
using System.Linq;
using System.Runtime.InteropServices;
using Realize.System.Settings;
using Realize.System;
using Realize.System.Commands;

namespace Realize
{
    public class Kernel : Sys.Kernel
    {
        #region Global variables
        public static bool running;
        #endregion

        private CosmosVFS vfs;
        protected override void BeforeRun()
        {
            Console.Clear();
            Console.WriteLine("Please wait as Realize OS Boots...");
            Cosmos.HAL.Global.PIT.Wait(1000);
        }

        protected override void Run()
        {
            Console.Clear();
            Console.WriteLine("██████╗░███████╗░█████╗░██╗░░░░░██╗███████╗███████╗ ");
            Console.WriteLine("██╔══██╗██╔════╝██╔══██╗██║░░░░░██║╚════██║██╔════╝  ");
            Console.WriteLine("██████╔╝█████╗░░███████║██║░░░░░██║░░███╔═╝█████╗░░  ");
            Console.WriteLine("██╔══██╗██╔══╝░░██╔══██║██║░░░░░██║██╔══╝░░██╔══╝░░");
            Console.WriteLine("██║░░██║███████╗██║░░██║███████╗██║███████╗███████╗    Welcome to Realize OS");
            Console.WriteLine("╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚══════╝╚═╝╚══════╝╚══════╝     Created by Ty_1991");
            Console.WriteLine("Please Login");
            Console.Write("username: "); string user = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("██████╗░███████╗░█████╗░██╗░░░░░██╗███████╗███████╗ ");
            Console.WriteLine("██╔══██╗██╔════╝██╔══██╗██║░░░░░██║╚════██║██╔════╝  ");
            Console.WriteLine("██████╔╝█████╗░░███████║██║░░░░░██║░░███╔═╝█████╗░░  ");
            Console.WriteLine("██╔══██╗██╔══╝░░██╔══██║██║░░░░░██║██╔══╝░░██╔══╝░░");
            Console.WriteLine("██║░░██║███████╗██║░░██║███████╗██║███████╗███████╗    Welcome to Realize OS");
            Console.WriteLine("╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚══════╝╚═╝╚══════╝╚══════╝     Created by Ty_1991");
            Console.WriteLine("Please Login");
            Console.Write("password: "); Console.ReadLine();
            Console.Clear();
            NexUI(user);

        }
        public static void NexUI(string user)
        {
            Console.WriteLine("██████╗░███████╗░█████╗░██╗░░░░░██╗███████╗███████╗ ");
            Console.WriteLine("██╔══██╗██╔════╝██╔══██╗██║░░░░░██║╚════██║██╔════╝  ");
            Console.WriteLine("██████╔╝█████╗░░███████║██║░░░░░██║░░███╔═╝█████╗░░  ");
            Console.WriteLine("██╔══██╗██╔══╝░░██╔══██║██║░░░░░██║██╔══╝░░██╔══╝░░");
            Console.WriteLine("██║░░██║███████╗██║░░██║███████╗██║███████╗███████╗    Welcome to Realize OS");
            Console.WriteLine("╚═╝░░╚═╝╚══════╝╚═╝░░╚═╝╚══════╝╚═╝╚══════╝╚══════╝     Created by Ty_1991");
            Console.WriteLine("");
            Console.WriteLine("Welcome to Realize OS Version 1.0.0 (C#/Cosmos, XSharp, Common, IL2CPU)");
            Console.WriteLine("");
            Console.WriteLine(" * Documentation: https://github.com/Array0x/Realize");
            Console.WriteLine(" * Managers: Ty_1991");
            Console.WriteLine(" * Support: {None ATM}");
            Console.WriteLine("");
            Console.WriteLine("Please make sure to Like (♡) the Github");
            Markup.Type(user);
        }
        public static void CommandHandler(string input, string user)
        {
            if(input.ToUpper() == "TEST")
            {
                Console.WriteLine("I am Alive");
                Thread.Sleep(1000);
            }
            else if(input.ToUpper() == "PCINFO")
            {
                PcInfo.PCInfo(user);
            }
            else if(input.ToUpper() == "CLEAR")
            {
                Console.Clear();
                Markup.Type(user);
            }
            else if(input.ToUpper() == "SHUTDOWN")
            {
                CommandShutdown.Shutdown();
            }
            else
            {
                Console.WriteLine("'" + input + "'" + " Is not a valid command. Use 'Help' for all Command Options");
                Cosmos.HAL.Global.PIT.Wait(1000);
                Markup.Type(user);
            }
        }
    }
}
