using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using Tyuiu.ZaitsevMS.Sprint7.Project.V10.Lib;

namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    public partial class FormStats : Form
    {
        private readonly List<Order> orders_ZMS;
        private readonly List<Client> clients_ZMS;
        private readonly DataService dataService_ZMS;

        public FormStats(List<Order> orders, List<Client> clients, DataService dataService)
        {
            InitializeComponent();
            orders_ZMS = orders;
            clients_ZMS = clients;
            dataService_ZMS = dataService;

            FillStatistics();
            BuildChart();
        }

        // СТАТИСТИКА

        private void FillStatistics()
        {
            labelCountValue_ZMS.Text = dataService_ZMS.GetCount(orders_ZMS).ToString();
            labelSumValue_ZMS.Text = $"{dataService_ZMS.GetSum(orders_ZMS):F2} ₽";
            labelAverageValue_ZMS.Text = $"{dataService_ZMS.GetAverage(orders_ZMS):F2} ₽";
            labelMinValue_ZMS.Text = $"{dataService_ZMS.GetMin(orders_ZMS):F2} ₽";
            labelMaxValue_ZMS.Text = $"{dataService_ZMS.GetMax(orders_ZMS):F2} ₽";

            // Клиент с максимальной суммой заказов
            var byClient = dataService_ZMS.GetTotalByClient(orders_ZMS, clients_ZMS);
            if (byClient.Count > 0)
            {
                var top = byClient.OrderByDescending(kv => kv.Value).First();
                labelTopClientValue_ZMS.Text = $"{top.Key} ({top.Value:F2} ₽)";
            }
            else
            {
                labelTopClientValue_ZMS.Text = "—";
            }
        }

        // ГИСТОГРАММА

        private void BuildChart()
        {
            chartOrdersByClient_ZMS.Series.Clear();
            chartOrdersByClient_ZMS.ChartAreas[0].AxisX.LabelStyle.Angle = -35;
            chartOrdersByClient_ZMS.ChartAreas[0].AxisX.LabelStyle.IsStaggered = false;
            chartOrdersByClient_ZMS.ChartAreas[0].AxisY.Title = "Сумма заказов (₽)";
            chartOrdersByClient_ZMS.ChartAreas[0].AxisX.Title = "Клиент";
            chartOrdersByClient_ZMS.ChartAreas[0].AxisY.LabelStyle.Format = "F0";

            var series = new Series("Сумма заказов")
            {
                ChartType = SeriesChartType.Column,
                Color = Color.SteelBlue,
                IsValueShownAsLabel = true,
                LabelFormat = "F0"
            };

            var byClient = dataService_ZMS.GetTotalByClient(orders_ZMS, clients_ZMS);

            foreach (var kv in byClient.OrderByDescending(x => x.Value))
            {
                // Укорачиваем длинные имена для оси X
                string label = kv.Key.Length > 18 ? kv.Key.Substring(0, 16) + "…" : kv.Key;
                series.Points.AddXY(label, (double)kv.Value);
            }

            chartOrdersByClient_ZMS.Series.Add(series);
            chartOrdersByClient_ZMS.Titles.Clear();
            chartOrdersByClient_ZMS.Titles.Add(new Title(
                "Сумма заказов по клиентам",
                Docking.Top,
                new Font("Microsoft Sans Serif", 10, FontStyle.Bold),
                Color.Black));
        }

        // ЗАКРЫТЬ

        private void buttonCloseStats_ZMS_Click(object sender, EventArgs e) => Close();
    }
}