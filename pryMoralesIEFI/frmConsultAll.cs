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
    public partial class frmConsultAll : Form
    {
        public frmConsultAll()
        {
            InitializeComponent();
        }

        clsClient client = new clsClient("Socio");

        private void frmConsultAll_Load(object sender, EventArgs e)
        {

            if (client.ExistContent() && client.ExistContent("Actividad") && client.ExistContent("Barrio"))
            {

                client.GridStyle(dgvAllClients);

                dgvAllClients.Columns.Add("DNI", "DNI");
                dgvAllClients.Columns.Add("Nombre", "Nombre");
                dgvAllClients.Columns.Add("Direccion", "Direccion");
                dgvAllClients.Columns.Add("Barrio", "Barrio");
                dgvAllClients.Columns.Add("Actividad", "Actividad");
                dgvAllClients.Columns.Add("Saldo", "Saldo");

                client.ShowAllClients(dgvAllClients);

                client.Sql = "SELECT * FROM Socio";

                //Obtener info del cliente
                client.GetInfoClient();

                txtCounter.Text = client.Counter.ToString();
                txtTotal.Text = client.Total.ToString();
            }
            else
            {
                MessageBox.Show("Primero debe cargar con datos las tablas 'Socio', 'Barrio' y 'Actividad'");
                btnPrint.Enabled = false;
                btnExport.Enabled = false;
            }


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
            client.PrintAllClients(e);
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            client.GenerateAllReport();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
