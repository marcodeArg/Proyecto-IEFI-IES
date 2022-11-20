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

        private void frmConsultCli_Load(object sender, EventArgs e)
        {
            //Cargar en la lista todos los dni
            client.ShowInList(lstSelec, "Dni_Socio", "Dni_Socio");

            int varSelec = Convert.ToInt32(lstSelec.SelectedValue);

            //Mostrar informacion del DNI
            int codigoAct = FindClient(varSelec);
            FindActivity(codigoAct);
        }

        private void lstSelec_SelectionChangeCommitted(object sender, EventArgs e)
        {

            int varSelec = Convert.ToInt32(lstSelec.SelectedValue);

            //Mostrar informacion del DNI
            int codigoAct = FindClient(varSelec);
            FindActivity(codigoAct);
        }

        //Buscar la informacion del cliente y devolver el codigo de actividad
        private int FindClient(int choice)
        {
            client.DbConnection = new OleDbConnection(client.StringConnection);
            client.DbCommand = new OleDbCommand("SELECT * FROM Socio", client.DbConnection);
            int varCodeAct;

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

                return varCodeAct;
            }
            catch (Exception err)
            {
                MessageBox.Show("Se produjo un error al buscar el cliente solicitado: \n" + err.Message);
            }

            return -1;
        }

        //Buscar la actividad correspondiente usando el codigo del cliente
        private void FindActivity(int codeActivity)
        {
            //Aca podria crear una instancia de la clase Actividad, pero como no necesito ningun metodo de la clase
            //uso la clase cliente y listo.

            client.DbConnection = new OleDbConnection(client.StringConnection);
            client.DbCommand = new OleDbCommand("SELECT * FROM Actividad", client.DbConnection);

            try
            {
                client.DbConnection.Open();
                client.DbReader = client.DbCommand.ExecuteReader();

                //Encontrar el dni seleccionado usando busqueda rapida
                while (client.DbReader.Read() && Convert.ToInt32(client.DbReader["Codigo_Actividad"]) != codeActivity)
                {
                }

                txtActivity.Text = client.DbReader["Detalle_Actividad"].ToString();

                client.DbReader.Close();
                client.DbConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Se produjo un error al buscar la actividad: \n" + err.Message);
            }
        }

    }
}
