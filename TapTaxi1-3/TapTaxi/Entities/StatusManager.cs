using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TapTaxi.Core;

namespace TapTaxi.Entities
{
    public static class StatusManager
    {
        public static void ChangeStatus(Order order, StatusOrder status)
        {
            order.Status = status;

            if (status == StatusOrder.Failed || status == StatusOrder.Completed || status == StatusOrder.Canceled)
                order.Taxist.IsBusy = false;

            if (status == StatusOrder.Failed)
                order.Client.Reputation -= 0.5;
        }
    }
}
