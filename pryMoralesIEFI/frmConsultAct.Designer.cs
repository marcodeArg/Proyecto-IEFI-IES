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
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(17, 24);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(73, 20);
            this.lblActivity.TabIndex = 0;
            this.lblActivity.Text = "Actividad";
            // 
            // lstActivity
            // 
            this.lstActivity.FormattingEnabled = true;
            this.lstActivity.Location = new System.Drawing.Point(125, 21);
            this.lstActivity.Name = "lstActivity";
            this.lstActivity.Size = new System.Drawing.Size(295, 28);
            this.lstActivity.TabIndex = 1;
            this.lstActivity.SelectionChangeCommitted += new System.EventHandler(this.lstActivity_SelectionChangeCommitted);
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(21, 66);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.Size = new System.Drawing.Size(399, 179);
            this.dgvClient.TabIndex = 2;
            // 
            // lblHigBalance
            // 
            this.lblHigBalance.AutoSize = true;
            this.lblHigBalance.Location = new System.Drawing.Point(446, 66);
            this.lblHigBalance.Name = "lblHigBalance";
            this.lblHigBalance.Size = new System.Drawing.Size(94, 20);
            this.lblHigBalance.TabIndex = 3;
            this.lblHigBalance.Text = "Mayor saldo";
            // 
            // lblLowBalance
            // 
            this.lblLowBalance.AutoSize = true;
            this.lblLowBalance.Location = new System.Drawing.Point(446, 119);
            this.lblLowBalance.Name = "lblLowBalance";
            this.lblLowBalance.Size = new System.Drawing.Size(96, 20);
            this.lblLowBalance.TabIndex = 4;
            this.lblLowBalance.Text = "Menor saldo";
            // 
            // lblTotBlance
            // 
            this.lblTotBlance.AutoSize = true;
            this.lblTotBlance.Location = new System.Drawing.Point(446, 172);
            this.lblTotBlance.Name = "lblTotBlance";
            this.lblTotBlance.Size = new System.Drawing.Size(116, 20);
            this.lblTotBlance.TabIndex = 5;
            this.lblTotBlance.Text = "Total de saldos";
            // 
            // lblAvgBalance
            // 
            this.lblAvgBalance.AutoSize = true;
            this.lblAvgBalance.Location = new System.Drawing.Point(446, 225);
            this.lblAvgBalance.Name = "lblAvgBalance";
            this.lblAvgBalance.Size = new System.Drawing.Size(148, 20);
            this.lblAvgBalance.TabIndex = 6;
            this.lblAvgBalance.Text = "Promedio de saldos";
            // 
            // txtAvgBalance
            // 
            this.txtAvgBalance.Location = new System.Drawing.Point(612, 222);
            this.txtAvgBalance.Name = "txtAvgBalance";
            this.txtAvgBalance.ReadOnly = true;
            this.txtAvgBalance.Size = new System.Drawing.Size(119, 26);
            this.txtAvgBalance.TabIndex = 7;
            // 
            // txtTotBalance
            // 
            this.txtTotBalance.Location = new System.Drawing.Point(612, 168);
            this.txtTotBalance.Name = "txtTotBalance";
            this.txtTotBalance.ReadOnly = true;
            this.txtTotBalance.Size = new System.Drawing.Size(119, 26);
            this.txtTotBalance.TabIndex = 8;
            // 
            // txtLowBalance
            // 
            this.txtLowBalance.Location = new System.Drawing.Point(612, 116);
            this.txtLowBalance.Name = "txtLowBalance";
            this.txtLowBalance.ReadOnly = true;
            this.txtLowBalance.Size = new System.Drawing.Size(119, 26);
            this.txtLowBalance.TabIndex = 9;
            // 
            // txtHigBalance
            // 
            this.txtHigBalance.Location = new System.Drawing.Point(612, 63);
            this.txtHigBalance.Name = "txtHigBalance";
            this.txtHigBalance.ReadOnly = true;
            this.txtHigBalance.Size = new System.Drawing.Size(119, 26);
            this.txtHigBalance.TabIndex = 10;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(641, 273);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 33);
            this.btnPrint.TabIndex = 11;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(486, 273);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(136, 33);
            this.btnExport.TabIndex = 12;
            this.btnExport.Text = "Generar reporte";
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(386, 273);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(77, 33);
            this.btnClose.TabIndex = 13;
            this.btnClose.Text = "Salir";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmConsultAct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 326);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
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
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnClose;
    }
}