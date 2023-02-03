using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using config;
using Memory;

namespace Cheats
{
    
    class fovchanger
    {
        [DllImport("user32.dll")]
        private static extern bool GetAsyncKeyState(int key);
        public static void fovchange(Mem MEMO)
        {
            if(config.config.fov)
            {
                MEMO.WriteMemory(offsets.cvars.cs_debug_fov, "int", config.config.fovamount);
            }
            
        }
    }
}
