using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.IO;
using Tyuiu.ZaitsevMS.Sprint7.Project.V10.Lib;

namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestSaveAndLoadClients()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            var clients = new List<Client>
            {
                new Client { AccountNumber = "ACC001", LastName = "Иванов",
                    FirstName = "Иван", MiddleName = "Иванович",
                    Address = "ул. Ленина 1", Phone = "89001234567" }
            };

            ds.SaveClients(path, clients);
            var loaded = ds.LoadClients(path);

            Assert.AreEqual(1, loaded.Count);
            Assert.AreEqual("ACC001", loaded[0].AccountNumber);
            Assert.AreEqual("Иванов", loaded[0].LastName);
            File.Delete(path);
        }

        [TestMethod]
        public void TestSaveAndLoadOrders()
        {
            DataService ds = new DataService();

            string path = Path.GetTempFileName();
            var orders = new List<Order>
            {
                new Order { OrderNumber = "ORD001", AccountNumber = "ACC001",
                    OrderDate = new DateTime(2024, 5, 1),
                    ProductName = "Ноутбук", Price = 50000m, Quantity = 2 }
            };

            ds.SaveOrders(path, orders);
            var loaded = ds.LoadOrders(path);

            Assert.AreEqual(1, loaded.Count);
            Assert.AreEqual("ORD001", loaded[0].OrderNumber);
            Assert.AreEqual(100000m, loaded[0].TotalCost);
            File.Delete(path);
        }

        [TestMethod]
        public void TestSearchOrders_FindsByProductName()
        {
            DataService ds = new DataService();

            var orders = new List<Order>
            {
                new Order { OrderNumber = "ORD001", AccountNumber = "ACC001",
                    ProductName = "Ноутбук", Price = 50000m, Quantity = 1,
                    OrderDate = DateTime.Today },
                new Order { OrderNumber = "ORD002", AccountNumber = "ACC002",
                    ProductName = "Телефон", Price = 20000m, Quantity = 1,
                    OrderDate = DateTime.Today }
            };

            var result = ds.SearchOrders(orders, "ноутбук");
            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("ORD001", result[0].OrderNumber);
        }

        [TestMethod]
        public void TestStatistics()
        {
            DataService ds = new DataService();

            var orders = new List<Order>
            {
                new Order { Price = 100m, Quantity = 2, OrderDate = DateTime.Today,
                    OrderNumber = "O1", AccountNumber = "A1", ProductName = "X" },
                new Order { Price = 300m, Quantity = 1, OrderDate = DateTime.Today,
                    OrderNumber = "O2", AccountNumber = "A2", ProductName = "Y" },
                new Order { Price = 50m,  Quantity = 2, OrderDate = DateTime.Today,
                    OrderNumber = "O3", AccountNumber = "A1", ProductName = "Z" }
            };

            // TotalCost: 200, 300, 100 → сумма=600, среднее=200, min=100, max=300
            Assert.AreEqual(3, ds.GetCount(orders));
            Assert.AreEqual(600m, ds.GetSum(orders));
            Assert.AreEqual(200m, ds.GetAverage(orders));
            Assert.AreEqual(100m, ds.GetMin(orders));
            Assert.AreEqual(300m, ds.GetMax(orders));
        }

        [TestMethod]
        public void TestFilterByDateRange()
        {
            DataService ds = new DataService();

            var orders = new List<Order>
            {
                new Order { OrderNumber = "O1", AccountNumber = "A1", ProductName = "X",
                    Price = 100m, Quantity = 1, OrderDate = new DateTime(2024, 1, 10) },
                new Order { OrderNumber = "O2", AccountNumber = "A1", ProductName = "Y",
                    Price = 100m, Quantity = 1, OrderDate = new DateTime(2024, 6, 15) }
            };

            var result = ds.FilterByDateRange(orders,
                new DateTime(2024, 1, 1), new DateTime(2024, 3, 1));

            Assert.AreEqual(1, result.Count);
            Assert.AreEqual("O1", result[0].OrderNumber);
        }
    }
}