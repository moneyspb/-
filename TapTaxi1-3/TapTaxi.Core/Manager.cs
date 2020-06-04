using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTaxi.Core
{
    [Table("Manager")]
    public class Manager : Person
    {
        public bool IsAdmin { get; set; }
    }
}
