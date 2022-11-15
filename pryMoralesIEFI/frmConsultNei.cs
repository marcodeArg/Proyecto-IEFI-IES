using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pryMoralesIEFI
{
    public partial class frmConsultNei : Form
    {
        public frmConsultNei()
        {
            InitializeComponent();
        }

        clsNeighbour neighbour = new clsNeighbour("Barrio");
        clsClient client = new clsClient("Socio");

        private void frmConsultNei_Load(object sender, EventArgs e)
        {
            //cargar en el comboBox con los barrios
            neighbour.ShowInList(lstNeighbour, "Detalle_Barrio", "Codigo_Barrio");

            int elec = Convert.ToInt32(lstNeighbour.SelectedValue);

            client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Barrio=" + elec;
            client.ShowInGrid(dgvClient, client.Sql);


            //Obtener el mayor, menor y promedio
            client.GetInfoClient();

            txtHigBalance.Text = client.Higher.ToString();
            txtTotBalance.Text = client.Total.ToString();
            txtLowBalance.Text = client.Lower.ToString();
            txtCant.Text = client.Counter.ToString();

            txtAvgBalance.Text = (client.Total / client.Counter).ToString();
            client.Total = 0;
            client.Counter = 0;
        }

        //mantener actualizada la grilla
        private void lstNeighbour_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int elec = Convert.ToInt32(lstNeighbour.SelectedValue);

            client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Barrio=" + elec;
            client.ShowInGrid(dgvClient, client.Sql);


            //Obtener el mayor, menor y promedio
            client.GetInfoClient();

            txtHigBalance.Text = client.Higher.ToString();
            txtTotBalance.Text = client.Total.ToString();
            txtLowBalance.Text = client.Lower.ToString();
            txtCant.Text = client.Counter.ToString();

            txtAvgBalance.Text = (client.Total / client.Counter).ToString();
            client.Total = 0;
            client.Counter = 0;
        }

    }
}
