using System;

namespace Sledilec.Odjemalec.Stroj
{
    public static class Nastavitve
    {
		// local server
        public static Uri Strežnik => new Uri("http://localhost:1798/api/");
		// Docker on Desktop/Windwos
        //public static Uri Strežnik => new Uri("http://dockervm:8080/api/");
		// Docker on Raspberry/Hypriot OS
        //public static Uri Strežnik => new Uri("http://black-pearl:8080/api/");
    }
}
