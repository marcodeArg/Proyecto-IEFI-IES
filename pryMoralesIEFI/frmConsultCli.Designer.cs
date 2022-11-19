namespace pryMoralesIEFI
{
    partial class frmConsultCli
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblSelec = new System.Windows.Forms.Label();
            this.lstSelec = new System.Windows.Forms.ComboBox();
            this.cbInfo = new System.Windows.Forms.GroupBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.txtActivity = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.cbInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSelec
            // 
            this.lblSelec.AutoSize = true;
            this.lblSelec.Location = new System.Drawing.Point(36, 46);
            this.lblSelec.Name = "lblSelec";
            this.lblSelec.Size = new System.Drawing.Size(112, 20);
            this.lblSelec.TabIndex = 0;
            this.lblSelec.Text = "DNI del cliente";
            // 
            // lstSelec
            // 
            this.lstSelec.FormattingEnabled = true;
            this.lstSelec.Location = new System.Drawing.Point(176, 43);
            this.lstSelec.Name = "lstSelec";
            this.lstSelec.Size = new System.Drawing.Size(245, 28);
            this.lstSelec.TabIndex = 1;
            this.lstSelec.SelectionChangeCommitted += new System.EventHandler(this.lstSelec_SelectionChangeCommitted);
            // 
            // cbInfo
            // 
            this.cbInfo.Controls.Add(this.txtBalance);
            this.cbInfo.Controls.Add(this.txtActivity);
            this.cbInfo.Controls.Add(this.txtName);
            this.cbInfo.Controls.Add(this.lblBalance);
            this.cbInfo.Controls.Add(this.lblActivity);
            this.cbInfo.Controls.Add(this.lblName);
            this.cbInfo.Location = new System.Drawing.Point(40, 96);
            this.cbInfo.Name = "cbInfo";
            this.cbInfo.Size = new System.Drawing.Size(381, 210);
            this.cbInfo.TabIndex = 2;
            this.cbInfo.TabStop = false;
            this.cbInfo.Text = "Información";
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(136, 146);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.ReadOnly = true;
            this.txtBalance.Size = new System.Drawing.Size(128, 26);
            this.txtBalance.TabIndex = 7;
            // 
            // txtActivity
            // 
            this.txtActivity.Location = new System.Drawing.Point(136, 95);
            this.txtActivity.Name = "txtActivity";
            this.txtActivity.ReadOnly = true;
            this.txtActivity.Size = new System.Drawing.Size(228, 26);
            this.txtActivity.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 44);
            this.txtName.Name = "txtName";
            this.txtName.ReadOnly = true;
            this.txtName.Size = new System.Drawing.Size(228, 26);
            this.txtName.TabIndex = 5;
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(28, 149);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(50, 20);
            this.lblBalance.TabIndex = 4;
            this.lblBalance.Text = "Saldo";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(28, 98);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(73, 20);
            this.lblActivity.TabIndex = 3;
            this.lblActivity.Text = "Actividad";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(28, 47);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Nombre";
            // 
            // frmConsultCli
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 378);
            this.Controls.Add(this.cbInfo);
            this.Controls.Add(this.lstSelec);
            this.Controls.Add(this.lblSelec);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultCli";
            this.Text = "Consulta - Cliente";
            this.Load += new System.EventHandler(this.frmConsultCli_Load);
            this.cbInfo.ResumeLayout(false);
            this.cbInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSelec;
        private System.Windows.Forms.ComboBox lstSelec;
        private System.Windows.Forms.GroupBox cbInfo;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.TextBox txtActivity;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblName;
    }
}