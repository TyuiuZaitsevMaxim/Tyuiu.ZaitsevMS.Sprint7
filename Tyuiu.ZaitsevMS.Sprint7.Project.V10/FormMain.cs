using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint7.Project.V10.Lib;

namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    public partial class FormMain : Form
    {
        private readonly DataService dataService_ZMS = new DataService();
        private List<Order> orders_ZMS = new List<Order>();
        private List<Client> clients_ZMS = new List<Client>();

        private readonly string ordersPath_ZMS =
            System.IO.Path.Combine(Application.StartupPath, "Orders.csv");
        private readonly string clientsPath_ZMS =
            System.IO.Path.Combine(Application.StartupPath, "Clients.csv");

        public FormMain()
        {
            InitializeComponent();
            LoadData();
            RefreshGrid();
        }

        private void LoadData()
        {
            clients_ZMS = dataService_ZMS.LoadClients(clientsPath_ZMS);
            orders_ZMS = dataService_ZMS.LoadOrders(ordersPath_ZMS);
        }

        private void SaveData()
        {
            dataService_ZMS.SaveOrders(ordersPath_ZMS, orders_ZMS);
            dataService_ZMS.SaveClients(clientsPath_ZMS, clients_ZMS);
        }

        private void RefreshGrid(List<Order> source = null)
        {
            var list = source ?? orders_ZMS;
            dataGridViewOrders_ZMS.Rows.Clear();

            foreach (var o in list)
            {
                var client = clients_ZMS.FirstOrDefault(c => c.AccountNumber == o.AccountNumber);
                string clientName = client?.FullName ?? o.AccountNumber;
                dataGridViewOrders_ZMS.Rows.Add(
                    o.OrderNumber,
                    clientName,
                    o.OrderDate.ToString("dd.MM.yyyy"),
                    o.ProductName,
                    o.Price.ToString("F2"),
                    o.Quantity,
                    o.TotalCost.ToString("F2"));
            }

            UpdateStatusBar(list);
        }

        private void UpdateStatusBar(List<Order> list)
        {
            toolStripStatusLabelCount_ZMS.Text = $"Заказов: {dataService_ZMS.GetCount(list)}";
            toolStripStatusLabelSum_ZMS.Text = $"Сумма: {dataService_ZMS.GetSum(list):F2} ₽";
            toolStripStatusLabelAvg_ZMS.Text = $"Среднее: {dataService_ZMS.GetAverage(list):F2} ₽";
            toolStripStatusLabelMin_ZMS.Text = $"Min: {dataService_ZMS.GetMin(list):F2} ₽";
            toolStripStatusLabelMax_ZMS.Text = $"Max: {dataService_ZMS.GetMax(list):F2} ₽";
        }

        private void OpenAddOrder()
        {
            using (var form = new FormOrderEdit(clients_ZMS, null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    orders_ZMS.Add(form.ResultOrder);
                    SaveData();
                    RefreshGrid();
                }
            }
        }

        private void OpenEditOrder()
        {
            if (dataGridViewOrders_ZMS.CurrentRow == null) return;
            string orderNumber = dataGridViewOrders_ZMS.CurrentRow.Cells[0].Value?.ToString();
            var order = orders_ZMS.FirstOrDefault(o => o.OrderNumber == orderNumber);
            if (order == null) return;

            using (var form = new FormOrderEdit(clients_ZMS, order))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var idx = orders_ZMS.IndexOf(order);
                    orders_ZMS[idx] = form.ResultOrder;
                    SaveData();
                    RefreshGrid();
                }
            }
        }

        private void DeleteOrder()
        {
            if (dataGridViewOrders_ZMS.CurrentRow == null) return;
            string orderNumber = dataGridViewOrders_ZMS.CurrentRow.Cells[0].Value?.ToString();
            var order = orders_ZMS.FirstOrDefault(o => o.OrderNumber == orderNumber);
            if (order == null) return;

            if (MessageBox.Show($"Удалить заказ {orderNumber}?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                orders_ZMS.Remove(order);
                SaveData();
                RefreshGrid();
            }
        }

        private void toolStripButtonAddOrder_ZMS_Click(object sender, EventArgs e) => OpenAddOrder();
        private void menuItemAddOrder_ZMS_Click(object sender, EventArgs e) => OpenAddOrder();
        private void toolStripButtonEditOrder_ZMS_Click(object sender, EventArgs e) => OpenEditOrder();
        private void menuItemEditOrder_ZMS_Click(object sender, EventArgs e) => OpenEditOrder();
        private void toolStripButtonDeleteOrder_ZMS_Click(object sender, EventArgs e) => DeleteOrder();
        private void menuItemDeleteOrder_ZMS_Click(object sender, EventArgs e) => DeleteOrder();

        private void toolStripTextBoxSearch_ZMS_TextChanged(object sender, EventArgs e)
        {
            var filtered = dataService_ZMS.SearchOrders(orders_ZMS, toolStripTextBoxSearch_ZMS.Text);
            RefreshGrid(filtered);
        }

        private void dataGridViewOrders_ZMS_ColumnHeaderMouseClick(object sender,
            DataGridViewCellMouseEventArgs e)
        {
            string[] columns = { "OrderNumber", "AccountNumber", "OrderDate",
                                  "ProductName", "Price", "Quantity", "TotalCost" };
            if (e.ColumnIndex >= columns.Length) return;
            var sorted = dataService_ZMS.SortOrders(orders_ZMS, columns[e.ColumnIndex], true);
            RefreshGrid(sorted);
        }

        private void menuItemClients_ZMS_Click(object sender, EventArgs e)
        {
            using (var form = new FormClients(clients_ZMS, clientsPath_ZMS, dataService_ZMS))
            {
                form.ShowDialog();
                clients_ZMS = dataService_ZMS.LoadClients(clientsPath_ZMS);
                RefreshGrid();
            }
        }

        private void menuItemStats_ZMS_Click(object sender, EventArgs e)
        {
            using (var form = new FormStats(orders_ZMS, clients_ZMS, dataService_ZMS))
                form.ShowDialog();
        }

        private void toolStripButtonStats_ZMS_Click(object sender, EventArgs e)
        {
            using (var form = new FormStats(orders_ZMS, clients_ZMS, dataService_ZMS))
                form.ShowDialog();
        }

        private void menuItemAbout_ZMS_Click(object sender, EventArgs e)
        {
            using (var form = new FormAbout())
                form.ShowDialog();
        }

        private void menuItemHelp_ZMS_Click(object sender, EventArgs e)
        {
            using (var form = new FormHelp())
                form.ShowDialog();
        }
    }
}