﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMoralesIEFI
{
    public partial class frmConsultAct : Form
    {
        public frmConsultAct()
        {
            InitializeComponent();
        }

        clsActivity activity = new clsActivity("Actividad");
        clsClient client = new clsClient("Socio");

        private void frmConsultAct_Load(object sender, EventArgs e)
        {
            activity.ShowInList(lstActivity, "Detalle_Actividad", "Codigo_Actividad");


            int elec = Convert.ToInt32(lstActivity.SelectedValue);

            client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Actividad=" + elec;
            client.ShowInGrid(dgvClient, client.Sql);


            //Obtener el mayor, menor y promedio
            client.Mayor();

            txtHigBalance.Text = client.Higher.ToString();
            txtTotBalance.Text = client.Total.ToString();
            txtLowBalance.Text = client.Lower.ToString();


            txtAvgBalance.Text = (client.Total / client.Counter).ToString();
            client.Total = 0;
            client.Counter = 0;

        }

        private void lstActivity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int elec = Convert.ToInt32(lstActivity.SelectedValue);

            client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Actividad=" + elec;
            client.ShowInGrid(dgvClient, client.Sql);


            //Actualizar el mayor, menor y promedio cuando se seleccione otra actividad
            client.Mayor();

            txtHigBalance.Text = client.Higher.ToString();
            txtTotBalance.Text = client.Total.ToString();
            txtLowBalance.Text = client.Lower.ToString();


            txtAvgBalance.Text = (client.Total / client.Counter).ToString();
            client.Total = 0;
            client.Counter = 0;

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}