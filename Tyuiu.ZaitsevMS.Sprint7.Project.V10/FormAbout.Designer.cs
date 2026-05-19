namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    partial class FormAbout
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
            this.pictureBoxLogo_ZMS = new System.Windows.Forms.PictureBox();
            this.labelAppTitle_ZMS = new System.Windows.Forms.Label();
            this.labelAppVersion_ZMS = new System.Windows.Forms.Label();
            this.labelAppDescription_ZMS = new System.Windows.Forms.Label();
            this.groupBoxAuthorInfo_ZMS = new System.Windows.Forms.GroupBox();
            this.labelAuthorCaption_ZMS = new System.Windows.Forms.Label();
            this.labelAuthorValue_ZMS = new System.Windows.Forms.Label();
            this.labelGroupCaption_ZMS = new System.Windows.Forms.Label();
            this.labelGroupValue_ZMS = new System.Windows.Forms.Label();
            this.labelYearCaption_ZMS = new System.Windows.Forms.Label();
            this.labelYearValue_ZMS = new System.Windows.Forms.Label();
            this.labelTechCaption_ZMS = new System.Windows.Forms.Label();
            this.labelTechValue_ZMS = new System.Windows.Forms.Label();
            this.buttonCloseAbout_ZMS = new System.Windows.Forms.Button();

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_ZMS)).BeginInit();
            this.groupBoxAuthorInfo_ZMS.SuspendLayout();
            this.SuspendLayout();

            // ── pictureBoxLogo_ZMS ────────────────────────────────────
            this.pictureBoxLogo_ZMS.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBoxLogo_ZMS.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxLogo_ZMS.Name = "pictureBoxLogo_ZMS";
            this.pictureBoxLogo_ZMS.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxLogo_ZMS.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxLogo_ZMS.TabStop = false;

            // ── labelAppTitle_ZMS ─────────────────────────────────────
            this.labelAppTitle_ZMS.AutoSize = false;
            this.labelAppTitle_ZMS.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.labelAppTitle_ZMS.ForeColor = System.Drawing.Color.DarkBlue;
            this.labelAppTitle_ZMS.Location = new System.Drawing.Point(86, 12);
            this.labelAppTitle_ZMS.Name = "labelAppTitle_ZMS";
            this.labelAppTitle_ZMS.Size = new System.Drawing.Size(370, 28);
            this.labelAppTitle_ZMS.Text = "Система управления заказами";

            // ── labelAppVersion_ZMS ───────────────────────────────────
            this.labelAppVersion_ZMS.AutoSize = false;
            this.labelAppVersion_ZMS.ForeColor = System.Drawing.Color.Gray;
            this.labelAppVersion_ZMS.Location = new System.Drawing.Point(88, 44);
            this.labelAppVersion_ZMS.Name = "labelAppVersion_ZMS";
            this.labelAppVersion_ZMS.Size = new System.Drawing.Size(370, 18);
            this.labelAppVersion_ZMS.Text = "Версия 1.0  |  Вариант 10";

            // ── labelAppDescription_ZMS ───────────────────────────────
            this.labelAppDescription_ZMS.AutoSize = false;
            this.labelAppDescription_ZMS.Location = new System.Drawing.Point(88, 66);
            this.labelAppDescription_ZMS.Name = "labelAppDescription_ZMS";
            this.labelAppDescription_ZMS.Size = new System.Drawing.Size(370, 18);
            this.labelAppDescription_ZMS.Text = "Учёт клиентов и заказов с хранением данных в CSV";

            // ── groupBoxAuthorInfo_ZMS ────────────────────────────────
            this.groupBoxAuthorInfo_ZMS.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.groupBoxAuthorInfo_ZMS.Controls.Add(this.labelAuthorCaption_ZMS);
            this.groupBoxAuthorInfo_ZMS.Controls.Add(this.labelAuthorValue_ZMS);
            this.groupBoxAuthorInfo_ZMS.Controls.Add(this.labelGroupCaption_ZMS);
            this.groupBoxAuthorInfo_ZMS.Controls.Add(this.labelGroupValue_ZMS);
            this.groupBoxAuthorInfo_ZMS.Controls.Add(this.labelYearCaption_ZMS);
            this.groupBoxAuthorInfo_ZMS.Controls.Add(this.labelYearValue_ZMS);
            this.groupBoxAuthorInfo_ZMS.Controls.Add(this.labelTechCaption_ZMS);
            this.groupBoxAuthorInfo_ZMS.Controls.Add(this.labelTechValue_ZMS);
            this.groupBoxAuthorInfo_ZMS.Location = new System.Drawing.Point(12, 90);
            this.groupBoxAuthorInfo_ZMS.Name = "groupBoxAuthorInfo_ZMS";
            this.groupBoxAuthorInfo_ZMS.Size = new System.Drawing.Size(460, 155);
            this.groupBoxAuthorInfo_ZMS.TabIndex = 0;
            this.groupBoxAuthorInfo_ZMS.TabStop = false;
            this.groupBoxAuthorInfo_ZMS.Text = "Сведения о разработчике";

            // Автор
            this.labelAuthorCaption_ZMS.Location = new System.Drawing.Point(12, 28);
            this.labelAuthorCaption_ZMS.Name = "labelAuthorCaption_ZMS";
            this.labelAuthorCaption_ZMS.Size = new System.Drawing.Size(140, 20);
            this.labelAuthorCaption_ZMS.Text = "Разработчик:";

            this.labelAuthorValue_ZMS.Font = new System.Drawing.Font(
                "Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
            this.labelAuthorValue_ZMS.Location = new System.Drawing.Point(156, 28);
            this.labelAuthorValue_ZMS.Name = "labelAuthorValue_ZMS";
            this.labelAuthorValue_ZMS.Size = new System.Drawing.Size(290, 20);
            this.labelAuthorValue_ZMS.Text = "Зайцев М. С.";

            // Группа
            this.labelGroupCaption_ZMS.Location = new System.Drawing.Point(12, 58);
            this.labelGroupCaption_ZMS.Name = "labelGroupCaption_ZMS";
            this.labelGroupCaption_ZMS.Size = new System.Drawing.Size(140, 20);
            this.labelGroupCaption_ZMS.Text = "Учебная группа:";

            this.labelGroupValue_ZMS.Location = new System.Drawing.Point(156, 58);
            this.labelGroupValue_ZMS.Name = "labelGroupValue_ZMS";
            this.labelGroupValue_ZMS.Size = new System.Drawing.Size(290, 20);
            this.labelGroupValue_ZMS.Text = "Tyuiu — Sprint 7, Вариант 10";

            // Год
            this.labelYearCaption_ZMS.Location = new System.Drawing.Point(12, 88);
            this.labelYearCaption_ZMS.Name = "labelYearCaption_ZMS";
            this.labelYearCaption_ZMS.Size = new System.Drawing.Size(140, 20);
            this.labelYearCaption_ZMS.Text = "Год разработки:";

            this.labelYearValue_ZMS.Location = new System.Drawing.Point(156, 88);
            this.labelYearValue_ZMS.Name = "labelYearValue_ZMS";
            this.labelYearValue_ZMS.Size = new System.Drawing.Size(290, 20);
            this.labelYearValue_ZMS.Text = "2025";

            // Технологии
            this.labelTechCaption_ZMS.Location = new System.Drawing.Point(12, 118);
            this.labelTechCaption_ZMS.Name = "labelTechCaption_ZMS";
            this.labelTechCaption_ZMS.Size = new System.Drawing.Size(140, 20);
            this.labelTechCaption_ZMS.Text = "Технологии:";

            this.labelTechValue_ZMS.Location = new System.Drawing.Point(156, 118);
            this.labelTechValue_ZMS.Name = "labelTechValue_ZMS";
            this.labelTechValue_ZMS.Size = new System.Drawing.Size(290, 20);
            this.labelTechValue_ZMS.Text = "C# · WinForms · CSV · MSTest";

            // ── buttonCloseAbout_ZMS ──────────────────────────────────
            this.buttonCloseAbout_ZMS.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;
            this.buttonCloseAbout_ZMS.Location = new System.Drawing.Point(370, 260);
            this.buttonCloseAbout_ZMS.Name = "buttonCloseAbout_ZMS";
            this.buttonCloseAbout_ZMS.Size = new System.Drawing.Size(100, 30);
            this.buttonCloseAbout_ZMS.TabIndex = 1;
            this.buttonCloseAbout_ZMS.Text = "Закрыть";
            this.buttonCloseAbout_ZMS.UseVisualStyleBackColor = true;
            this.buttonCloseAbout_ZMS.Click += new System.EventHandler(this.buttonCloseAbout_ZMS_Click);

            // ── FormAbout ─────────────────────────────────────────────
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 302);
            this.Controls.Add(this.buttonCloseAbout_ZMS);
            this.Controls.Add(this.groupBoxAuthorInfo_ZMS);
            this.Controls.Add(this.labelAppDescription_ZMS);
            this.Controls.Add(this.labelAppVersion_ZMS);
            this.Controls.Add(this.labelAppTitle_ZMS);
            this.Controls.Add(this.pictureBoxLogo_ZMS);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormAbout";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "О программе";

            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogo_ZMS)).EndInit();
            this.groupBoxAuthorInfo_ZMS.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxLogo_ZMS;
        private System.Windows.Forms.Label labelAppTitle_ZMS;
        private System.Windows.Forms.Label labelAppVersion_ZMS;
        private System.Windows.Forms.Label labelAppDescription_ZMS;
        private System.Windows.Forms.GroupBox groupBoxAuthorInfo_ZMS;
        private System.Windows.Forms.Label labelAuthorCaption_ZMS;
        private System.Windows.Forms.Label labelAuthorValue_ZMS;
        private System.Windows.Forms.Label labelGroupCaption_ZMS;
        private System.Windows.Forms.Label labelGroupValue_ZMS;
        private System.Windows.Forms.Label labelYearCaption_ZMS;
        private System.Windows.Forms.Label labelYearValue_ZMS;
        private System.Windows.Forms.Label labelTechCaption_ZMS;
        private System.Windows.Forms.Label labelTechValue_ZMS;
        private System.Windows.Forms.Button buttonCloseAbout_ZMS;
    }
}