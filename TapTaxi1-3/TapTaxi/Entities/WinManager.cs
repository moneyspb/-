using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TapTaxi
{
    public static class WinManager
    {
        [DllImport("TapTaxi.Calc.dll", CallingConvention = CallingConvention.Cdecl)]
        public static extern int cost_trip(int distance, int tarif, int trafficJams);
    }
}
