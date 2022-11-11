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
    public partial class frmActivity : Form
    {
        public frmActivity()
        {
            InitializeComponent();
        }

        clsActivity activity = new clsActivity("Actividad");



        private void frmActivity_Load(object sender, EventArgs e)
        {
            activity.ShowInGrid(dgvActivities);
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {

            //activity.Cod_activity = Int32.Parse(txtCode.Text);
            activity.Description = txtName.Text;
            activity.InsertActivity();

            activity.ShowInGrid(dgvActivities);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            activity.Cod_activity = Int32.Parse(txtCode.Text);
            activity.Description = txtName.Text;
            activity.UpdateActivity();

            activity.ShowInGrid(dgvActivities);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            activity.Cod_activity = Int32.Parse(txtCode.Text);
            activity.DeleteActivity();

            activity.ShowInGrid(dgvActivities);
        }

        private void dgvActivities_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtCode.Text = dgvActivities.CurrentRow.Cells[0].Value.ToString();
            txtName.Text = dgvActivities.CurrentRow.Cells[1].Value.ToString();
        }

        private void txtCodeSearch_TextChanged(object sender, EventArgs e)
        {
            DataView dv = activity.DataBase.Tables["Actividad"].DefaultView;
            dv.RowFilter = String.Format("convert(Codigo_Actividad, 'System.String') LIKE '*{0}*'", txtCodeSearch.Text);
            dgvActivities.DataSource = dv;
        }
    }
}
