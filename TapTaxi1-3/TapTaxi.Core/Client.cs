using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTaxi.Core
{
    [Table("Client")]
    public class Client : Person
    {
        public Client()
        {
            Reputation = 5;
        }

        public double Reputation { get; set; } //репутация от 0 до 5

        public override string ToString()
        {
            return FIO + " " + Phone;
        }
    }
}
