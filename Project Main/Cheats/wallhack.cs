using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Memory;
using config;
namespace Cheats
{
    class wallhack
    {
        [DllImport("user32.dll")]
        private static extern bool GetAsyncKeyState(int key);
        
        public static void wallhackfunc(Mem MEMO)
        {
            
            if (GetAsyncKeyState(config.config.wallhackkey) && config.config.wallhack)
            {
                MEMO.WriteMemory(offsets.cvars.r_drawothermodels, "int", "2");
            }
            else
            {
                MEMO.WriteMemory(offsets.cvars.r_drawothermodels, "int", "1");
            }
        }
    }
}
