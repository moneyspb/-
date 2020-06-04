using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTaxi.Core
{
    public abstract class Person
    {
        public int Id { get; set; }
        public string FIO { get; set; }
        public string Phone { get; set; }
        public string Password { get; set; }
    }
}
