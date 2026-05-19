using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint7.Project.V10.Lib;

namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    public partial class FormOrderEdit : Form
    {
        public Order ResultOrder { get; private set; }
        private readonly List<Client> clients_ZMS;
        private readonly Order editOrder_ZMS;

        public FormOrderEdit(List<Client> clients, Order order)
        {
            InitializeComponent();
            clients_ZMS = clients;
            editOrder_ZMS = order;

            FillClientsComboBox();

            if (editOrder_ZMS != null)
                LoadOrderToForm();
            else
                dateTimePickerOrderDate_ZMS.Value = DateTime.Today;
        }

        private void FillClientsComboBox()
        {
            comboBoxClient_ZMS.Items.Clear();
            foreach (var c in clients_ZMS)
                comboBoxClient_ZMS.Items.Add(c);
            comboBoxClient_ZMS.DisplayMember = "FullName";
        }

        private void LoadOrderToForm()
        {
            textBoxOrderNumber_ZMS.Text = editOrder_ZMS.OrderNumber;
            dateTimePickerOrderDate_ZMS.Value = editOrder_ZMS.OrderDate;
            textBoxProductName_ZMS.Text = editOrder_ZMS.ProductName;
            numericUpDownPrice_ZMS.Value = editOrder_ZMS.Price;
            numericUpDownQuantity_ZMS.Value = editOrder_ZMS.Quantity;

            for (int i = 0; i < comboBoxClient_ZMS.Items.Count; i++)
            {
                if (((Client)comboBoxClient_ZMS.Items[i]).AccountNumber == editOrder_ZMS.AccountNumber)
                {
                    comboBoxClient_ZMS.SelectedIndex = i;
                    break;
                }
            }
        }

        private void buttonSaveOrder_ZMS_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            var client = (Client)comboBoxClient_ZMS.SelectedItem;

            ResultOrder = new Order
            {
                OrderNumber = textBoxOrderNumber_ZMS.Text.Trim(),
                AccountNumber = client.AccountNumber,
                OrderDate = dateTimePickerOrderDate_ZMS.Value.Date,
                ProductName = textBoxProductName_ZMS.Text.Trim(),
                Price = numericUpDownPrice_ZMS.Value,
                Quantity = (int)numericUpDownQuantity_ZMS.Value
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelOrder_ZMS_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxOrderNumber_ZMS.Text))
            {
                MessageBox.Show("Введите номер заказа.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxOrderNumber_ZMS.Focus();
                return false;
            }
            if (comboBoxClient_ZMS.SelectedItem == null)
            {
                MessageBox.Show("Выберите клиента.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                comboBoxClient_ZMS.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxProductName_ZMS.Text))
            {
                MessageBox.Show("Введите название товара.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxProductName_ZMS.Focus();
                return false;
            }
            if (numericUpDownPrice_ZMS.Value <= 0)
            {
                MessageBox.Show("Цена должна быть больше нуля.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDownPrice_ZMS.Focus();
                return false;
            }
            if (numericUpDownQuantity_ZMS.Value <= 0)
            {
                MessageBox.Show("Количество должно быть больше нуля.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numericUpDownQuantity_ZMS.Focus();
                return false;
            }
            return true;
        }

        private void numericUpDownPrice_ZMS_ValueChanged(object sender, EventArgs e) => UpdateTotal();
        private void numericUpDownQuantity_ZMS_ValueChanged(object sender, EventArgs e) => UpdateTotal();

        private void UpdateTotal()
        {
            decimal total = numericUpDownPrice_ZMS.Value * numericUpDownQuantity_ZMS.Value;
            labelTotalCostValue_ZMS.Text = $"{total:F2} ₽";
        }
    }
}