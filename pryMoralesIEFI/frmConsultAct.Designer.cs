namespace pryMoralesIEFI
{
    partial class frmConsultAct
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
            this.lblActivity = new System.Windows.Forms.Label();
            this.lstActivity = new System.Windows.Forms.ComboBox();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.lblHigBalance = new System.Windows.Forms.Label();
            this.lblLowBalance = new System.Windows.Forms.Label();
            this.lblTotBlance = new System.Windows.Forms.Label();
            this.lblAvgBalance = new System.Windows.Forms.Label();
            this.txtAvgBalance = new System.Windows.Forms.TextBox();
            this.txtTotBalance = new System.Windows.Forms.TextBox();
            this.txtLowBalance = new System.Windows.Forms.TextBox();
            this.txtHigBalance = new System.Windows.Forms.TextBox();
            this.btnShow = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(24, 24);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(73, 20);
            this.lblActivity.TabIndex = 0;
            this.lblActivity.Text = "Actividad";
            // 
            // lstActivity
            // 
            this.lstActivity.FormattingEnabled = true;
            this.lstActivity.Location = new System.Drawing.Point(132, 21);
            this.lstActivity.Name = "lstActivity";
            this.lstActivity.Size = new System.Drawing.Size(295, 28);
            this.lstActivity.TabIndex = 1;
            this.lstActivity.SelectedIndexChanged += new System.EventHandler(this.lstActivity_SelectedIndexChanged);
            this.lstActivity.SelectionChangeCommitted += new System.EventHandler(this.lstActivity_SelectionChangeCommitted);
            this.lstActivity.TextUpdate += new System.EventHandler(this.lstActivity_TextUpdate);
            this.lstActivity.DisplayMemberChanged += new System.EventHandler(this.lstActivity_DisplayMemberChanged);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(28, 66);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.Size = new System.Drawing.Size(399, 179);
            this.dgvClient.TabIndex = 2;
            // 
            // lblHigBalance
            // 
            this.lblHigBalance.AutoSize = true;
            this.lblHigBalance.Location = new System.Drawing.Point(453, 66);
            this.lblHigBalance.Name = "lblHigBalance";
            this.lblHigBalance.Size = new System.Drawing.Size(94, 20);
            this.lblHigBalance.TabIndex = 3;
            this.lblHigBalance.Text = "Mayor saldo";
            // 
            // lblLowBalance
            // 
            this.lblLowBalance.AutoSize = true;
            this.lblLowBalance.Location = new System.Drawing.Point(453, 119);
            this.lblLowBalance.Name = "lblLowBalance";
            this.lblLowBalance.Size = new System.Drawing.Size(96, 20);
            this.lblLowBalance.TabIndex = 4;
            this.lblLowBalance.Text = "Menor saldo";
            // 
            // lblTotBlance
            // 
            this.lblTotBlance.AutoSize = true;
            this.lblTotBlance.Location = new System.Drawing.Point(453, 172);
            this.lblTotBlance.Name = "lblTotBlance";
            this.lblTotBlance.Size = new System.Drawing.Size(116, 20);
            this.lblTotBlance.TabIndex = 5;
            this.lblTotBlance.Text = "Total de saldos";
            // 
            // lblAvgBalance
            // 
            this.lblAvgBalance.AutoSize = true;
            this.lblAvgBalance.Location = new System.Drawing.Point(453, 225);
            this.lblAvgBalance.Name = "lblAvgBalance";
            this.lblAvgBalance.Size = new System.Drawing.Size(148, 20);
            this.lblAvgBalance.TabIndex = 6;
            this.lblAvgBalance.Text = "Promedio de saldos";
            // 
            // txtAvgBalance
            // 
            this.txtAvgBalance.Location = new System.Drawing.Point(619, 222);
            this.txtAvgBalance.Name = "txtAvgBalance";
            this.txtAvgBalance.ReadOnly = true;
            this.txtAvgBalance.Size = new System.Drawing.Size(119, 26);
            this.txtAvgBalance.TabIndex = 7;
            // 
            // txtTotBalance
            // 
            this.txtTotBalance.Location = new System.Drawing.Point(619, 168);
            this.txtTotBalance.Name = "txtTotBalance";
            this.txtTotBalance.ReadOnly = true;
            this.txtTotBalance.Size = new System.Drawing.Size(119, 26);
            this.txtTotBalance.TabIndex = 8;
            // 
            // txtLowBalance
            // 
            this.txtLowBalance.Location = new System.Drawing.Point(619, 116);
            this.txtLowBalance.Name = "txtLowBalance";
            this.txtLowBalance.ReadOnly = true;
            this.txtLowBalance.Size = new System.Drawing.Size(119, 26);
            this.txtLowBalance.TabIndex = 9;
            // 
            // txtHigBalance
            // 
            this.txtHigBalance.Location = new System.Drawing.Point(619, 63);
            this.txtHigBalance.Name = "txtHigBalance";
            this.txtHigBalance.ReadOnly = true;
            this.txtHigBalance.Size = new System.Drawing.Size(119, 26);
            this.txtHigBalance.TabIndex = 10;
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(28, 272);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(86, 27);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Listar";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // frmConsultAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(892, 447);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.txtHigBalance);
            this.Controls.Add(this.txtLowBalance);
            this.Controls.Add(this.txtTotBalance);
            this.Controls.Add(this.txtAvgBalance);
            this.Controls.Add(this.lblAvgBalance);
            this.Controls.Add(this.lblTotBlance);
            this.Controls.Add(this.lblLowBalance);
            this.Controls.Add(this.lblHigBalance);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.lstActivity);
            this.Controls.Add(this.lblActivity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultAct";
            this.Text = "Consulta - Actividad";
            this.Load += new System.EventHandler(this.frmConsultAct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.ComboBox lstActivity;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Label lblHigBalance;
        private System.Windows.Forms.Label lblLowBalance;
        private System.Windows.Forms.Label lblTotBlance;
        private System.Windows.Forms.Label lblAvgBalance;
        private System.Windows.Forms.TextBox txtAvgBalance;
        private System.Windows.Forms.TextBox txtTotBalance;
        private System.Windows.Forms.TextBox txtLowBalance;
        private System.Windows.Forms.TextBox txtHigBalance;
        private System.Windows.Forms.Button btnShow;
    }
}