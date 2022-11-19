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

        //Para leer la tabla actividad
        private OleDbCommand dbCommandNeig;
        private OleDbDataReader dbReaderNeig;


        private int varCodeAct;
        private bool founded;
        private bool neiFounded;


        private void frmConsultCli_Load(object sender, EventArgs e)
        {

            //Cargar en la lista todos los dni
            client.ShowInList(lstSelec, "Dni_Socio", "Dni_Socio");

            int varSelec = Convert.ToInt32(lstSelec.SelectedValue);
            
            founded = false;
            neiFounded = false;



            try
            {
                client.DbConnection = new OleDbConnection(client.StringConnection);
                client.DbCommand = new OleDbCommand("SELECT * FROM Socio", client.DbConnection);
                dbCommandNeig = new OleDbCommand("SELECT * FROM Actividad", client.DbConnection);


                client.DbConnection.Open();
                client.DbReader = client.DbCommand.ExecuteReader();





                while (client.DbReader.Read() && Convert.ToInt32(client.DbReader["Dni_Socio"]) == varSelec)
                {
                }

                txtName.Text = client.DbReader["Nombre_Apellido"].ToString();
                txtBalance.Text = client.DbReader["Saldo"].ToString();
                varCodeAct = Convert.ToInt32(client.DbReader["Codigo_Actividad"]);


                dbReaderNeig = dbCommandNeig.ExecuteReader();

                while (dbReaderNeig.Read() && varCodeAct == Convert.ToInt32(dbReaderNeig["Codigo_Actividad"]))
                {
                }

                txtActivity.Text = dbReaderNeig["Detalle_Actividad"].ToString();

                dbReaderNeig.Close();
                client.DbReader.Close();
                client.DbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }





        private void lstSelec_SelectionChangeCommitted(object sender, EventArgs e)
        {
            int varSelec = Convert.ToInt32(lstSelec.SelectedValue);

            founded = false;
            neiFounded = false;



            try
            {
                client.DbConnection = new OleDbConnection(client.StringConnection);
                client.DbCommand = new OleDbCommand("SELECT * FROM Socio", client.DbConnection);
                dbCommandNeig = new OleDbCommand("SELECT * FROM Actividad", client.DbConnection);


                client.DbConnection.Open();
                client.DbReader = client.DbCommand.ExecuteReader();





                while (client.DbReader.Read() && Convert.ToInt32(client.DbReader["Dni_Socio"]) == varSelec)
                {
                }

                txtName.Text = client.DbReader["Nombre_Apellido"].ToString();
                txtBalance.Text = client.DbReader["Saldo"].ToString();
                varCodeAct = Convert.ToInt32(client.DbReader["Codigo_Actividad"]);


                dbReaderNeig = dbCommandNeig.ExecuteReader();

                while (dbReaderNeig.Read() && varCodeAct == Convert.ToInt32(dbReaderNeig["Codigo_Actividad"]))
                {
                }

                txtActivity.Text = dbReaderNeig["Detalle_Actividad"].ToString();

                dbReaderNeig.Close();
                client.DbReader.Close();
                client.DbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }





            //int varSelec = Convert.ToInt32(lstSelec.SelectedValue);
            //founded = false;
            //neiFounded = false;

            //try
            //{
            //    client.DbConnection = new OleDbConnection(client.StringConnection);
            //    client.DbCommand = new OleDbCommand("SELECT * FROM Socio", client.DbConnection);

            //    client.DbConnection.Open();
            //    client.DbReader = client.DbCommand.ExecuteReader();


            //    while (client.DbReader.Read() && founded == false)
            //    {
            //        if (Convert.ToInt32(client.DbReader["Dni_Socio"]) == varSelec)
            //        {

            //            txtName.Text = client.DbReader["Nombre_Apellido"].ToString();
            //            txtBalance.Text = client.DbReader["Saldo"].ToString();
            //            varCodeAct = Convert.ToInt32(client.DbReader["Codigo_Actividad"]);

            //            dbReaderNeig = dbCommandNeig.ExecuteReader();

            //            while (dbReaderNeig.Read() && neiFounded == false)
            //            {
            //                if (varCodeAct == Convert.ToInt32(dbReaderNeig["Codigo_Actividad"]))
            //                {
            //                    txtActivity.Text = dbReaderNeig["Detalle_Actividad"].ToString();
            //                    neiFounded = true;
            //                }


            //            }
            //            dbReaderNeig.Close();
            //            founded = true;
            //        }
            //    }

            //    client.DbReader.Close();
            //    client.DbConnection.Close();

        }
            catch (Exception)
            {

                throw;
            }
        }

    }
}
