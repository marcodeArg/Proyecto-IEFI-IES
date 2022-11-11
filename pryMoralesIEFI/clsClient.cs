using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Data.Common;
using System.Windows.Forms;
using System.Data.Odbc;

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

        private DataTable dt;


        public int Dni { get { return dni; } set { dni = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public int Cod_neighbour { get { return cod_neighbour; } set { cod_neighbour = value; } }
        public int Cod_activity { get { return cod_activity; } set { cod_activity = value; } }
        public int Balance { get { return balance; } set { balance = value; } }

        public DataTable Dt { get { return dt; } set { dt = value; } } 


        public void ShowClientFullInGrid(DataGridView grid)
        {
            DbConnection = new OleDbConnection(StringConnection);
            Sql = "SELECT Dni_Socio AS DNI,Nombre_Apellido AS Nombre,Direccion,Barrio.Detalle_Barrio AS Barrio,Actividad.Detalle_Actividad AS Actividad,Saldo " +
                "FROM ((Socio " +
                "INNER JOIN Barrio ON Socio.Codigo_Barrio = Barrio.Codigo_Barrio) " +
                "INNER JOIN Actividad ON Socio.Codigo_Actividad = Actividad.Codigo_Actividad)";

            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(Sql, DbConnection);

                DataBase = new DataSet();

                DbAdapter = new OleDbDataAdapter();
                DbAdapter.SelectCommand = DbCommand;
                DataBase = new DataSet();

                DbAdapter.Fill(DataBase, TableName);
                grid.DataSource = DataBase;
                grid.DataMember = TableName;

                DbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro:" + err.Message);
            }
        }

        public void InsertClient()
        {
            Sql = "INSERT INTO Socio (Dni_Socio, Nombre_Apellido, Direccion, Codigo_Barrio, Codigo_Actividad, Saldo) VALUES (@dni,@name,@address,@codNei,@codAct,@balance)";

            DbConnection = new OleDbConnection(StringConnection);


            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(Sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@dni", dni);
                DbCommand.Parameters.AddWithValue("@name", name);
                DbCommand.Parameters.AddWithValue("@address", address);
                DbCommand.Parameters.AddWithValue("@codNei", cod_neighbour);
                DbCommand.Parameters.AddWithValue("@codAct", cod_activity);
                DbCommand.Parameters.AddWithValue("@balance", balance);

                DbCommand.ExecuteNonQuery();

                DbConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);

            }
        }

        public void UpdateClient()
        {
            Sql = "UPDATE Socio SET Nombre_Apellido=@name,Direccion=@address,Codigo_Barrio=@codNei,Codigo_Actividad=@codAct,Saldo=@balance " +
                "WHERE Dni_Socio=@dni";

            DbConnection = new OleDbConnection(StringConnection);


            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(Sql, DbConnection);
                
                DbCommand.Parameters.AddWithValue("@name", name);
                DbCommand.Parameters.AddWithValue("@address", address);
                DbCommand.Parameters.AddWithValue("@codNei", cod_neighbour);
                DbCommand.Parameters.AddWithValue("@codAct", cod_activity);
                DbCommand.Parameters.AddWithValue("@balance", balance);
                DbCommand.Parameters.AddWithValue("@dni", dni);

                DbCommand.ExecuteNonQuery();

                DbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);

            }
        }

        public void DeleteClient()
        {
            Sql = "DELETE FROM Socio WHERE Dni_Socio=@dni";

            DbConnection = new OleDbConnection(StringConnection);

            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(Sql, DbConnection);

                DbCommand.Parameters.AddWithValue("@dni", dni);

                DbCommand.ExecuteNonQuery();

                DbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);

            }
        }   


    }
}
