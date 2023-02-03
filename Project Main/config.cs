using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace config
{

    class config
    {
        // virtual-keys
        // read more: https://learn.microsoft.com/en-us/windows/win32/inputdev/virtual-key-codes
        public const int VK_INSERT = 0x2D;
        public const int VK_LMENU = 0xA4;
        public const int VK_SPACE = 0x20;

        // Visuals
        public const bool wallhack = true;

        // misc
        public const bool bhop = true;

        public const bool airaccelerate = true;
        public const string airaccelerateamount = "250"; // only works if(airaccelerate == true)

        public const bool accelerate = true;
        public const string accelerateamount = "250"; // only works if(accelerate == true)

        // Trolling Functions
        public const bool HealthTroll = true;

        public const bool c4timerchanger = true;
        public const string c4timer = "40"; // only works if(HealthTroll == true)

        // functions that require sv_cheats :(
        public const bool fov = true;
        public const string fovamount = "90";

        // Keybinds
        public const int wallhackkey = VK_LMENU;
        public const string wallhackkeyname = "LEFT ALT";
        public const int HealthTrollKey = VK_INSERT;
        public const string HealthTrollKeyName = "INSERT";


    }

}
