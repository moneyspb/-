using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTaxi.Core
{
    public class Order
    {
        public int Id { get; set; }

        public virtual Client Client { get; set; }

        public virtual Taxist Taxist { get; set; }

        public DateTime Date { get; set; }

        public string FromPlace { get; set; }

        public string ToPlace { get; set; }

        public decimal Cost { get; set; }

        public StatusOrder Status { get; set; }
    }
}
