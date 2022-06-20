using System;
using System.Collections.Generic;
using System.Text;
using Sys = Cosmos.System;

namespace Realize.System.Settings
{
    class CommandShutdown
    {
        public static void Shutdown()
        {
            Kernel.running = false;
            Console.Clear();
            Console.WriteLine("Shutting Down...");
            Cosmos.HAL.Global.PIT.Wait(50000);
            Sys.Power.Shutdown();
        }
    }
}
