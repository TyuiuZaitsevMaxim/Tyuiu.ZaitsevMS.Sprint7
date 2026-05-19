namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    partial class FormMain
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
            this.menuStripMain_ZMS = new System.Windows.Forms.MenuStrip();
            this.menuItemData_ZMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAddOrder_ZMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemEditOrder_ZMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemDeleteOrder_ZMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemSeparator1_ZMS = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemClients_ZMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemView_ZMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemStats_ZMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelp_ZMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemHelpContent_ZMS = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemAbout_ZMS = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMain_ZMS = new System.Windows.Forms.ToolStrip();
            this.toolStripButtonAddOrder_ZMS = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonEditOrder_ZMS = new System.Windows.Forms.ToolStripButton();
            this.toolStripButtonDeleteOrder_ZMS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1_ZMS = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButtonStats_ZMS = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2_ZMS = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabelSearch_ZMS = new System.Windows.Forms.ToolStripLabel();
            this.toolStripTextBoxSearch_ZMS = new System.Windows.Forms.ToolStripTextBox();
            this.dataGridViewOrders_ZMS = new System.Windows.Forms.DataGridView();
            this.colOrderNumber_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClientName_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colOrderDate_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colProductName_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPrice_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colQuantity_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colTotalCost_ZMS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStripMain_ZMS = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabelCount_ZMS = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelSum_ZMS = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelAvg_ZMS = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMin_ZMS = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabelMax_ZMS = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripMain_ZMS.SuspendLayout();
            this.toolStripMain_ZMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders_ZMS)).BeginInit();
            this.statusStripMain_ZMS.SuspendLayout();
            this.SuspendLayout();
            // menuStripMain_ZMS
            this.menuStripMain_ZMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemData_ZMS,
                this.menuItemView_ZMS,
                this.menuItemHelp_ZMS });
            this.menuStripMain_ZMS.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain_ZMS.Name = "menuStripMain_ZMS";
            this.menuStripMain_ZMS.Size = new System.Drawing.Size(1100, 24);
            this.menuStripMain_ZMS.TabIndex = 0;
            // menuItemData_ZMS
            this.menuItemData_ZMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemAddOrder_ZMS,
                this.menuItemEditOrder_ZMS,
                this.menuItemDeleteOrder_ZMS,
                this.menuItemSeparator1_ZMS,
                this.menuItemClients_ZMS });
            this.menuItemData_ZMS.Name = "menuItemData_ZMS";
            this.menuItemData_ZMS.Text = "Данные";
            // menuItemAddOrder_ZMS
            this.menuItemAddOrder_ZMS.Name = "menuItemAddOrder_ZMS";
            this.menuItemAddOrder_ZMS.Text = "Добавить заказ";
            this.menuItemAddOrder_ZMS.Click += new System.EventHandler(this.menuItemAddOrder_ZMS_Click);
            // menuItemEditOrder_ZMS
            this.menuItemEditOrder_ZMS.Name = "menuItemEditOrder_ZMS";
            this.menuItemEditOrder_ZMS.Text = "Редактировать заказ";
            this.menuItemEditOrder_ZMS.Click += new System.EventHandler(this.menuItemEditOrder_ZMS_Click);
            // menuItemDeleteOrder_ZMS
            this.menuItemDeleteOrder_ZMS.Name = "menuItemDeleteOrder_ZMS";
            this.menuItemDeleteOrder_ZMS.Text = "Удалить заказ";
            this.menuItemDeleteOrder_ZMS.Click += new System.EventHandler(this.menuItemDeleteOrder_ZMS_Click);
            // menuItemSeparator1_ZMS
            this.menuItemSeparator1_ZMS.Name = "menuItemSeparator1_ZMS";
            // menuItemClients_ZMS
            this.menuItemClients_ZMS.Name = "menuItemClients_ZMS";
            this.menuItemClients_ZMS.Text = "Справочник клиентов";
            this.menuItemClients_ZMS.Click += new System.EventHandler(this.menuItemClients_ZMS_Click);
            // menuItemView_ZMS
            this.menuItemView_ZMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemStats_ZMS });
            this.menuItemView_ZMS.Name = "menuItemView_ZMS";
            this.menuItemView_ZMS.Text = "Вид";
            // menuItemStats_ZMS
            this.menuItemStats_ZMS.Name = "menuItemStats_ZMS";
            this.menuItemStats_ZMS.Text = "Статистика";
            this.menuItemStats_ZMS.Click += new System.EventHandler(this.menuItemStats_ZMS_Click);
            // menuItemHelp_ZMS
            this.menuItemHelp_ZMS.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.menuItemHelpContent_ZMS,
                this.menuItemAbout_ZMS });
            this.menuItemHelp_ZMS.Name = "menuItemHelp_ZMS";
            this.menuItemHelp_ZMS.Text = "Справка";
            // menuItemHelpContent_ZMS
            this.menuItemHelpContent_ZMS.Name = "menuItemHelpContent_ZMS";
            this.menuItemHelpContent_ZMS.Text = "Руководство пользователя";
            this.menuItemHelpContent_ZMS.Click += new System.EventHandler(this.menuItemHelp_ZMS_Click);
            // menuItemAbout_ZMS
            this.menuItemAbout_ZMS.Name = "menuItemAbout_ZMS";
            this.menuItemAbout_ZMS.Text = "О программе";
            this.menuItemAbout_ZMS.Click += new System.EventHandler(this.menuItemAbout_ZMS_Click);
            // toolStripMain_ZMS
            this.toolStripMain_ZMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripButtonAddOrder_ZMS,
                this.toolStripButtonEditOrder_ZMS,
                this.toolStripButtonDeleteOrder_ZMS,
                this.toolStripSeparator1_ZMS,
                this.toolStripButtonStats_ZMS,
                this.toolStripSeparator2_ZMS,
                this.toolStripLabelSearch_ZMS,
                this.toolStripTextBoxSearch_ZMS });
            this.toolStripMain_ZMS.Location = new System.Drawing.Point(0, 24);
            this.toolStripMain_ZMS.Name = "toolStripMain_ZMS";
            this.toolStripMain_ZMS.Size = new System.Drawing.Size(1100, 25);
            this.toolStripMain_ZMS.TabIndex = 1;
            // toolStripButtonAddOrder_ZMS
            this.toolStripButtonAddOrder_ZMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonAddOrder_ZMS.Name = "toolStripButtonAddOrder_ZMS";
            this.toolStripButtonAddOrder_ZMS.Text = "Добавить";
            this.toolStripButtonAddOrder_ZMS.ToolTipText = "Добавить новый заказ";
            this.toolStripButtonAddOrder_ZMS.Click += new System.EventHandler(this.toolStripButtonAddOrder_ZMS_Click);
            // toolStripButtonEditOrder_ZMS
            this.toolStripButtonEditOrder_ZMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonEditOrder_ZMS.Name = "toolStripButtonEditOrder_ZMS";
            this.toolStripButtonEditOrder_ZMS.Text = "Изменить";
            this.toolStripButtonEditOrder_ZMS.ToolTipText = "Редактировать выбранный заказ";
            this.toolStripButtonEditOrder_ZMS.Click += new System.EventHandler(this.toolStripButtonEditOrder_ZMS_Click);
            // toolStripButtonDeleteOrder_ZMS
            this.toolStripButtonDeleteOrder_ZMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonDeleteOrder_ZMS.Name = "toolStripButtonDeleteOrder_ZMS";
            this.toolStripButtonDeleteOrder_ZMS.Text = "Удалить";
            this.toolStripButtonDeleteOrder_ZMS.ToolTipText = "Удалить выбранный заказ";
            this.toolStripButtonDeleteOrder_ZMS.Click += new System.EventHandler(this.toolStripButtonDeleteOrder_ZMS_Click);
            // toolStripSeparator1_ZMS
            this.toolStripSeparator1_ZMS.Name = "toolStripSeparator1_ZMS";
            // toolStripButtonStats_ZMS
            this.toolStripButtonStats_ZMS.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButtonStats_ZMS.Name = "toolStripButtonStats_ZMS";
            this.toolStripButtonStats_ZMS.Text = "Статистика";
            this.toolStripButtonStats_ZMS.ToolTipText = "Открыть окно статистики и графиков";
            this.toolStripButtonStats_ZMS.Click += new System.EventHandler(this.toolStripButtonStats_ZMS_Click);
            // toolStripSeparator2_ZMS
            this.toolStripSeparator2_ZMS.Name = "toolStripSeparator2_ZMS";
            // toolStripLabelSearch_ZMS
            this.toolStripLabelSearch_ZMS.Name = "toolStripLabelSearch_ZMS";
            this.toolStripLabelSearch_ZMS.Text = "Поиск:";
            // toolStripTextBoxSearch_ZMS
            this.toolStripTextBoxSearch_ZMS.Name = "toolStripTextBoxSearch_ZMS";
            this.toolStripTextBoxSearch_ZMS.Size = new System.Drawing.Size(180, 25);
            this.toolStripTextBoxSearch_ZMS.ToolTipText = "Поиск по номеру заказа, клиенту или товару";
            this.toolStripTextBoxSearch_ZMS.TextChanged += new System.EventHandler(this.toolStripTextBoxSearch_ZMS_TextChanged);
            // dataGridViewOrders_ZMS
            this.dataGridViewOrders_ZMS.AllowUserToAddRows = false;
            this.dataGridViewOrders_ZMS.AllowUserToDeleteRows = false;
            this.dataGridViewOrders_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewOrders_ZMS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOrders_ZMS.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
                this.colOrderNumber_ZMS,
                this.colClientName_ZMS,
                this.colOrderDate_ZMS,
                this.colProductName_ZMS,
                this.colPrice_ZMS,
                this.colQuantity_ZMS,
                this.colTotalCost_ZMS });
            this.dataGridViewOrders_ZMS.Location = new System.Drawing.Point(0, 52);
            this.dataGridViewOrders_ZMS.MultiSelect = false;
            this.dataGridViewOrders_ZMS.Name = "dataGridViewOrders_ZMS";
            this.dataGridViewOrders_ZMS.ReadOnly = true;
            this.dataGridViewOrders_ZMS.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewOrders_ZMS.Size = new System.Drawing.Size(1100, 530);
            this.dataGridViewOrders_ZMS.TabIndex = 2;
            this.dataGridViewOrders_ZMS.ColumnHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridViewOrders_ZMS_ColumnHeaderMouseClick);
            // colOrderNumber_ZMS
            this.colOrderNumber_ZMS.HeaderText = "№ Заказа";
            this.colOrderNumber_ZMS.Name = "colOrderNumber_ZMS";
            this.colOrderNumber_ZMS.Width = 100;
            // colClientName_ZMS
            this.colClientName_ZMS.HeaderText = "Клиент";
            this.colClientName_ZMS.Name = "colClientName_ZMS";
            this.colClientName_ZMS.Width = 200;
            // colOrderDate_ZMS
            this.colOrderDate_ZMS.HeaderText = "Дата";
            this.colOrderDate_ZMS.Name = "colOrderDate_ZMS";
            this.colOrderDate_ZMS.Width = 100;
            // colProductName_ZMS
            this.colProductName_ZMS.HeaderText = "Товар";
            this.colProductName_ZMS.Name = "colProductName_ZMS";
            this.colProductName_ZMS.Width = 200;
            // colPrice_ZMS
            this.colPrice_ZMS.HeaderText = "Цена";
            this.colPrice_ZMS.Name = "colPrice_ZMS";
            this.colPrice_ZMS.Width = 100;
            // colQuantity_ZMS
            this.colQuantity_ZMS.HeaderText = "Кол-во";
            this.colQuantity_ZMS.Name = "colQuantity_ZMS";
            this.colQuantity_ZMS.Width = 80;
            // colTotalCost_ZMS
            this.colTotalCost_ZMS.HeaderText = "Итого";
            this.colTotalCost_ZMS.Name = "colTotalCost_ZMS";
            this.colTotalCost_ZMS.Width = 120;
            // statusStripMain_ZMS
            this.statusStripMain_ZMS.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
                this.toolStripStatusLabelCount_ZMS,
                this.toolStripStatusLabelSum_ZMS,
                this.toolStripStatusLabelAvg_ZMS,
                this.toolStripStatusLabelMin_ZMS,
                this.toolStripStatusLabelMax_ZMS });
            this.statusStripMain_ZMS.Location = new System.Drawing.Point(0, 582);
            this.statusStripMain_ZMS.Name = "statusStripMain_ZMS";
            this.statusStripMain_ZMS.Size = new System.Drawing.Size(1100, 22);
            this.statusStripMain_ZMS.TabIndex = 3;
            // toolStripStatusLabelCount_ZMS
            this.toolStripStatusLabelCount_ZMS.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelCount_ZMS.Name = "toolStripStatusLabelCount_ZMS";
            this.toolStripStatusLabelCount_ZMS.Text = "Заказов: 0";
            // toolStripStatusLabelSum_ZMS
            this.toolStripStatusLabelSum_ZMS.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelSum_ZMS.Name = "toolStripStatusLabelSum_ZMS";
            this.toolStripStatusLabelSum_ZMS.Text = "Сумма: 0.00 ₽";
            // toolStripStatusLabelAvg_ZMS
            this.toolStripStatusLabelAvg_ZMS.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelAvg_ZMS.Name = "toolStripStatusLabelAvg_ZMS";
            this.toolStripStatusLabelAvg_ZMS.Text = "Среднее: 0.00 ₽";
            // toolStripStatusLabelMin_ZMS
            this.toolStripStatusLabelMin_ZMS.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabelMin_ZMS.Name = "toolStripStatusLabelMin_ZMS";
            this.toolStripStatusLabelMin_ZMS.Text = "Min: 0.00 ₽";
            // toolStripStatusLabelMax_ZMS
            this.toolStripStatusLabelMax_ZMS.Name = "toolStripStatusLabelMax_ZMS";
            this.toolStripStatusLabelMax_ZMS.Text = "Max: 0.00 ₽";
            // FormMain
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1100, 604);
            this.Controls.Add(this.dataGridViewOrders_ZMS);
            this.Controls.Add(this.statusStripMain_ZMS);
            this.Controls.Add(this.toolStripMain_ZMS);
            this.Controls.Add(this.menuStripMain_ZMS);
            this.MainMenuStrip = this.menuStripMain_ZMS;
            this.MinimumSize = new System.Drawing.Size(800, 500);
            this.Name = "FormMain";
            this.Text = "Система управления заказами — Зайцев М.С.";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStripMain_ZMS.ResumeLayout(false);
            this.menuStripMain_ZMS.PerformLayout();
            this.toolStripMain_ZMS.ResumeLayout(false);
            this.toolStripMain_ZMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewOrders_ZMS)).EndInit();
            this.statusStripMain_ZMS.ResumeLayout(false);
            this.statusStripMain_ZMS.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain_ZMS;
        private System.Windows.Forms.ToolStripMenuItem menuItemData_ZMS;
        private System.Windows.Forms.ToolStripMenuItem menuItemAddOrder_ZMS;
        private System.Windows.Forms.ToolStripMenuItem menuItemEditOrder_ZMS;
        private System.Windows.Forms.ToolStripMenuItem menuItemDeleteOrder_ZMS;
        private System.Windows.Forms.ToolStripSeparator menuItemSeparator1_ZMS;
        private System.Windows.Forms.ToolStripMenuItem menuItemClients_ZMS;
        private System.Windows.Forms.ToolStripMenuItem menuItemView_ZMS;
        private System.Windows.Forms.ToolStripMenuItem menuItemStats_ZMS;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelp_ZMS;
        private System.Windows.Forms.ToolStripMenuItem menuItemHelpContent_ZMS;
        private System.Windows.Forms.ToolStripMenuItem menuItemAbout_ZMS;
        private System.Windows.Forms.ToolStrip toolStripMain_ZMS;
        private System.Windows.Forms.ToolStripButton toolStripButtonAddOrder_ZMS;
        private System.Windows.Forms.ToolStripButton toolStripButtonEditOrder_ZMS;
        private System.Windows.Forms.ToolStripButton toolStripButtonDeleteOrder_ZMS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1_ZMS;
        private System.Windows.Forms.ToolStripButton toolStripButtonStats_ZMS;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2_ZMS;
        private System.Windows.Forms.ToolStripLabel toolStripLabelSearch_ZMS;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBoxSearch_ZMS;
        private System.Windows.Forms.DataGridView dataGridViewOrders_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderNumber_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClientName_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colOrderDate_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colProductName_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPrice_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colQuantity_ZMS;
        private System.Windows.Forms.DataGridViewTextBoxColumn colTotalCost_ZMS;
        private System.Windows.Forms.StatusStrip statusStripMain_ZMS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelCount_ZMS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelSum_ZMS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelAvg_ZMS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMin_ZMS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabelMax_ZMS;
    }
}