using System;

namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10.Lib
{
    public class Order
    {
        public string OrderNumber { get; set; }     // Номер заказа
        public string AccountNumber { get; set; }   // Номер счёта клиента (внешний ключ)
        public DateTime OrderDate { get; set; }     // Дата исполнения
        public string ProductName { get; set; }     // Название товара
        public decimal Price { get; set; }          // Цена за единицу
        public int Quantity { get; set; }           // Количество

        public decimal TotalCost => Price * Quantity;

        public override string ToString() =>
            $"{OrderNumber} | {AccountNumber} | {OrderDate:dd.MM.yyyy} | {ProductName} | {Price} x {Quantity} = {TotalCost}";
    }
}