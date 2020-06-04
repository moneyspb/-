using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TapTaxi.Core
{
    public enum StatusOrder
    {
        New,
        Assigned,
        Accepted, //пассажира забрали
        Completed, //поездка завершена
        Canceled, //поездка отменена
        Failed //клиент пропал
    }
}
