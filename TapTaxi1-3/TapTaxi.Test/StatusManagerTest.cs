using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TapTaxi.Core;
using TapTaxi.Entities;

namespace TapTaxi.Test
{
    [TestClass]
    public class StatusManagerTest
    {
        private Order order;
        private Client client;
        private Taxist taxist;

        [TestInitialize]
        public void Setup()
        {
            client = new Client();
            taxist = new Taxist();
            order = new Order();
            order.Status = StatusOrder.New;
            order.Taxist = taxist;
            order.Client = client;
        }

        [TestMethod]
        public void TestChangeStatusFailed()
        {
            double expected = 4.5;
            
            StatusManager.ChangeStatus(order, StatusOrder.Failed);

            Assert.AreEqual(expected, client.Reputation);
            Assert.IsFalse(taxist.IsBusy);
        }

        [TestMethod]
        public void TestChangeStatusCompleted()
        {
            double expected = 5;

            StatusManager.ChangeStatus(order, StatusOrder.Completed);

            Assert.AreEqual(expected, client.Reputation);
            Assert.IsFalse(taxist.IsBusy);
        }
    }
}
