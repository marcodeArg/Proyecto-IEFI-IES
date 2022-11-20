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

        private void frmConsultAll_Load(object sender, EventArgs e)
        {
            clsClient client = new clsClient("Socio");

            client.ShowAllClients(dgvAllClients);
        }
    }
}
