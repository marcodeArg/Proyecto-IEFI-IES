using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Data.Common;
using System.Windows.Forms;

namespace pryMoralesIEFI
{
    internal class clsClient : clsDataBase
    {
        //CONSTRUCTOR
        public clsClient(string tn)
        {
            TableName = tn;
        }

        private int dni;
        private string name;
        private string address;
        private int cod_neighbour;
        private int cod_activity;
        private int balance;


        public int Dni { get { return dni; } set { dni = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int Cod_neighbour { get { return cod_neighbour; } set { cod_neighbour = value; } }
        public int Cod_activity { get { return cod_activity; } set { cod_activity = value; } }
        public int Balance { get { return balance; } set { balance = value; } }


        public void InsertClient()
        {
            string sql = "";
            sql = "INSERT INTO Socio (Dni_Socio, Nombre_Apellido, Direccion, Codigo_Barrio, Codigo_Actividad, Saldo) VALUES (@dni,@name,@address,@codNei,@codAct,@balance)";

            DbConnection = new OleDbConnection(StringConnection);


            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@dni", dni);
                DbCommand.Parameters.AddWithValue("@name", name);
                DbCommand.Parameters.AddWithValue("@address", address);
                DbCommand.Parameters.AddWithValue("@codNei", cod_neighbour);
                DbCommand.Parameters.AddWithValue("@codAct", cod_activity);
                DbCommand.Parameters.AddWithValue("@balance", balance);

                DbCommand.CommandText = sql;
                DbCommand.ExecuteNonQuery();

                DbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);

            }

            // PARA UPDATE LO MISMO SOLAMENTE CAMBIANDO SQL
        }


    }
}
