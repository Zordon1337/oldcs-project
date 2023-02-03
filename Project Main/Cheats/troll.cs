using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Memory;
namespace Cheats
{
    
    // troll functions
    class trolling
    {
        [DllImport("user32.dll")]
        private static extern bool GetAsyncKeyState(int key);
        

        public static void changehpeveryone(Mem MEMO)
        {
            // this function changes every player health to 2000
            // im not sure but this probably only works on your server
            if (GetAsyncKeyState(config.config.VK_INSERT) && config.config.HealthTroll)
            {
                MEMO.WriteMemory(offsets.server.PlayersHealth, "int", "2000"); 
            }
        }
        public static void changec4timer(Mem MEMO)
        {
            // this function changes every player health to 2000
            // im not sure but this probably only works on your server
            if (config.config.c4timerchanger)
            {
                MEMO.WriteMemory(offsets.cvars.c4timer, "int", config.config.c4timer);
            }
        }

    }
}
