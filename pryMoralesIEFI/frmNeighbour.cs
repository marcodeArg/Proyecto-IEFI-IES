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
    public partial class frmNeighbour : Form
    {
        public frmNeighbour()
        {
            InitializeComponent();
        }

        clsNeighbour neighbour = new clsNeighbour("Barrio");
        private string sql = "SELECT Codigo_Barrio AS Codigo, Detalle_Barrio AS Nombre FROM Barrio";

        private void frmNeighbour_Load(object sender, EventArgs e)
        {
            neighbour.ShowInGrid(dgvNeighbour, sql);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            neighbour.Description = txtName.Text;
            neighbour.InsertNeighbour();

            neighbour.ShowInGrid(dgvNeighbour, sql);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            var eleccion = MessageBox.Show("¿Seguro desea actualizar este barrio? Se actualizarán todos los registros que contengan dicho barrio", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (eleccion == DialogResult.Yes)
            {

                neighbour.Cod_neighbour = Int32.Parse(txtCode.Text);
                neighbour.Description = txtName.Text;
                neighbour.UpdateNeighbour();

                neighbour.ShowInGrid(dgvNeighbour, sql);
            }
            else
            {
                MessageBox.Show("Operación cancelada");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var eleccion = MessageBox.Show("¿Seguro desea eliminar este barrio? Se eliminarán todos los registros que contengan dicho barrio", "Advertencia", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (eleccion == DialogResult.Yes)
            {
                neighbour.Cod_neighbour = Int32.Parse(txtCode.Text);
                neighbour.DeletNeighbour();

                neighbour.ShowInGrid(dgvNeighbour, sql);
            }
            else
            {
                MessageBox.Show("Operación cancelada");
            }
        }

        private void dgvNeighbour_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgvNeighbour.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvNeighbour.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtCodeSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = neighbour.DataBase.Tables["Barrio"].DefaultView;
            dv.RowFilter = String.Format("convert(Codigo_Barrio, 'System.String') LIKE '*{0}*'", txtCodeSearch.Text);
            dgvNeighbour.DataSource = dv;
        }
    }
}
