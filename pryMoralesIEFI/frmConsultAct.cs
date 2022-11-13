using System;
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

            client.Mayor();

            txtHigBalance.Text = client.mayor.ToString();
            txtTotBalance.Text = client.total.ToString();
            txtLowBalance.Text = client.menor.ToString();


            txtAvgBalance.Text = client.promedio.ToString();
            client.total = 0;

        }


        // ELIMINAR TODOS ESTOS MENOS EL ULTIMO
        private void btnShow_Click(object sender, EventArgs e)
        {
            //
        }

        private void lstActivity_SelectedIndexChanged(object sender, EventArgs e)
        {
            //int elec = Convert.ToInt32(lstActivity.SelectedValue);


            //client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Actividad=" + elec;
            //client.ShowInGrid(dgvClient, client.Sql);
        }

        private void lstActivity_TextUpdate(object sender, EventArgs e)
        {
            //int elec = Convert.ToInt32(lstActivity.SelectedValue);


            //client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Actividad=" + elec;
            //client.ShowInGrid(dgvClient, client.Sql);
        }

        private void lstActivity_DisplayMemberChanged(object sender, EventArgs e)
        {
            //int elec = Convert.ToInt32(lstActivity.SelectedValue);


            //client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Actividad=" + elec;
            //client.ShowInGrid(dgvClient, client.Sql);
        }

        private void lstActivity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int elec = Convert.ToInt32(lstActivity.SelectedValue);


            client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Actividad=" + elec;
            client.ShowInGrid(dgvClient, client.Sql);


            //TERMINAR DE REVISAR EL PROMEDIO
            client.Mayor();

            txtHigBalance.Text = client.mayor.ToString();
            txtTotBalance.Text = client.total.ToString();
            txtLowBalance.Text = client.menor.ToString();


            txtAvgBalance.Text = client.promedio.ToString();
            client.total = 0;
        }
    }
}
