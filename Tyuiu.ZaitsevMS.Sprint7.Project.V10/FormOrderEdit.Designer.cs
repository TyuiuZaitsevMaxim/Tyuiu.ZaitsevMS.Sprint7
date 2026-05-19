namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    partial class FormOrderEdit
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
            this.groupBoxOrderData_ZMS = new System.Windows.Forms.GroupBox();
            this.labelOrderNumber_ZMS = new System.Windows.Forms.Label();
            this.textBoxOrderNumber_ZMS = new System.Windows.Forms.TextBox();
            this.labelClient_ZMS = new System.Windows.Forms.Label();
            this.comboBoxClient_ZMS = new System.Windows.Forms.ComboBox();
            this.labelOrderDate_ZMS = new System.Windows.Forms.Label();
            this.dateTimePickerOrderDate_ZMS = new System.Windows.Forms.DateTimePicker();
            this.labelProductName_ZMS = new System.Windows.Forms.Label();
            this.textBoxProductName_ZMS = new System.Windows.Forms.TextBox();
            this.labelPrice_ZMS = new System.Windows.Forms.Label();
            this.numericUpDownPrice_ZMS = new System.Windows.Forms.NumericUpDown();
            this.labelQuantity_ZMS = new System.Windows.Forms.Label();
            this.numericUpDownQuantity_ZMS = new System.Windows.Forms.NumericUpDown();
            this.labelTotalCostValue_ZMS = new System.Windows.Forms.Label();
            this.labelTotalCostCaption_ZMS = new System.Windows.Forms.Label();
            this.buttonSaveOrder_ZMS = new System.Windows.Forms.Button();
            this.buttonCancelOrder_ZMS = new System.Windows.Forms.Button();
            this.groupBoxOrderData_ZMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice_ZMS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity_ZMS)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxOrderData_ZMS
            // 
            this.groupBoxOrderData_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBoxOrderData_ZMS.Controls.Add(this.labelOrderNumber_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.textBoxOrderNumber_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.labelClient_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.comboBoxClient_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.labelOrderDate_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.dateTimePickerOrderDate_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.labelProductName_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.textBoxProductName_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.labelPrice_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.numericUpDownPrice_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.labelQuantity_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.numericUpDownQuantity_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.labelTotalCostCaption_ZMS);
            this.groupBoxOrderData_ZMS.Controls.Add(this.labelTotalCostValue_ZMS);
            this.groupBoxOrderData_ZMS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxOrderData_ZMS.Name = "groupBoxOrderData_ZMS";
            this.groupBoxOrderData_ZMS.Size = new System.Drawing.Size(460, 290);
            this.groupBoxOrderData_ZMS.TabIndex = 0;
            this.groupBoxOrderData_ZMS.TabStop = false;
            this.groupBoxOrderData_ZMS.Text = "Данные заказа";
            // 
            // labelOrderNumber_ZMS
            // 
            this.labelOrderNumber_ZMS.Location = new System.Drawing.Point(12, 28);
            this.labelOrderNumber_ZMS.Name = "labelOrderNumber_ZMS";
            this.labelOrderNumber_ZMS.Size = new System.Drawing.Size(130, 20);
            this.labelOrderNumber_ZMS.Text = "Номер заказа:";
            // 
            // textBoxOrderNumber_ZMS
            // 
            this.textBoxOrderNumber_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxOrderNumber_ZMS.Location = new System.Drawing.Point(148, 25);
            this.textBoxOrderNumber_ZMS.Name = "textBoxOrderNumber_ZMS";
            this.textBoxOrderNumber_ZMS.Size = new System.Drawing.Size(300, 20);
            this.textBoxOrderNumber_ZMS.TabIndex = 0;
            // 
            // labelClient_ZMS
            // 
            this.labelClient_ZMS.Location = new System.Drawing.Point(12, 60);
            this.labelClient_ZMS.Name = "labelClient_ZMS";
            this.labelClient_ZMS.Size = new System.Drawing.Size(130, 20);
            this.labelClient_ZMS.Text = "Клиент:";
            // 
            // comboBoxClient_ZMS
            // 
            this.comboBoxClient_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.comboBoxClient_ZMS.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxClient_ZMS.Location = new System.Drawing.Point(148, 57);
            this.comboBoxClient_ZMS.Name = "comboBoxClient_ZMS";
            this.comboBoxClient_ZMS.Size = new System.Drawing.Size(300, 21);
            this.comboBoxClient_ZMS.TabIndex = 1;
            // 
            // labelOrderDate_ZMS
            // 
            this.labelOrderDate_ZMS.Location = new System.Drawing.Point(12, 95);
            this.labelOrderDate_ZMS.Name = "labelOrderDate_ZMS";
            this.labelOrderDate_ZMS.Size = new System.Drawing.Size(130, 20);
            this.labelOrderDate_ZMS.Text = "Дата исполнения:";
            // 
            // dateTimePickerOrderDate_ZMS
            // 
            this.dateTimePickerOrderDate_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.dateTimePickerOrderDate_ZMS.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerOrderDate_ZMS.Location = new System.Drawing.Point(148, 92);
            this.dateTimePickerOrderDate_ZMS.Name = "dateTimePickerOrderDate_ZMS";
            this.dateTimePickerOrderDate_ZMS.Size = new System.Drawing.Size(300, 20);
            this.dateTimePickerOrderDate_ZMS.TabIndex = 2;
            // 
            // labelProductName_ZMS
            // 
            this.labelProductName_ZMS.Location = new System.Drawing.Point(12, 130);
            this.labelProductName_ZMS.Name = "labelProductName_ZMS";
            this.labelProductName_ZMS.Size = new System.Drawing.Size(130, 20);
            this.labelProductName_ZMS.Text = "Название товара:";
            // 
            // textBoxProductName_ZMS
            // 
            this.textBoxProductName_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.textBoxProductName_ZMS.Location = new System.Drawing.Point(148, 127);
            this.textBoxProductName_ZMS.Name = "textBoxProductName_ZMS";
            this.textBoxProductName_ZMS.Size = new System.Drawing.Size(300, 20);
            this.textBoxProductName_ZMS.TabIndex = 3;
            // 
            // labelPrice_ZMS
            // 
            this.labelPrice_ZMS.Location = new System.Drawing.Point(12, 165);
            this.labelPrice_ZMS.Name = "labelPrice_ZMS";
            this.labelPrice_ZMS.Size = new System.Drawing.Size(130, 20);
            this.labelPrice_ZMS.Text = "Цена (₽):";
            // 
            // numericUpDownPrice_ZMS
            // 
            this.numericUpDownPrice_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownPrice_ZMS.DecimalPlaces = 2;
            this.numericUpDownPrice_ZMS.Location = new System.Drawing.Point(148, 162);
            this.numericUpDownPrice_ZMS.Maximum = new decimal(new int[] { 10000000, 0, 0, 0 });
            this.numericUpDownPrice_ZMS.Name = "numericUpDownPrice_ZMS";
            this.numericUpDownPrice_ZMS.Size = new System.Drawing.Size(300, 20);
            this.numericUpDownPrice_ZMS.TabIndex = 4;
            this.numericUpDownPrice_ZMS.ValueChanged += new System.EventHandler(this.numericUpDownPrice_ZMS_ValueChanged);
            // 
            // labelQuantity_ZMS
            // 
            this.labelQuantity_ZMS.Location = new System.Drawing.Point(12, 200);
            this.labelQuantity_ZMS.Name = "labelQuantity_ZMS";
            this.labelQuantity_ZMS.Size = new System.Drawing.Size(130, 20);
            this.labelQuantity_ZMS.Text = "Количество:";
            // 
            // numericUpDownQuantity_ZMS
            // 
            this.numericUpDownQuantity_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.numericUpDownQuantity_ZMS.Location = new System.Drawing.Point(148, 197);
            this.numericUpDownQuantity_ZMS.Maximum = new decimal(new int[] { 100000, 0, 0, 0 });
            this.numericUpDownQuantity_ZMS.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownQuantity_ZMS.Name = "numericUpDownQuantity_ZMS";
            this.numericUpDownQuantity_ZMS.Size = new System.Drawing.Size(300, 20);
            this.numericUpDownQuantity_ZMS.TabIndex = 5;
            this.numericUpDownQuantity_ZMS.Value = new decimal(new int[] { 1, 0, 0, 0 });
            this.numericUpDownQuantity_ZMS.ValueChanged += new System.EventHandler(this.numericUpDownQuantity_ZMS_ValueChanged);
            // 
            // labelTotalCostCaption_ZMS
            // 
            this.labelTotalCostCaption_ZMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelTotalCostCaption_ZMS.Location = new System.Drawing.Point(12, 250);
            this.labelTotalCostCaption_ZMS.Name = "labelTotalCostCaption_ZMS";
            this.labelTotalCostCaption_ZMS.Size = new System.Drawing.Size(130, 20);
            this.labelTotalCostCaption_ZMS.Text = "Итого:";
            // 
            // labelTotalCostValue_ZMS
            // 
            this.labelTotalCostValue_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) | System.Windows.Forms.AnchorStyles.Right)));
            this.labelTotalCostValue_ZMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelTotalCostValue_ZMS.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelTotalCostValue_ZMS.Location = new System.Drawing.Point(148, 250);
            this.labelTotalCostValue_ZMS.Name = "labelTotalCostValue_ZMS";
            this.labelTotalCostValue_ZMS.Size = new System.Drawing.Size(300, 20);
            this.labelTotalCostValue_ZMS.Text = "0.00 ₽";
            // 
            // buttonSaveOrder_ZMS
            // 
            this.buttonSaveOrder_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonSaveOrder_ZMS.Location = new System.Drawing.Point(280, 315);
            this.buttonSaveOrder_ZMS.Name = "buttonSaveOrder_ZMS";
            this.buttonSaveOrder_ZMS.Size = new System.Drawing.Size(90, 30);
            this.buttonSaveOrder_ZMS.TabIndex = 6;
            this.buttonSaveOrder_ZMS.Text = "Сохранить";
            this.buttonSaveOrder_ZMS.UseVisualStyleBackColor = true;
            this.buttonSaveOrder_ZMS.Click += new System.EventHandler(this.buttonSaveOrder_ZMS_Click);
            // 
            // buttonCancelOrder_ZMS
            // 
            this.buttonCancelOrder_ZMS.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonCancelOrder_ZMS.Location = new System.Drawing.Point(382, 315);
            this.buttonCancelOrder_ZMS.Name = "buttonCancelOrder_ZMS";
            this.buttonCancelOrder_ZMS.Size = new System.Drawing.Size(90, 30);
            this.buttonCancelOrder_ZMS.TabIndex = 7;
            this.buttonCancelOrder_ZMS.Text = "Отмена";
            this.buttonCancelOrder_ZMS.UseVisualStyleBackColor = true;
            this.buttonCancelOrder_ZMS.Click += new System.EventHandler(this.buttonCancelOrder_ZMS_Click);
            // 
            // FormOrderEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 357);
            this.Controls.Add(this.buttonCancelOrder_ZMS);
            this.Controls.Add(this.buttonSaveOrder_ZMS);
            this.Controls.Add(this.groupBoxOrderData_ZMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOrderEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Заказ";
            this.groupBoxOrderData_ZMS.ResumeLayout(false);
            this.groupBoxOrderData_ZMS.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownPrice_ZMS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownQuantity_ZMS)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxOrderData_ZMS;
        private System.Windows.Forms.Label labelOrderNumber_ZMS;
        private System.Windows.Forms.TextBox textBoxOrderNumber_ZMS;
        private System.Windows.Forms.Label labelClient_ZMS;
        private System.Windows.Forms.ComboBox comboBoxClient_ZMS;
        private System.Windows.Forms.Label labelOrderDate_ZMS;
        private System.Windows.Forms.DateTimePicker dateTimePickerOrderDate_ZMS;
        private System.Windows.Forms.Label labelProductName_ZMS;
        private System.Windows.Forms.TextBox textBoxProductName_ZMS;
        private System.Windows.Forms.Label labelPrice_ZMS;
        private System.Windows.Forms.NumericUpDown numericUpDownPrice_ZMS;
        private System.Windows.Forms.Label labelQuantity_ZMS;
        private System.Windows.Forms.NumericUpDown numericUpDownQuantity_ZMS;
        private System.Windows.Forms.Label labelTotalCostCaption_ZMS;
        private System.Windows.Forms.Label labelTotalCostValue_ZMS;
        private System.Windows.Forms.Button buttonSaveOrder_ZMS;
        private System.Windows.Forms.Button buttonCancelOrder_ZMS;
    }
}