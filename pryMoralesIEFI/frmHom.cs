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
    public partial class frmHom : Form
    {
        public frmHom()
        {
            InitializeComponent();
        }

        //GESTION
        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmClient clients = new frmClient();
            clients.ShowDialog();
        }

        private void actividadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmActivity actividades = new frmActivity();
            actividades.ShowDialog();
        }

        private void barrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNeighbour neighbour = new frmNeighbour();
            neighbour.ShowDialog();
        }



        //CONSULTAS
        private void consultaPorActividadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultAct conActividad = new frmConsultAct();
            conActividad.ShowDialog();
        }

        private void consultaPorBarrioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultNei conNeighbour = new frmConsultNei();
            conNeighbour.ShowDialog();
        }

        private void consultarPorClienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultCli conClient = new frmConsultCli();
            conClient.ShowDialog();
        }

        private void consultaTotalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConsultAll conAll = new frmConsultAll();
            conAll.ShowDialog();
        }
    }
}
