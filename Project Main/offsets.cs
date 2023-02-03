using System;

namespace offsets
{
    public static class client
    {
        // offsets
        public const string dw_forcejump = "client.dll+A4F8F8";
        
    }
    public static class server
    {
        public const string PlayersHealth = "server.dll+00839774,214";
    }
    public class flags
    {
        public const string FL_ONGROUND = "client.dll+A563EC";
    }
    public static class cvars
    {
        public const string r_drawothermodels = "client.dll+9F4AD8";
        public const string c4timer = "server.dll+83CEF0";
        public const string cs_debug_fov = "client.dll+A63FD0";
        public const string sv_airaccelerate = "client.dll+A54A10";
        public const string sv_accelerate = "client.dll+A54960";

    }
    
}
