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

namespace pryMoralesIEFI
{
    public partial class frmConsultCli : Form
    {
        public frmConsultCli()
        {
            InitializeComponent();
        }

        clsClient client = new clsClient("Socio");
        private int varSelec;

        private void frmConsultCli_Load(object sender, EventArgs e)
        {
            if (client.ExistContent() && client.ExistContent("Actividad"))
            {

                //Cargar en la lista todos los dni
                client.ShowInList(lstSelec, "Dni_Socio", "Dni_Socio");

                varSelec = Convert.ToInt32(lstSelec.SelectedValue);

                //Mostrar informacion del DNI
                int codigoAct = FindClient(varSelec);
                txtActivity.Text = client.TransformCodeToDetail(codigoAct, "Actividad");

            }
            else
            {
                MessageBox.Show("Primero debe cargar con datos las tablas 'Socio' y 'Actividad'");
                btnExport.Enabled = false;
                btnPrint.Enabled = false;
            }
        }

        private void lstSelec_SelectionChangeCommitted(object sender, EventArgs e)
        {

            varSelec = Convert.ToInt32(lstSelec.SelectedValue);

            //Mostrar informacion del DNI
            int codigoAct = FindClient(varSelec);

            txtActivity.Text = client.TransformCodeToDetail(codigoAct, "Actividad");
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
            client.PrintSpecificClient(e, varSelec);
        }


        private void btnExport_Click(object sender, EventArgs e)
        {
            client.GenerateSpecificReport(varSelec);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Buscar la informacion del cliente y devolver el codigo de actividad
        private int FindClient(int choice)
        {
            client.DbConnection = new OleDbConnection(client.StringConnection);
            client.DbCommand = new OleDbCommand("SELECT * FROM Socio", client.DbConnection);
            int varCodeAct = -1;

            try
            {
                client.DbConnection.Open();
                client.DbReader = client.DbCommand.ExecuteReader();

                //Encontrar el dni seleccionado usando busqueda rapida
                while (client.DbReader.Read() && Convert.ToInt32(client.DbReader["Dni_Socio"]) != choice)
                {
                }

                txtName.Text = client.DbReader["Nombre_Apellido"].ToString();
                txtBalance.Text = client.DbReader["Saldo"].ToString();
                varCodeAct = Convert.ToInt32(client.DbReader["Codigo_Actividad"]);

                client.DbReader.Close();
                client.DbConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Se produjo un error al buscar el cliente solicitado: \n" + err.Message);
            }

            return varCodeAct;
        }
    }
}
