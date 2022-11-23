namespace pryMoralesIEFI
{
    partial class frmHom
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHom));
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.administrarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actividadesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.barrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorActividadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultarPorClienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaPorBarrioToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.consultaTotalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(53)))), ((int)(((byte)(79)))), ((int)(((byte)(82)))));
            this.msMenu.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administrarToolStripMenuItem,
            this.consultasToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(623, 29);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "msMenu";
            // 
            // administrarToolStripMenuItem
            // 
            this.administrarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clientesToolStripMenuItem,
            this.actividadesToolStripMenuItem,
            this.barrioToolStripMenuItem});
            this.administrarToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.administrarToolStripMenuItem.Name = "administrarToolStripMenuItem";
            this.administrarToolStripMenuItem.Size = new System.Drawing.Size(75, 25);
            this.administrarToolStripMenuItem.Text = "Gestion";
            // 
            // clientesToolStripMenuItem
            // 
            this.clientesToolStripMenuItem.Name = "clientesToolStripMenuItem";
            this.clientesToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.clientesToolStripMenuItem.Text = "Clientes";
            this.clientesToolStripMenuItem.Click += new System.EventHandler(this.clientesToolStripMenuItem_Click);
            // 
            // actividadesToolStripMenuItem
            // 
            this.actividadesToolStripMenuItem.Name = "actividadesToolStripMenuItem";
            this.actividadesToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.actividadesToolStripMenuItem.Text = "Actividades";
            this.actividadesToolStripMenuItem.Click += new System.EventHandler(this.actividadesToolStripMenuItem_Click);
            // 
            // barrioToolStripMenuItem
            // 
            this.barrioToolStripMenuItem.Name = "barrioToolStripMenuItem";
            this.barrioToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.barrioToolStripMenuItem.Text = "Barrios";
            this.barrioToolStripMenuItem.Click += new System.EventHandler(this.barrioToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaPorActividadToolStripMenuItem,
            this.consultarPorClienteToolStripMenuItem,
            this.consultaPorBarrioToolStripMenuItem,
            this.toolStripSeparator1,
            this.consultaTotalToolStripMenuItem});
            this.consultasToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(90, 25);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaPorActividadToolStripMenuItem
            // 
            this.consultaPorActividadToolStripMenuItem.Name = "consultaPorActividadToolStripMenuItem";
            this.consultaPorActividadToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.consultaPorActividadToolStripMenuItem.Text = "Consulta por actividad";
            this.consultaPorActividadToolStripMenuItem.Click += new System.EventHandler(this.consultaPorActividadToolStripMenuItem_Click);
            // 
            // consultarPorClienteToolStripMenuItem
            // 
            this.consultarPorClienteToolStripMenuItem.Name = "consultarPorClienteToolStripMenuItem";
            this.consultarPorClienteToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.consultarPorClienteToolStripMenuItem.Text = "Consultar por cliente";
            this.consultarPorClienteToolStripMenuItem.Click += new System.EventHandler(this.consultarPorClienteToolStripMenuItem_Click);
            // 
            // consultaPorBarrioToolStripMenuItem
            // 
            this.consultaPorBarrioToolStripMenuItem.Name = "consultaPorBarrioToolStripMenuItem";
            this.consultaPorBarrioToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.consultaPorBarrioToolStripMenuItem.Text = "Consulta por barrio";
            this.consultaPorBarrioToolStripMenuItem.Click += new System.EventHandler(this.consultaPorBarrioToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(232, 6);
            // 
            // consultaTotalToolStripMenuItem
            // 
            this.consultaTotalToolStripMenuItem.Name = "consultaTotalToolStripMenuItem";
            this.consultaTotalToolStripMenuItem.Size = new System.Drawing.Size(235, 26);
            this.consultaTotalToolStripMenuItem.Text = "Consulta total";
            this.consultaTotalToolStripMenuItem.Click += new System.EventHandler(this.consultaTotalToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.ForeColor = System.Drawing.SystemColors.Control;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(53, 25);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 25);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(623, 337);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // frmHom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(215)))), ((int)(((byte)(205)))));
            this.ClientSize = new System.Drawing.Size(623, 358);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.msMenu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.msMenu;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmHom";
            this.Text = "Inicio";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem administrarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actividadesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem barrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPorActividadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaPorBarrioToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem consultaTotalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultarPorClienteToolStripMenuItem;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
    }
}

