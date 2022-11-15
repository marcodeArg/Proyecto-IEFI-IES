namespace pryMoralesIEFI
{
    partial class frmConsultNei
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
            this.lstNeighbour = new System.Windows.Forms.ComboBox();
            this.lblActivity = new System.Windows.Forms.Label();
            this.txtCant = new System.Windows.Forms.TextBox();
            this.lblCant = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnExport = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtHigBalance = new System.Windows.Forms.TextBox();
            this.txtLowBalance = new System.Windows.Forms.TextBox();
            this.txtTotBalance = new System.Windows.Forms.TextBox();
            this.txtAvgBalance = new System.Windows.Forms.TextBox();
            this.lblAvgBalance = new System.Windows.Forms.Label();
            this.lblTotBlance = new System.Windows.Forms.Label();
            this.lblLowBalance = new System.Windows.Forms.Label();
            this.lblHigBalance = new System.Windows.Forms.Label();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // lstNeighbour
            // 
            this.lstNeighbour.FormattingEnabled = true;
            this.lstNeighbour.Location = new System.Drawing.Point(91, 21);
            this.lstNeighbour.Name = "lstNeighbour";
            this.lstNeighbour.Size = new System.Drawing.Size(328, 28);
            this.lstNeighbour.TabIndex = 15;
            this.lstNeighbour.SelectionChangeCommitted += new System.EventHandler(this.lstNeighbour_SelectionChangeCommitted);
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(17, 24);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(51, 20);
            this.lblActivity.TabIndex = 14;
            this.lblActivity.Text = "Barrio";
            // 
            // txtCant
            // 
            this.txtCant.Location = new System.Drawing.Point(621, 203);
            this.txtCant.Name = "txtCant";
            this.txtCant.ReadOnly = true;
            this.txtCant.Size = new System.Drawing.Size(119, 26);
            this.txtCant.TabIndex = 41;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(443, 206);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(165, 20);
            this.lblCant.TabIndex = 40;
            this.lblCant.Text = "Cantidad de personas";
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(395, 295);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 33);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = true;
            // 
            // btnExport
            // 
            this.btnExport.Location = new System.Drawing.Point(495, 295);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(136, 33);
            this.btnExport.TabIndex = 38;
            this.btnExport.Text = "Generar reporte";
            this.btnExport.UseVisualStyleBackColor = true;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(650, 295);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 33);
            this.btnPrint.TabIndex = 37;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = true;
            // 
            // txtHigBalance
            // 
            this.txtHigBalance.Location = new System.Drawing.Point(621, 65);
            this.txtHigBalance.Name = "txtHigBalance";
            this.txtHigBalance.ReadOnly = true;
            this.txtHigBalance.Size = new System.Drawing.Size(119, 26);
            this.txtHigBalance.TabIndex = 36;
            // 
            // txtLowBalance
            // 
            this.txtLowBalance.Location = new System.Drawing.Point(621, 111);
            this.txtLowBalance.Name = "txtLowBalance";
            this.txtLowBalance.ReadOnly = true;
            this.txtLowBalance.Size = new System.Drawing.Size(119, 26);
            this.txtLowBalance.TabIndex = 35;
            // 
            // txtTotBalance
            // 
            this.txtTotBalance.Location = new System.Drawing.Point(621, 157);
            this.txtTotBalance.Name = "txtTotBalance";
            this.txtTotBalance.ReadOnly = true;
            this.txtTotBalance.Size = new System.Drawing.Size(119, 26);
            this.txtTotBalance.TabIndex = 34;
            // 
            // txtAvgBalance
            // 
            this.txtAvgBalance.Location = new System.Drawing.Point(621, 249);
            this.txtAvgBalance.Name = "txtAvgBalance";
            this.txtAvgBalance.ReadOnly = true;
            this.txtAvgBalance.Size = new System.Drawing.Size(119, 26);
            this.txtAvgBalance.TabIndex = 33;
            // 
            // lblAvgBalance
            // 
            this.lblAvgBalance.AutoSize = true;
            this.lblAvgBalance.Location = new System.Drawing.Point(443, 252);
            this.lblAvgBalance.Name = "lblAvgBalance";
            this.lblAvgBalance.Size = new System.Drawing.Size(148, 20);
            this.lblAvgBalance.TabIndex = 32;
            this.lblAvgBalance.Text = "Promedio de saldos";
            // 
            // lblTotBlance
            // 
            this.lblTotBlance.AutoSize = true;
            this.lblTotBlance.Location = new System.Drawing.Point(443, 160);
            this.lblTotBlance.Name = "lblTotBlance";
            this.lblTotBlance.Size = new System.Drawing.Size(116, 20);
            this.lblTotBlance.TabIndex = 31;
            this.lblTotBlance.Text = "Total de saldos";
            // 
            // lblLowBalance
            // 
            this.lblLowBalance.AutoSize = true;
            this.lblLowBalance.Location = new System.Drawing.Point(443, 114);
            this.lblLowBalance.Name = "lblLowBalance";
            this.lblLowBalance.Size = new System.Drawing.Size(96, 20);
            this.lblLowBalance.TabIndex = 30;
            this.lblLowBalance.Text = "Menor saldo";
            // 
            // lblHigBalance
            // 
            this.lblHigBalance.AutoSize = true;
            this.lblHigBalance.Location = new System.Drawing.Point(443, 68);
            this.lblHigBalance.Name = "lblHigBalance";
            this.lblHigBalance.Size = new System.Drawing.Size(94, 20);
            this.lblHigBalance.TabIndex = 29;
            this.lblHigBalance.Text = "Mayor saldo";
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(17, 68);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.Size = new System.Drawing.Size(399, 204);
            this.dgvClient.TabIndex = 28;
            // 
            // frmConsultNei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(758, 353);
            this.Controls.Add(this.txtCant);
            this.Controls.Add(this.lblCant);
            this.Controls.Add(this.btnExit);
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
            this.Controls.Add(this.lstNeighbour);
            this.Controls.Add(this.lblActivity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultNei";
            this.Text = "Consulta - Barrio";
            this.Load += new System.EventHandler(this.frmConsultNei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox lstNeighbour;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.TextBox txtCant;
        private System.Windows.Forms.Label lblCant;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnExport;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.TextBox txtHigBalance;
        private System.Windows.Forms.TextBox txtLowBalance;
        private System.Windows.Forms.TextBox txtTotBalance;
        private System.Windows.Forms.TextBox txtAvgBalance;
        private System.Windows.Forms.Label lblAvgBalance;
        private System.Windows.Forms.Label lblTotBlance;
        private System.Windows.Forms.Label lblLowBalance;
        private System.Windows.Forms.Label lblHigBalance;
        private System.Windows.Forms.DataGridView dgvClient;
    }
}