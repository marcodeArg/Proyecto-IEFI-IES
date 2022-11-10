namespace pryMoralesIEFI
{
    partial class frmClient
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtDNISearch = new System.Windows.Forms.TextBox();
            this.dgvClient = new System.Windows.Forms.DataGridView();
            this.lblDNI = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.lblNeighbour = new System.Windows.Forms.Label();
            this.lblActivity = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lstNeighbour = new System.Windows.Forms.ComboBox();
            this.lstActivity = new System.Windows.Forms.ComboBox();
            this.txtBalance = new System.Windows.Forms.TextBox();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(118, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Buscar por DNI";
            // 
            // txtDNISearch
            // 
            this.txtDNISearch.Location = new System.Drawing.Point(176, 17);
            this.txtDNISearch.Name = "txtDNISearch";
            this.txtDNISearch.Size = new System.Drawing.Size(530, 26);
            this.txtDNISearch.TabIndex = 1;
            // 
            // dgvClient
            // 
            this.dgvClient.AllowUserToAddRows = false;
            this.dgvClient.AllowUserToDeleteRows = false;
            this.dgvClient.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvClient.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClient.Location = new System.Drawing.Point(12, 87);
            this.dgvClient.Name = "dgvClient";
            this.dgvClient.ReadOnly = true;
            this.dgvClient.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClient.Size = new System.Drawing.Size(872, 352);
            this.dgvClient.TabIndex = 2;
            this.dgvClient.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvClient_CellEnter);
            // 
            // lblDNI
            // 
            this.lblDNI.AutoSize = true;
            this.lblDNI.Location = new System.Drawing.Point(974, 109);
            this.lblDNI.Name = "lblDNI";
            this.lblDNI.Size = new System.Drawing.Size(37, 20);
            this.lblDNI.TabIndex = 3;
            this.lblDNI.Text = "DNI";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(974, 147);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(65, 20);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "Nombre";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(974, 183);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(75, 20);
            this.lblAddress.TabIndex = 5;
            this.lblAddress.Text = "Direccion";
            // 
            // lblNeighbour
            // 
            this.lblNeighbour.AutoSize = true;
            this.lblNeighbour.Location = new System.Drawing.Point(974, 225);
            this.lblNeighbour.Name = "lblNeighbour";
            this.lblNeighbour.Size = new System.Drawing.Size(51, 20);
            this.lblNeighbour.TabIndex = 6;
            this.lblNeighbour.Text = "Barrio";
            // 
            // lblActivity
            // 
            this.lblActivity.AutoSize = true;
            this.lblActivity.Location = new System.Drawing.Point(974, 269);
            this.lblActivity.Name = "lblActivity";
            this.lblActivity.Size = new System.Drawing.Size(73, 20);
            this.lblActivity.TabIndex = 7;
            this.lblActivity.Text = "Actividad";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Location = new System.Drawing.Point(974, 315);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(50, 20);
            this.lblBalance.TabIndex = 8;
            this.lblBalance.Text = "Saldo";
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(1057, 106);
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.Size = new System.Drawing.Size(100, 26);
            this.txtDNI.TabIndex = 9;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(1057, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 26);
            this.txtName.TabIndex = 10;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(1069, 180);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(100, 26);
            this.txtAddress.TabIndex = 11;
            // 
            // lstNeighbour
            // 
            this.lstNeighbour.FormattingEnabled = true;
            this.lstNeighbour.Location = new System.Drawing.Point(1048, 222);
            this.lstNeighbour.Name = "lstNeighbour";
            this.lstNeighbour.Size = new System.Drawing.Size(121, 28);
            this.lstNeighbour.TabIndex = 12;
            // 
            // lstActivity
            // 
            this.lstActivity.FormattingEnabled = true;
            this.lstActivity.Location = new System.Drawing.Point(1053, 266);
            this.lstActivity.Name = "lstActivity";
            this.lstActivity.Size = new System.Drawing.Size(121, 28);
            this.lstActivity.TabIndex = 13;
            // 
            // txtBalance
            // 
            this.txtBalance.Location = new System.Drawing.Point(1053, 312);
            this.txtBalance.Name = "txtBalance";
            this.txtBalance.Size = new System.Drawing.Size(100, 26);
            this.txtBalance.TabIndex = 14;
            // 
            // btnInsert
            // 
            this.btnInsert.Location = new System.Drawing.Point(920, 399);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(91, 31);
            this.btnInsert.TabIndex = 15;
            this.btnInsert.Text = "Agregar";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1017, 399);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 31);
            this.btnUpdate.TabIndex = 16;
            this.btnUpdate.Text = "Modificar";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1114, 399);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(91, 31);
            this.btnDelete.TabIndex = 17;
            this.btnDelete.Text = "Eliminar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // frmClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 596);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnInsert);
            this.Controls.Add(this.txtBalance);
            this.Controls.Add(this.lstActivity);
            this.Controls.Add(this.lstNeighbour);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblActivity);
            this.Controls.Add(this.lblNeighbour);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblDNI);
            this.Controls.Add(this.dgvClient);
            this.Controls.Add(this.txtDNISearch);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmClient";
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.frmClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClient)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDNISearch;
        private System.Windows.Forms.DataGridView dgvClient;
        private System.Windows.Forms.Label lblDNI;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.Label lblNeighbour;
        private System.Windows.Forms.Label lblActivity;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.ComboBox lstNeighbour;
        private System.Windows.Forms.ComboBox lstActivity;
        private System.Windows.Forms.TextBox txtBalance;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
    }
}