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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConsultNei));
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.prtDialog = new System.Windows.Forms.PrintDialog();
            this.prtDocument = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstNeighbour
            // 
            this.lstNeighbour.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lstNeighbour.FormattingEnabled = true;
            this.lstNeighbour.Location = new System.Drawing.Point(91, 21);
            this.lstNeighbour.Name = "lstNeighbour";
            this.lstNeighbour.Size = new System.Drawing.Size(558, 28);
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
            this.txtCant.Location = new System.Drawing.Point(490, 44);
            this.txtCant.Name = "txtCant";
            this.txtCant.ReadOnly = true;
            this.txtCant.Size = new System.Drawing.Size(119, 26);
            this.txtCant.TabIndex = 41;
            // 
            // lblCant
            // 
            this.lblCant.AutoSize = true;
            this.lblCant.Location = new System.Drawing.Point(312, 47);
            this.lblCant.Name = "lblCant";
            this.lblCant.Size = new System.Drawing.Size(165, 20);
            this.lblCant.TabIndex = 40;
            this.lblCant.Text = "Cantidad de personas";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Location = new System.Drawing.Point(304, 510);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(77, 33);
            this.btnExit.TabIndex = 39;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnExport
            // 
            this.btnExport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnExport.FlatAppearance.BorderSize = 0;
            this.btnExport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExport.Location = new System.Drawing.Point(404, 510);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(136, 33);
            this.btnExport.TabIndex = 38;
            this.btnExport.Text = "Generar reporte";
            this.btnExport.UseVisualStyleBackColor = false;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            this.btnPrint.FlatAppearance.BorderSize = 0;
            this.btnPrint.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrint.Location = new System.Drawing.Point(559, 510);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(90, 33);
            this.btnPrint.TabIndex = 37;
            this.btnPrint.Text = "Imprimir";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // txtHigBalance
            // 
            this.txtHigBalance.Location = new System.Drawing.Point(156, 44);
            this.txtHigBalance.Name = "txtHigBalance";
            this.txtHigBalance.ReadOnly = true;
            this.txtHigBalance.Size = new System.Drawing.Size(119, 26);
            this.txtHigBalance.TabIndex = 36;
            // 
            // txtLowBalance
            // 
            this.txtLowBalance.Location = new System.Drawing.Point(156, 90);
            this.txtLowBalance.Name = "txtLowBalance";
            this.txtLowBalance.ReadOnly = true;
            this.txtLowBalance.Size = new System.Drawing.Size(119, 26);
            this.txtLowBalance.TabIndex = 35;
            // 
            // txtTotBalance
            // 
            this.txtTotBalance.Location = new System.Drawing.Point(156, 136);
            this.txtTotBalance.Name = "txtTotBalance";
            this.txtTotBalance.ReadOnly = true;
            this.txtTotBalance.Size = new System.Drawing.Size(119, 26);
            this.txtTotBalance.TabIndex = 34;
            // 
            // txtAvgBalance
            // 
            this.txtAvgBalance.Location = new System.Drawing.Point(490, 90);
            this.txtAvgBalance.Name = "txtAvgBalance";
            this.txtAvgBalance.ReadOnly = true;
            this.txtAvgBalance.Size = new System.Drawing.Size(119, 26);
            this.txtAvgBalance.TabIndex = 33;
            // 
            // lblAvgBalance
            // 
            this.lblAvgBalance.AutoSize = true;
            this.lblAvgBalance.Location = new System.Drawing.Point(312, 93);
            this.lblAvgBalance.Name = "lblAvgBalance";
            this.lblAvgBalance.Size = new System.Drawing.Size(148, 20);
            this.lblAvgBalance.TabIndex = 32;
            this.lblAvgBalance.Text = "Promedio de saldos";
            // 
            // lblTotBlance
            // 
            this.lblTotBlance.AutoSize = true;
            this.lblTotBlance.Location = new System.Drawing.Point(20, 139);
            this.lblTotBlance.Name = "lblTotBlance";
            this.lblTotBlance.Size = new System.Drawing.Size(116, 20);
            this.lblTotBlance.TabIndex = 31;
            this.lblTotBlance.Text = "Total de saldos";
            // 
            // lblLowBalance
            // 
            this.lblLowBalance.AutoSize = true;
            this.lblLowBalance.Location = new System.Drawing.Point(20, 93);
            this.lblLowBalance.Name = "lblLowBalance";
            this.lblLowBalance.Size = new System.Drawing.Size(96, 20);
            this.lblLowBalance.TabIndex = 30;
            this.lblLowBalance.Text = "Menor saldo";
            // 
            // lblHigBalance
            // 
            this.lblHigBalance.AutoSize = true;
            this.lblHigBalance.Location = new System.Drawing.Point(20, 47);
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
            this.dgvClient.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClient.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(169)))), ((int)(((byte)(140)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClient.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvClient.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.dgvClient.Location = new System.Drawing.Point(17, 82);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.Size = new System.Drawing.Size(632, 204);
            this.dgvClient.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtTotBalance);
            this.groupBox1.Controls.Add(this.txtCant);
            this.groupBox1.Controls.Add(this.lblHigBalance);
            this.groupBox1.Controls.Add(this.lblCant);
            this.groupBox1.Controls.Add(this.lblLowBalance);
            this.groupBox1.Controls.Add(this.lblTotBlance);
            this.groupBox1.Controls.Add(this.txtLowBalance);
            this.groupBox1.Controls.Add(this.txtHigBalance);
            this.groupBox1.Controls.Add(this.txtAvgBalance);
            this.groupBox1.Controls.Add(this.lblAvgBalance);
            this.groupBox1.Location = new System.Drawing.Point(17, 306);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(632, 186);
            this.groupBox1.TabIndex = 42;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Información";
            // 
            // prtDialog
            // 
            this.prtDialog.UseEXDialog = true;
            // 
            // prtDocument
            // 
            this.prtDocument.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.prtDocument_PrintPage);
            // 
            // frmConsultNei
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(670, 562);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.lstNeighbour);
            this.Controls.Add(this.lblActivity);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultNei";
            this.Text = "Consulta - Barrio";
            this.Load += new System.EventHandler(this.frmConsultNei_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.PrintDialog prtDialog;
        private System.Drawing.Printing.PrintDocument prtDocument;
    }
}