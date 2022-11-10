using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Data.OleDb;
using System.Data.Common;

namespace pryMoralesIEFI
{
    public partial class frmClient : Form
    {
        public frmClient()
        {
            InitializeComponent();
        }

        clsClient client = new clsClient("Socio");

        private void frmClient_Load(object sender, EventArgs e)
        {
            
            client.ShowClientFullInGrid(dgvClient);
            
            //dgvClient.DataSource = client.ListarProductos();

            //Cargar las listas
            clsNeighbour neighbour = new clsNeighbour("Barrio");
            neighbour.ShowInList(lstNeighbour, "Detalle_Barrio", "Codigo_Barrio");

            clsActivity activity = new clsActivity("Actividad");
            activity.ShowInList(lstActivity, "Detalle_Actividad", "Codigo_Actividad");
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            //HAY QUE VALIDAR SI EL ID NO EXISTE PARA PODER CARGARLO, PORQUE SINO TENDRIA QUE DAR ERROR
            try
            {
                client.Dni = Int32.Parse(txtDNI.Text);
                client.Name = txtName.Text;
                client.Address = txtAddress.Text;
                client.Cod_neighbour = Int32.Parse(lstNeighbour.SelectedValue.ToString());
                client.Cod_activity = Int32.Parse(lstActivity.SelectedValue.ToString());
                client.Balance = Convert.ToInt32(txtBalance.Text);

                client.InsertClient();

                MessageBox.Show("Agregado correctamente");

                //Para que la grilla se actualice con el nuevo registro
                client.ShowClientFullInGrid(dgvClient);
            }
            catch (Exception err)
            {

                MessageBox.Show("Error" + err.Message);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void dgvClient_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtDNI.Text = dgvClient.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            lstNeighbour.Text = dgvClient.CurrentRow.Cells[3].Value.ToString();
            lstActivity.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();
            txtBalance.Text = dgvClient.CurrentRow.Cells[5].Value.ToString();
        }
    }
}
