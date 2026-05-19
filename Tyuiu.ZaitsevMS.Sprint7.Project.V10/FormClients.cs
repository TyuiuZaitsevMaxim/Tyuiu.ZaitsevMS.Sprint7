using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint7.Project.V10.Lib;

namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    public partial class FormClients : Form
    {
        private readonly DataService dataService_ZMS;
        private List<Client> clients_ZMS;
        private readonly string clientsPath_ZMS;

        public FormClients(List<Client> clients, string path, DataService dataService)
        {
            InitializeComponent();
            clients_ZMS = clients;
            clientsPath_ZMS = path;
            dataService_ZMS = dataService;
            RefreshGrid();
        }

        // ─── ОТОБРАЖЕНИЕ ─────────────────────────────────────────────

        private void RefreshGrid()
        {
            dataGridViewClients_ZMS.Rows.Clear();
            foreach (var c in clients_ZMS)
                dataGridViewClients_ZMS.Rows.Add(
                    c.AccountNumber, c.LastName, c.FirstName,
                    c.MiddleName, c.Address, c.Phone);
        }

        // ─── ДОБАВИТЬ ────────────────────────────────────────────────

        private void buttonAddClient_ZMS_Click(object sender, EventArgs e)
        {
            using (var form = new FormClientEdit(null))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    clients_ZMS.Add(form.ResultClient);
                    dataService_ZMS.SaveClients(clientsPath_ZMS, clients_ZMS);
                    RefreshGrid();
                }
            }
        }

        // ─── РЕДАКТИРОВАТЬ ───────────────────────────────────────────

        private void buttonEditClient_ZMS_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients_ZMS.CurrentRow == null) return;

            string account = dataGridViewClients_ZMS.CurrentRow.Cells[0].Value?.ToString();
            var client = clients_ZMS.Find(c => c.AccountNumber == account);
            if (client == null) return;

            using (var form = new FormClientEdit(client))
            {
                if (form.ShowDialog() == DialogResult.OK)
                {
                    var idx = clients_ZMS.IndexOf(client);
                    clients_ZMS[idx] = form.ResultClient;
                    dataService_ZMS.SaveClients(clientsPath_ZMS, clients_ZMS);
                    RefreshGrid();
                }
            }
        }

        // ─── УДАЛИТЬ ─────────────────────────────────────────────────

        private void buttonDeleteClient_ZMS_Click(object sender, EventArgs e)
        {
            if (dataGridViewClients_ZMS.CurrentRow == null) return;

            string account = dataGridViewClients_ZMS.CurrentRow.Cells[0].Value?.ToString();
            var client = clients_ZMS.Find(c => c.AccountNumber == account);
            if (client == null) return;

            if (MessageBox.Show($"Удалить клиента {client.FullName}?", "Подтверждение",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                clients_ZMS.Remove(client);
                dataService_ZMS.SaveClients(clientsPath_ZMS, clients_ZMS);
                RefreshGrid();
            }
        }

        // ─── ЗАКРЫТЬ ─────────────────────────────────────────────────

        private void buttonCloseClients_ZMS_Click(object sender, EventArgs e) => Close();
    }
}   