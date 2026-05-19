using System;
using System.Windows.Forms;
using Tyuiu.ZaitsevMS.Sprint7.Project.V10.Lib;

namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    public partial class FormClientEdit : Form
    {
        public Client ResultClient { get; private set; }
        private readonly Client editClient_ZMS;

        public FormClientEdit(Client client)
        {
            InitializeComponent();
            editClient_ZMS = client;

            if (editClient_ZMS != null)
                LoadClientToForm();
        }

        private void LoadClientToForm()
        {
            textBoxAccountNumber_ZMS.Text = editClient_ZMS.AccountNumber;
            textBoxLastName_ZMS.Text = editClient_ZMS.LastName;
            textBoxFirstName_ZMS.Text = editClient_ZMS.FirstName;
            textBoxMiddleName_ZMS.Text = editClient_ZMS.MiddleName;
            textBoxAddress_ZMS.Text = editClient_ZMS.Address;
            textBoxPhone_ZMS.Text = editClient_ZMS.Phone;
        }

        private void buttonSaveClient_ZMS_Click(object sender, EventArgs e)
        {
            if (!ValidateForm()) return;

            ResultClient = new Client
            {
                AccountNumber = textBoxAccountNumber_ZMS.Text.Trim(),
                LastName = textBoxLastName_ZMS.Text.Trim(),
                FirstName = textBoxFirstName_ZMS.Text.Trim(),
                MiddleName = textBoxMiddleName_ZMS.Text.Trim(),
                Address = textBoxAddress_ZMS.Text.Trim(),
                Phone = textBoxPhone_ZMS.Text.Trim()
            };

            DialogResult = DialogResult.OK;
            Close();
        }

        private void buttonCancelClient_ZMS_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBoxAccountNumber_ZMS.Text))
            {
                MessageBox.Show("Введите номер счёта.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxAccountNumber_ZMS.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxLastName_ZMS.Text))
            {
                MessageBox.Show("Введите фамилию.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxLastName_ZMS.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxFirstName_ZMS.Text))
            {
                MessageBox.Show("Введите имя.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxFirstName_ZMS.Focus();
                return false;
            }
            if (string.IsNullOrWhiteSpace(textBoxPhone_ZMS.Text))
            {
                MessageBox.Show("Введите телефон.", "Ошибка",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxPhone_ZMS.Focus();
                return false;
            }
            return true;
        }
    }
}