namespace Tyuiu.ZaitsevMS.Sprint7.Project.V10
{
    partial class FormHelp
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
            this.richTextBoxHelp_ZMS = new System.Windows.Forms.RichTextBox();
            this.buttonCloseHelp_ZMS = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // richTextBoxHelp_ZMS
            this.richTextBoxHelp_ZMS.Anchor =
                System.Windows.Forms.AnchorStyles.Top |
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Left |
                System.Windows.Forms.AnchorStyles.Right;
            this.richTextBoxHelp_ZMS.BackColor = System.Drawing.SystemColors.Window;
            this.richTextBoxHelp_ZMS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBoxHelp_ZMS.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxHelp_ZMS.Name = "richTextBoxHelp_ZMS";
            this.richTextBoxHelp_ZMS.ReadOnly = true;
            this.richTextBoxHelp_ZMS.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.richTextBoxHelp_ZMS.Size = new System.Drawing.Size(660, 510);
            this.richTextBoxHelp_ZMS.TabIndex = 0;
            this.richTextBoxHelp_ZMS.Text = "";
            // buttonCloseHelp_ZMS
            this.buttonCloseHelp_ZMS.Anchor =
                System.Windows.Forms.AnchorStyles.Bottom |
                System.Windows.Forms.AnchorStyles.Right;
            this.buttonCloseHelp_ZMS.Location = new System.Drawing.Point(572, 534);
            this.buttonCloseHelp_ZMS.Name = "buttonCloseHelp_ZMS";
            this.buttonCloseHelp_ZMS.Size = new System.Drawing.Size(100, 30);
            this.buttonCloseHelp_ZMS.TabIndex = 1;
            this.buttonCloseHelp_ZMS.Text = "Закрыть";
            this.buttonCloseHelp_ZMS.UseVisualStyleBackColor = true;
            this.buttonCloseHelp_ZMS.Click += new System.EventHandler(this.buttonCloseHelp_ZMS_Click);
            // FormHelp
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(684, 576);
            this.Controls.Add(this.buttonCloseHelp_ZMS);
            this.Controls.Add(this.richTextBoxHelp_ZMS);
            this.MinimumSize = new System.Drawing.Size(500, 450);
            this.Name = "FormHelp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Руководство пользователя";
            this.ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxHelp_ZMS;
        private System.Windows.Forms.Button buttonCloseHelp_ZMS;
    }
}