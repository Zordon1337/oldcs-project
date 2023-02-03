using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Memory;
using System.Runtime.InteropServices;
using offsets;
using Cheats;

namespace oldcs {
    
    class Program
    {
        
        public static void Print(string text)
        {
            Console.WriteLine(text);
        }
        public static String Read()
        {
            string input = Console.ReadLine();
            return input;
        }
        
        public void RenderMenu()
        {
            
            
        }
        static void Main()
        {
            
            Mem MEMO = new Mem();
            MEMO.OpenProcess("csgo.exe");
            Console.Title = "Project oldcs.xyz";
            Print("Loaded!");
            Print("Keybinds: ");
            Print("Wallhack: " + config.config.wallhackkeyname);
            Print("Infinity Health for every player: " + config.config.HealthTrollKeyName);
            while (true)
            {
                
                int dw_forcejump = MEMO.ReadMemory<int>(offsets.client.dw_forcejump);
                int FL_GROUND = MEMO.ReadMemory<int>(offsets.flags.FL_ONGROUND);
                int r_drawothermodels = MEMO.ReadMemory<int>(offsets.cvars.r_drawothermodels);

                // r_drawothermodels 2
                Cheats.wallhack.wallhackfunc(MEMO);
                // this function changes every player health to 2000
                // im not sure but this probably only works on your server
                Cheats.trolling.changehpeveryone(MEMO);
                Cheats.bhop.BhopFunc(MEMO);
                Cheats.bhophelpers.accelerate(MEMO);
                Cheats.bhophelpers.airaccelerate(MEMO);
                Cheats.fovchanger.fovchange(MEMO);

            }
            

        }
    }
}
