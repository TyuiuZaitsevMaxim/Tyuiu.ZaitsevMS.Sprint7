namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    partial class FormClients
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
                components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.toolStripClients_ZMS = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddClient_ZMS = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditClient_ZMS = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteClient_ZMS = new System.Windows.Forms.ToolStripButton();
            this.dataGridViewClients_ZMS = new System.Windows.Forms.DataGridView();
            this.colAccountNumber_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colLastName_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFirstName_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMiddleName_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPhone_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddClient_ZMS = new System.Windows.Forms.Button();
            this.buttonEditClient_ZMS = new System.Windows.Forms.Button();
            this.buttonDeleteClient_ZMS = new System.Windows.Forms.Button();
            this.buttonCloseClients_ZMS = new System.Windows.Forms.Button();
            this.toolStripClients_ZMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients_ZMS)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStripClients_ZMS
            // 
            this.toolStripClients_ZMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripButtonAddClient_ZMS,
                this.toolStripButtonEditClient_ZMS,
                this.toolStripButtonDeleteClient_ZMS });
            this.toolStripClients_ZMS.Location = new System.Drawing.Point(0, 0);
            this.toolStripClients_ZMS.Name = "toolStripClients_ZMS";
            this.toolStripClients_ZMS.Size = new System.Drawing.Size(900, 25);
            this.toolStripClients_ZMS.TabIndex = 0;
            // 
            // toolStripButtonAddClient_ZMS
            // 
            this.toolStripButtonAddClient_ZMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddClient_ZMS.Name = "toolStripButtonAddClient_ZMS";
            this.toolStripButtonAddClient_ZMS.Text = "➕ Добавить";
            this.toolStripButtonAddClient_ZMS.ToolTipText = "Добавить нового клиента";
            this.toolStripButtonAddClient_ZMS.Click += new System.EventHandler(this.buttonAddClient_ZMS_Click);
            // 
            // toolStripButtonEditClient_ZMS
            // 
            this.toolStripButtonEditClient_ZMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEditClient_ZMS.Name = "toolStripButtonEditClient_ZMS";
            this.toolStripButtonEditClient_ZMS.Text = "✏️ Изменить";
            this.toolStripButtonEditClient_ZMS.ToolTipText = "Редактировать выбранного клиента";
            this.toolStripButtonEditClient_ZMS.Click += new System.EventHandler(this.buttonEditClient_ZMS_Click);
            // 
            // toolStripButtonDeleteClient_ZMS
            // 
            this.toolStripButtonDeleteClient_ZMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeleteClient_ZMS.Name = "toolStripButtonDeleteClient_ZMS";
            this.toolStripButtonDeleteClient_ZMS.Text = "🗑️ Удалить";
            this.toolStripButtonDeleteClient_ZMS.ToolTipText = "Удалить выбранного клиента";
            this.toolStripButtonDeleteClient_ZMS.Click += new System.EventHandler(this.buttonDeleteClient_ZMS_Click);
            // 
            // dataGridViewClients_ZMS
            // 
            this.dataGridViewClients_ZMS.AllowUserToAddRows = false;
            this.dataGridViewClients_ZMS.AllowUserToDeleteRows = false;
            this.dataGridViewClients_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewClients_ZMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewClients_ZMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colAccountNumber_ZMS,
                this.colLastName_ZMS,
                this.colFirstName_ZMS,
                this.colMiddleName_ZMS,
                this.colAddress_ZMS,
                this.colPhone_ZMS });
            this.dataGridViewClients_ZMS.Location = new System.Drawing.Point(0, 28);
            this.dataGridViewClients_ZMS.MultiSelect = false;
            this.dataGridViewClients_ZMS.Name = "dataGridViewClients_ZMS";
            this.dataGridViewClients_ZMS.ReadOnly = true;
            this.dataGridViewClients_ZMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewClients_ZMS.Size = new System.Drawing.Size(900, 480);
            this.dataGridViewClients_ZMS.TabIndex = 1;
            // 
            // colAccountNumber_ZMS
            // 
            this.colAccountNumber_ZMS.HeaderText = "№ Счёта";
            this.colAccountNumber_ZMS.Name = "colAccountNumber_ZMS";
            this.colAccountNumber_ZMS.Width = 100;
            // 
            // colLastName_ZMS
            // 
            this.colLastName_ZMS.HeaderText = "Фамилия";
            this.colLastName_ZMS.Name = "colLastName_ZMS";
            this.colLastName_ZMS.Width = 150;
            // 
            // colFirstName_ZMS
            // 
            this.colFirstName_ZMS.HeaderText = "Имя";
            this.colFirstName_ZMS.Name = "colFirstName_ZMS";
            this.colFirstName_ZMS.Width = 120;
            // 
            // colMiddleName_ZMS
            // 
            this.colMiddleName_ZMS.HeaderText = "Отчество";
            this.colMiddleName_ZMS.Name = "colMiddleName_ZMS";
            this.colMiddleName_ZMS.Width = 150;
            // 
            // colAddress_ZMS
            // 
            this.colAddress_ZMS.HeaderText = "Адрес";
            this.colAddress_ZMS.Name = "colAddress_ZMS";
            this.colAddress_ZMS.Width = 200;
            // 
            // colPhone_ZMS
            // 
            this.colPhone_ZMS.HeaderText = "Телефон";
            this.colPhone_ZMS.Name = "colPhone_ZMS";
            this.colPhone_ZMS.Width = 130;
            // 
            // buttonAddClient_ZMS
            // 
            this.buttonAddClient_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonAddClient_ZMS.Location = new System.Drawing.Point(12, 520);
            this.buttonAddClient_ZMS.Name = "buttonAddClient_ZMS";
            this.buttonAddClient_ZMS.Size = new System.Drawing.Size(100, 30);
            this.buttonAddClient_ZMS.TabIndex = 2;
            this.buttonAddClient_ZMS.Text = "Добавить";
            this.buttonAddClient_ZMS.UseVisualStyleBackColor = true;
            this.buttonAddClient_ZMS.Click += new System.EventHandler(this.buttonAddClient_ZMS_Click);
            // 
            // buttonEditClient_ZMS
            // 
            this.buttonEditClient_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonEditClient_ZMS.Location = new System.Drawing.Point(118, 520);
            this.buttonEditClient_ZMS.Name = "buttonEditClient_ZMS";
            this.buttonEditClient_ZMS.Size = new System.Drawing.Size(100, 30);
            this.buttonEditClient_ZMS.TabIndex = 3;
            this.buttonEditClient_ZMS.Text = "Изменить";
            this.buttonEditClient_ZMS.UseVisualStyleBackColor = true;
            this.buttonEditClient_ZMS.Click += new System.EventHandler(this.buttonEditClient_ZMS_Click);
            // 
            // buttonDeleteClient_ZMS
            // 
            this.buttonDeleteClient_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.buttonDeleteClient_ZMS.Location = new System.Drawing.Point(224, 520);
            this.buttonDeleteClient_ZMS.Name = "buttonDeleteClient_ZMS";
            this.buttonDeleteClient_ZMS.Size = new System.Drawing.Size(100, 30);
            this.buttonDeleteClient_ZMS.TabIndex = 4;
            this.buttonDeleteClient_ZMS.Text = "Удалить";
            this.buttonDeleteClient_ZMS.UseVisualStyleBackColor = true;
            this.buttonDeleteClient_ZMS.Click += new System.EventHandler(this.buttonDeleteClient_ZMS_Click);
            // 
            // buttonCloseClients_ZMS
            // 
            this.buttonCloseClients_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCloseClients_ZMS.Location = new System.Drawing.Point(788, 520);
            this.buttonCloseClients_ZMS.Name = "buttonCloseClients_ZMS";
            this.buttonCloseClients_ZMS.Size = new System.Drawing.Size(100, 30);
            this.buttonCloseClients_ZMS.TabIndex = 5;
            this.buttonCloseClients_ZMS.Text = "Закрыть";
            this.buttonCloseClients_ZMS.UseVisualStyleBackColor = true;
            this.buttonCloseClients_ZMS.Click += new System.EventHandler(this.buttonCloseClients_ZMS_Click);
            // 
            // FormClients
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 562);
            this.Controls.Add(this.buttonCloseClients_ZMS);
            this.Controls.Add(this.buttonDeleteClient_ZMS);
            this.Controls.Add(this.buttonEditClient_ZMS);
            this.Controls.Add(this.buttonAddClient_ZMS);
            this.Controls.Add(this.dataGridViewClients_ZMS);
            this.Controls.Add(this.toolStripClients_ZMS);
            this.MinimumSize = new System.Drawing.Size(700, 450);
            this.Name = "FormClients";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Справочник клиентов";
            this.toolStripClients_ZMS.ResumeLayout(false);
            this.toolStripClients_ZMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewClients_ZMS)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStripClients_ZMS;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddClient_ZMS;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditClient_ZMS;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteClient_ZMS;
        private System.Windows.Forms.DataGridView dataGridViewClients_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAccountNumber_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colLastName_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFirstName_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMiddleName_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPhone_ZMS;
        private System.Windows.Forms.Button buttonAddClient_ZMS;
        private System.Windows.Forms.Button buttonEditClient_ZMS;
        private System.Windows.Forms.Button buttonDeleteClient_ZMS;
        private System.Windows.Forms.Button buttonCloseClients_ZMS;
    }
}