using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using offsets;
using Memory;
using System.Runtime.InteropServices;
using System.Threading;

namespace Cheats
{
    class bhop
    {
        [DllImport("user32.dll")]
        private static extern bool GetAsyncKeyState(int key);

        //bhop function
        public static void BhopFunc(Mem MEMO)
        {
            if (GetAsyncKeyState(config.config.VK_SPACE) && config.config.bhop) 
            {
                MEMO.WriteMemory(offsets.client.dw_forcejump, "int", "5");
                MEMO.WriteMemory(offsets.client.dw_forcejump, "int", "4");
            }
        }
    }
    class bhophelpers
    {
        public static void airaccelerate(Mem MEMO)
        {
            if (config.config.airaccelerate)
            {
                MEMO.WriteMemory(offsets.cvars.sv_airaccelerate, "int", config.config.airaccelerateamount);
            }
        }
        public static void accelerate(Mem MEMO)
        {
            if (config.config.accelerate)
            {
                MEMO.WriteMemory(offsets.cvars.sv_accelerate, "int", config.config.accelerateamount);
            }
        }
    }
}
