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
        private int elec;

        private void frmConsultAct_Load(object sender, EventArgs e)
        {

            if (client.ExistContent() && activity.ExistContent())
            {
                activity.GridStyle(dgvClient);


                activity.ShowInList(lstActivity, "Detalle_Actividad", "Codigo_Actividad");


                elec = Convert.ToInt32(lstActivity.SelectedValue);

                client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Actividad=" + elec;
                client.ShowInGrid(dgvClient, client.Sql);


                //Obtener el mayor, menor y promedio
                client.GetInfoClient();

                txtHigBalance.Text = client.Higher.ToString();
                txtTotBalance.Text = client.Total.ToString();
                txtLowBalance.Text = client.Lower.ToString();
                txtCant.Text = client.Counter.ToString();

                txtAvgBalance.Text = (client.Total / client.Counter).ToString("0.00");
                client.Total = 0;
                client.Counter = 0;
            }
            else
            {
                MessageBox.Show("Primero debe cargar con datos las tablas 'Socio' y 'Actividad'");
                btnExport.Enabled = false;
                btnPrint.Enabled = false;
            }
        }

        private void lstActivity_SelectionChangeCommitted(object sender, EventArgs e)
        {
            elec = Convert.ToInt32(lstActivity.SelectedValue);

            client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Actividad=" + elec;
            client.ShowInGrid(dgvClient, client.Sql);


            //Actualizar el mayor, menor y promedio cuando se seleccione otra actividad
            client.GetInfoClient();

            txtHigBalance.Text = client.Higher.ToString();
            txtTotBalance.Text = client.Total.ToString();
            txtLowBalance.Text = client.Lower.ToString();
            txtCant.Text = client.Counter.ToString();

            //Por si alguna actividad no tiene clientes
            try
            {
                txtAvgBalance.Text = (client.Total / client.Counter).ToString("0.00");
            }
            catch (Exception)
            {

                MessageBox.Show("No existe clientes que realicen dicha actividad");
            }
            
            client.Total = 0;
            client.Counter = 0;

        }

        private void btnExport_Click(object sender, EventArgs e)
        {

            client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Actividad=" + elec;

            client.GenerateGenericReport("Actividad");

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            prtDialog.ShowDialog();
            prtDocument.PrinterSettings = prtDialog.PrinterSettings;
            prtDocument.Print();
            MessageBox.Show("Impreso correctamente");
        }

        private void prtDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {

            client.Sql = "SELECT Dni_Socio AS DNI, Nombre_Apellido AS Nombre, Saldo FROM Socio WHERE Codigo_Actividad=" + elec;

            client.PrintGenericClient(e);
        }

    }
}
