namespace pryMoralesIEFI
{
    partial class frmConsultAll
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
            this.dgvAllClients = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAllClients
            // 
            this.dgvAllClients.AllowUserToAddRows = false;
            this.dgvAllClients.AllowUserToDeleteRows = false;
            this.dgvAllClients.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllClients.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvAllClients.Location = new System.Drawing.Point(0, 0);
            this.dgvAllClients.Name = "dgvAllClients";
            this.dgvAllClients.ReadOnly = true;
            this.dgvAllClients.Size = new System.Drawing.Size(759, 433);
            this.dgvAllClients.TabIndex = 0;
            // 
            // frmConsultAll
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(759, 433);
            this.Controls.Add(this.dgvAllClients);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmConsultAll";
            this.Text = "Consulta - Todo";
            this.Load += new System.EventHandler(this.frmConsultAll_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllClients)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAllClients;
    }
}