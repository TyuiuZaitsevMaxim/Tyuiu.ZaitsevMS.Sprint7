namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    partial class FormStats
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea_ZMS =
                new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend_ZMS =
                new System.Windows.Forms.DataVisualization.Charting.Legend();

            this.groupBoxStatsSummary_ZMS = new System.Windows.Forms.GroupBox();
            this.labelCountCaption_ZMS = new System.Windows.Forms.Label();
            this.labelCountValue_ZMS = new System.Windows.Forms.Label();
            this.labelSumCaption_ZMS = new System.Windows.Forms.Label();
            this.labelSumValue_ZMS = new System.Windows.Forms.Label();
            this.labelAverageCaption_ZMS = new System.Windows.Forms.Label();
            this.labelAverageValue_ZMS = new System.Windows.Forms.Label();
            this.labelMinCaption_ZMS = new System.Windows.Forms.Label();
            this.labelMinValue_ZMS = new System.Windows.Forms.Label();
            this.labelMaxCaption_ZMS = new System.Windows.Forms.Label();
            this.labelMaxValue_ZMS = new System.Windows.Forms.Label();
            this.labelTopClientCaption_ZMS = new System.Windows.Forms.Label();
            this.labelTopClientValue_ZMS = new System.Windows.Forms.Label();
            this.chartOrdersByClient_ZMS = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.buttonCloseStats_ZMS = new System.Windows.Forms.Button();

            this.groupBoxStatsSummary_ZMS.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartOrdersByClient_ZMS)).BeginInit();
            this.SuspendLayout();

            // ── groupBoxStatsSummary_ZMS ──────────────────────────────
            this.groupBoxStatsSummary_ZMS.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelCountCaption_ZMS);
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelCountValue_ZMS);
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelSumCaption_ZMS);
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelSumValue_ZMS);
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelAverageCaption_ZMS);
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelAverageValue_ZMS);
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelMinCaption_ZMS);
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelMinValue_ZMS);
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelMaxCaption_ZMS);
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelMaxValue_ZMS);
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelTopClientCaption_ZMS);
            this.groupBoxStatsSummary_ZMS.Controls.Add(this.labelTopClientValue_ZMS);
            this.groupBoxStatsSummary_ZMS.Location = new System.Drawing.Point(12, 12);
            this.groupBoxStatsSummary_ZMS.Name = "groupBoxStatsSummary_ZMS";
            this.groupBoxStatsSummary_ZMS.Size = new System.Drawing.Size(760, 170);
            this.groupBoxStatsSummary_ZMS.TabIndex = 0;
            this.groupBoxStatsSummary_ZMS.TabStop = false;
            this.groupBoxStatsSummary_ZMS.Text = "Сводная статистика по заказам";

            // ── Количество ───────────────────────────────────────────
            this.labelCountCaption_ZMS.Location = new System.Drawing.Point(16, 30);
            this.labelCountCaption_ZMS.Name = "labelCountCaption_ZMS";
            this.labelCountCaption_ZMS.Size = new System.Drawing.Size(160, 20);
            this.labelCountCaption_ZMS.Text = "Количество заказов:";

            this.labelCountValue_ZMS.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelCountValue_ZMS.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelCountValue_ZMS.Location = new System.Drawing.Point(180, 30);
            this.labelCountValue_ZMS.Name = "labelCountValue_ZMS";
            this.labelCountValue_ZMS.Size = new System.Drawing.Size(200, 20);
            this.labelCountValue_ZMS.Text = "0";

            // ── Сумма ────────────────────────────────────────────────
            this.labelSumCaption_ZMS.Location = new System.Drawing.Point(16, 60);
            this.labelSumCaption_ZMS.Name = "labelSumCaption_ZMS";
            this.labelSumCaption_ZMS.Size = new System.Drawing.Size(160, 20);
            this.labelSumCaption_ZMS.Text = "Общая сумма:";

            this.labelSumValue_ZMS.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelSumValue_ZMS.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelSumValue_ZMS.Location = new System.Drawing.Point(180, 60);
            this.labelSumValue_ZMS.Name = "labelSumValue_ZMS";
            this.labelSumValue_ZMS.Size = new System.Drawing.Size(200, 20);
            this.labelSumValue_ZMS.Text = "0.00 ₽";

            // ── Среднее ──────────────────────────────────────────────
            this.labelAverageCaption_ZMS.Location = new System.Drawing.Point(16, 90);
            this.labelAverageCaption_ZMS.Name = "labelAverageCaption_ZMS";
            this.labelAverageCaption_ZMS.Size = new System.Drawing.Size(160, 20);
            this.labelAverageCaption_ZMS.Text = "Среднее:";

            this.labelAverageValue_ZMS.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelAverageValue_ZMS.Location = new System.Drawing.Point(180, 90);
            this.labelAverageValue_ZMS.Name = "labelAverageValue_ZMS";
            this.labelAverageValue_ZMS.Size = new System.Drawing.Size(200, 20);
            this.labelAverageValue_ZMS.Text = "0.00 ₽";

            // ── Min ──────────────────────────────────────────────────
            this.labelMinCaption_ZMS.Location = new System.Drawing.Point(400, 30);
            this.labelMinCaption_ZMS.Name = "labelMinCaption_ZMS";
            this.labelMinCaption_ZMS.Size = new System.Drawing.Size(130, 20);
            this.labelMinCaption_ZMS.Text = "Минимальная:";

            this.labelMinValue_ZMS.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelMinValue_ZMS.ForeColor = System.Drawing.Color.DarkOrange;
            this.labelMinValue_ZMS.Location = new System.Drawing.Point(534, 30);
            this.labelMinValue_ZMS.Name = "labelMinValue_ZMS";
            this.labelMinValue_ZMS.Size = new System.Drawing.Size(200, 20);
            this.labelMinValue_ZMS.Text = "0.00 ₽";

            // ── Max ──────────────────────────────────────────────────
            this.labelMaxCaption_ZMS.Location = new System.Drawing.Point(400, 60);
            this.labelMaxCaption_ZMS.Name = "labelMaxCaption_ZMS";
            this.labelMaxCaption_ZMS.Size = new System.Drawing.Size(130, 20);
            this.labelMaxCaption_ZMS.Text = "Максимальная:";

            this.labelMaxValue_ZMS.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelMaxValue_ZMS.ForeColor = System.Drawing.Color.DarkRed;
            this.labelMaxValue_ZMS.Location = new System.Drawing.Point(534, 60);
            this.labelMaxValue_ZMS.Name = "labelMaxValue_ZMS";
            this.labelMaxValue_ZMS.Size = new System.Drawing.Size(200, 20);
            this.labelMaxValue_ZMS.Text = "0.00 ₽";

            // ── Топ-клиент ───────────────────────────────────────────
            this.labelTopClientCaption_ZMS.Location = new System.Drawing.Point(16, 130);
            this.labelTopClientCaption_ZMS.Name = "labelTopClientCaption_ZMS";
            this.labelTopClientCaption_ZMS.Size = new System.Drawing.Size(160, 20);
            this.labelTopClientCaption_ZMS.Text = "Лучший клиент:";

            this.labelTopClientValue_ZMS.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
            this.labelTopClientValue_ZMS.ForeColor = System.Drawing.Color.Purple;
            this.labelTopClientValue_ZMS.Location = new System.Drawing.Point(180, 130);
            this.labelTopClientValue_ZMS.Name = "labelTopClientValue_ZMS";
            this.labelTopClientValue_ZMS.Size = new System.Drawing.Size(560, 20);
            this.labelTopClientValue_ZMS.Text = "—";

            // ── chartOrdersByClient_ZMS ───────────────────────────────
            chartArea_ZMS.Name = "ChartArea_ZMS";
            this.chartOrdersByClient_ZMS.ChartAreas.Add(chartArea_ZMS);
            legend_ZMS.Name = "Legend_ZMS";
            this.chartOrdersByClient_ZMS.Legends.Add(legend_ZMS);
            this.chartOrdersByClient_ZMS.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.chartOrdersByClient_ZMS.Location = new System.Drawing.Point(12, 192);
            this.chartOrdersByClient_ZMS.Name = "chartOrdersByClient_ZMS";
            this.chartOrdersByClient_ZMS.Size = new System.Drawing.Size(760, 380);
            this.chartOrdersByClient_ZMS.TabIndex = 1;
            this.chartOrdersByClient_ZMS.Text = "Гистограмма заказов";

            // ── buttonCloseStats_ZMS ─────────────────────────────────
            this.buttonCloseStats_ZMS.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;
            this.buttonCloseStats_ZMS.Location = new System.Drawing.Point(672, 586);
            this.buttonCloseStats_ZMS.Name = "buttonCloseStats_ZMS";
            this.buttonCloseStats_ZMS.Size = new System.Drawing.Size(100, 30);
            this.buttonCloseStats_ZMS.TabIndex = 2;
            this.buttonCloseStats_ZMS.Text = "Закрыть";
            this.buttonCloseStats_ZMS.UseVisualStyleBackColor = true;
            this.buttonCloseStats_ZMS.Click += new System.EventHandler(this.buttonCloseStats_ZMS_Click);

            // ── FormStats ────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 628);
            this.Controls.Add(this.buttonCloseStats_ZMS);
            this.Controls.Add(this.chartOrdersByClient_ZMS);
            this.Controls.Add(this.groupBoxStatsSummary_ZMS);
            this.MinimumSize = new System.Drawing.Size(700, 580);
            this.Name = "FormStats";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Статистика заказов";

            this.groupBoxStatsSummary_ZMS.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartOrdersByClient_ZMS)).EndInit();
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxStatsSummary_ZMS;
        private System.Windows.Forms.Label labelCountCaption_ZMS;
        private System.Windows.Forms.Label labelCountValue_ZMS;
        private System.Windows.Forms.Label labelSumCaption_ZMS;
        private System.Windows.Forms.Label labelSumValue_ZMS;
        private System.Windows.Forms.Label labelAverageCaption_ZMS;
        private System.Windows.Forms.Label labelAverageValue_ZMS;
        private System.Windows.Forms.Label labelMinCaption_ZMS;
        private System.Windows.Forms.Label labelMinValue_ZMS;
        private System.Windows.Forms.Label labelMaxCaption_ZMS;
        private System.Windows.Forms.Label labelMaxValue_ZMS;
        private System.Windows.Forms.Label labelTopClientCaption_ZMS;
        private System.Windows.Forms.Label labelTopClientValue_ZMS;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartOrdersByClient_ZMS;
        private System.Windows.Forms.Button buttonCloseStats_ZMS;
    }
}