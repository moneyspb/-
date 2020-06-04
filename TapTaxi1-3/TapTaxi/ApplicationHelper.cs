using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapTaxi.Core;

namespace TapTaxi
{
    public static class ApplicationHelper
    {
        public static Role CurrentRole { get; set; }

        public static Manager CurrentManager { get; set; }
    }
}
