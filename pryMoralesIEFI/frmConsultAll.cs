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
            client.GridStyle(dgvAllClients);


            dgvAllClients.Columns.Add("DNI", "DNI");
            dgvAllClients.Columns.Add("Nombre", "Nombre");
            dgvAllClients.Columns.Add("Direccion", "Direccion");
            dgvAllClients.Columns.Add("Barrio", "Barrio");
            dgvAllClients.Columns.Add("Actividad", "Actividad");
            dgvAllClients.Columns.Add("Saldo", "Saldo");

            client.ShowAllClients(dgvAllClients);
        }
    }
}
