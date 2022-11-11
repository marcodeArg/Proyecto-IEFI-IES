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

            if (!client.Exist(Int32.Parse(txtDNI.Text)))
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
            else
            {
                MessageBox.Show("Ya existe un socio con el mismo DNI");
                txtDNI.Focus();

            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (client.Exist(Int32.Parse(txtDNI.Text)))
            {
                client.Dni = Int32.Parse(txtDNI.Text);
                client.Name = txtName.Text;
                client.Address = txtAddress.Text;
                client.Cod_neighbour = Int32.Parse(lstNeighbour.SelectedValue.ToString());
                client.Cod_activity = Int32.Parse(lstActivity.SelectedValue.ToString());
                client.Balance = Convert.ToInt32(txtBalance.Text);

                client.UpdateClient();

                MessageBox.Show("Modificado correctamente");

                //Para que la grilla se actualice con el nuevo registro
                client.ShowClientFullInGrid(dgvClient);
            }
            else
            {
                MessageBox.Show("No se encontro el socio con el DNI ingresado");
                txtDNI.Focus();

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (client.Exist(Int32.Parse(txtDNI.Text)))
            {
                client.Dni = Int32.Parse(txtDNI.Text);
                client.Name = txtName.Text;
                client.Address = txtAddress.Text;
                client.Cod_neighbour = Int32.Parse(lstNeighbour.SelectedValue.ToString());
                client.Cod_activity = Int32.Parse(lstActivity.SelectedValue.ToString());
                client.Balance = Convert.ToInt32(txtBalance.Text);

                client.DeleteClient();

                MessageBox.Show("Eliminado correctamente");

                //Para que la grilla se actualice con el nuevo registro
                client.ShowClientFullInGrid(dgvClient);
            }
            else
            {
                MessageBox.Show("No se encontro el socio con el DNI ingresado");
                txtDNI.Focus();

            }
        }

        //El evento CellEnter ocurre cuando la celda seleccionada se modifica o cuando se selecciona alguna celda
        private void dgvClient_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtDNI.Text = dgvClient.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvClient.CurrentRow.Cells[1].Value.ToString();
            txtAddress.Text = dgvClient.CurrentRow.Cells[2].Value.ToString();
            lstNeighbour.Text = dgvClient.CurrentRow.Cells[3].Value.ToString();
            lstActivity.Text = dgvClient.CurrentRow.Cells[4].Value.ToString();
            txtBalance.Text = dgvClient.CurrentRow.Cells[5].Value.ToString();
        }

        private void txtDNISearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = client.DataBase.Tables["Socio"].DefaultView;
            dv.RowFilter = String.Format("convert(DNI, 'System.String') LIKE '*{0}*'", txtDNISearch.Text);
            dgvClient.DataSource = dv;

        }
    }
}
