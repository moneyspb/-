using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTaxi.Core
{
    [Table("Taxist")]
    public class Taxist : Person
    {
        public Taxist()
        {
            Reputation = 5;
        }

        public string NumberCar { get; set; }
        public virtual ModelCar Model { get; set; }
        public string Color { get; set; }
        public bool IsBusy { get; set; }
        public double Reputation { get; set; } //репутация от 0 до 5

        public override string ToString()
        {
            return FIO + "  Тел:" + Phone;
        }
    }
}
