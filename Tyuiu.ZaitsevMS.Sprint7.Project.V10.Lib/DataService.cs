using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;

namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10.Lib
{
    public class DataService
    {
        // КЛИЕНТЫ

        public List<Client> LoadClients(string path)
        {
            var result = new List<Client>();
            if (!File.Exists(path)) return result;

            foreach (var line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var p = line.Split(';');
                if (p.Length < 6) continue;

                result.Add(new Client
                {
                    AccountNumber = p[0].Trim(),
                    LastName = p[1].Trim(),
                    FirstName = p[2].Trim(),
                    MiddleName = p[3].Trim(),
                    Address = p[4].Trim(),
                    Phone = p[5].Trim()
                });
            }
            return result;
        }

        public void SaveClients(string path, List<Client> clients)
        {
            var lines = clients.Select(c =>
                $"{c.AccountNumber};{c.LastName};{c.FirstName};{c.MiddleName};{c.Address};{c.Phone}");
            File.WriteAllLines(path, lines);
        }

        // ЗАКАЗЫ

        public List<Order> LoadOrders(string path)
        {
            var result = new List<Order>();
            if (!File.Exists(path)) return result;

            foreach (var line in File.ReadAllLines(path))
            {
                if (string.IsNullOrWhiteSpace(line)) continue;
                var p = line.Split(';');
                if (p.Length < 6) continue;

                result.Add(new Order
                {
                    OrderNumber = p[0].Trim(),
                    AccountNumber = p[1].Trim(),
                    OrderDate = DateTime.ParseExact(p[2].Trim(), "dd.MM.yyyy", CultureInfo.InvariantCulture),
                    ProductName = p[3].Trim(),
                    Price = decimal.Parse(p[4].Trim(), CultureInfo.InvariantCulture),
                    Quantity = int.Parse(p[5].Trim())
                });
            }
            return result;
        }

        public void SaveOrders(string path, List<Order> orders)
        {
            var lines = orders.Select(o =>
                $"{o.OrderNumber};{o.AccountNumber};{o.OrderDate:dd.MM.yyyy};{o.ProductName};{o.Price.ToString(CultureInfo.InvariantCulture)};{o.Quantity}");
            File.WriteAllLines(path, lines);
        }

        // ПОИСК И ФИЛЬТРАЦИЯ

        public List<Order> SearchOrders(List<Order> orders, string query)
        {
            if (string.IsNullOrWhiteSpace(query)) return orders;
            query = query.ToLower();
            return orders.Where(o =>
                o.OrderNumber.ToLower().Contains(query) ||
                o.AccountNumber.ToLower().Contains(query) ||
                o.ProductName.ToLower().Contains(query)).ToList();
        }

        public List<Order> SearchOrders(List<Order> orders, List<Client> clients, string query)
        {
            if (string.IsNullOrWhiteSpace(query)) return orders;
            query = query.ToLower();
            return orders.Where(o =>
                o.OrderNumber.ToLower().Contains(query) ||
                o.AccountNumber.ToLower().Contains(query) ||
                o.ProductName.ToLower().Contains(query) ||
                (clients.FirstOrDefault(c => c.AccountNumber == o.AccountNumber)
                    ?.FullName.ToLower().Contains(query) ?? false)).ToList();
        }

        public List<Order> FilterByClient(List<Order> orders, string accountNumber)
        {
            if (string.IsNullOrWhiteSpace(accountNumber)) return orders;
            return orders.Where(o => o.AccountNumber == accountNumber).ToList();
        }

        public List<Order> FilterByDateRange(List<Order> orders, DateTime from, DateTime to)
        {
            return orders.Where(o => o.OrderDate >= from && o.OrderDate <= to).ToList();
        }

        public List<Order> SortOrders(List<Order> orders, string column, bool ascending)
        {
            switch (column)
            {
                case "OrderNumber":
                    return ascending ? orders.OrderBy(o => o.OrderNumber).ToList()
                                     : orders.OrderByDescending(o => o.OrderNumber).ToList();
                case "AccountNumber":
                    return ascending ? orders.OrderBy(o => o.AccountNumber).ToList()
                                     : orders.OrderByDescending(o => o.AccountNumber).ToList();
                case "OrderDate":
                    return ascending ? orders.OrderBy(o => o.OrderDate).ToList()
                                     : orders.OrderByDescending(o => o.OrderDate).ToList();
                case "ProductName":
                    return ascending ? orders.OrderBy(o => o.ProductName).ToList()
                                     : orders.OrderByDescending(o => o.ProductName).ToList();
                case "TotalCost":
                    return ascending ? orders.OrderBy(o => o.TotalCost).ToList()
                                     : orders.OrderByDescending(o => o.TotalCost).ToList();
                case "Price":
                    return ascending ? orders.OrderBy(o => o.Price).ToList()
                                     : orders.OrderByDescending(o => o.Price).ToList();
                case "Quantity":
                    return ascending ? orders.OrderBy(o => o.Quantity).ToList()
                                     : orders.OrderByDescending(o => o.Quantity).ToList();
                default:
                    return orders;
            }
        }

        // СТАТИСТИКА

        public int GetCount(List<Order> orders) => orders.Count;

        public decimal GetSum(List<Order> orders) =>
            orders.Sum(o => o.TotalCost);

        public decimal GetAverage(List<Order> orders) =>
            orders.Count == 0 ? 0 : orders.Average(o => o.TotalCost);

        public decimal GetMin(List<Order> orders) =>
            orders.Count == 0 ? 0 : orders.Min(o => o.TotalCost);

        public decimal GetMax(List<Order> orders) =>
            orders.Count == 0 ? 0 : orders.Max(o => o.TotalCost);

        // Сумма заказов по клиенту
        public Dictionary<string, decimal> GetTotalByClient(List<Order> orders, List<Client> clients)
        {
            return orders
                .GroupBy(o => o.AccountNumber)
                .ToDictionary(
                    g => clients.FirstOrDefault(c => c.AccountNumber == g.Key)?.FullName ?? g.Key,
                    g => g.Sum(o => o.TotalCost));
        }
    }
}