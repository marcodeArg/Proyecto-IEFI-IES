using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

namespace pryMoralesIEFI
{
    internal class clsDataBase
    {
        private OleDbConnection dbConnection;
        private OleDbCommand dbCommand;
        private OleDbDataAdapter dbAdapter;
        private OleDbDataReader dbReader;
        private DataSet dataBase;

        private string tableName;
        private string stringConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_Clientes.mdb";
        private string sql;


        public OleDbConnection DbConnection { get { return dbConnection; } set { dbConnection = value; } }
        public OleDbCommand DbCommand { get { return dbCommand; } set { dbCommand = value; } }
        public OleDbDataAdapter DbAdapter { get { return dbAdapter; } set { dbAdapter = value; } }
        public OleDbDataReader DbReader { get { return dbReader; } set { dbReader = value; } }
        public DataSet DataBase { get { return dataBase; } set { dataBase = value; } }


        public string TableName { get { return tableName; } set { tableName = value; } }
        public string StringConnection { get { return stringConnection; } }
        public string Sql { get { return sql; } set { sql = value; } }

        //METODOS
        public void ShowInGrid(DataGridView grid, string tn)
        {
            dbConnection = new OleDbConnection(stringConnection);
            sql = "SELECT * FROM "+ tn;

            try
            {
                dbConnection.Open();
                
                dbCommand = new OleDbCommand(sql, dbConnection);
                dbAdapter = new OleDbDataAdapter(dbCommand);
                dataBase = new DataSet();

                dbAdapter.Fill(dataBase, tableName);

                grid.DataSource = dataBase.Tables[tableName];

                dbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro:" + err.Message);
            }
        }

        public void ShowClientFullInGrid(DataGridView grid)
        {
            dbConnection = new OleDbConnection(stringConnection);
            sql = "SELECT Dni_Socio AS DNI,Nombre_Apellido AS Nombre,Direccion,Barrio.Detalle_Barrio AS Barrio,Actividad.Detalle_Actividad AS Actividad,Saldo " +
                "FROM ((Socio " +
                "INNER JOIN Barrio ON Socio.Codigo_Barrio = Barrio.Codigo_Barrio) " +
                "INNER JOIN Actividad ON Socio.Codigo_Actividad = Actividad.Codigo_Actividad)";

            try
            {
                dbConnection.Open();

                dbCommand = new OleDbCommand(sql, dbConnection);

                DataTable dt = new DataTable();

                dbAdapter = new OleDbDataAdapter();
                dbAdapter.SelectCommand = dbCommand;
                dataBase = new DataSet();

                dbAdapter.Fill(dt);
                grid.DataSource =dt;

                dbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro:" + err.Message);
            }
        }


        //public DataTable ListarProductos()
        //{
        //    dbConnection = new OleDbConnection(stringConnection);
        //    dbCommand = new OleDbCommand();
            
        //    //AHORA ESTA ANDANDO PERO SOLO CUANDO USO UN SOLO INNER JOIN

        //    dbConnection.Open();
        //    DataTable Tabla = new DataTable();
        //    dbCommand.Connection = dbConnection;

        //    dbCommand.CommandText = "SELECT Dni_Socio,Nombre_Apellido,Direccion,Barrio.Detalle_Barrio,Actividad.Detalle_Actividad,Saldo " +
        //        "FROM ((Socio " + 
        //        "INNER JOIN Barrio ON Socio.Codigo_Barrio = Barrio.Codigo_Barrio) " +
        //        "INNER JOIN Actividad ON Socio.Codigo_Actividad = Actividad.Codigo_Actividad)";
        //    dbCommand.CommandType = CommandType.Text;

        //    dbReader = dbCommand.ExecuteReader();
        //    Tabla.Load(dbReader);
        //    dbReader.Close();
        //    dbConnection.Close();
        //    return Tabla;
        //}

        //Se puede hacer que lea la tabla de socios y despues mientras que no sea fin de archivo, dentro del while, lea la tabla de actividad y compare 
        //con el id que esta en la tabla de socios con el de actividad y lo remplce. Despues con el baarrio hacer exactamente lo mismo


        public void ShowInList(ComboBox list, string column, string id)
        {
            try
            {
                dbConnection = new OleDbConnection(stringConnection);
                dbConnection.Open();

                dbCommand = new OleDbCommand(tableName, dbConnection);
                dbCommand.CommandType = CommandType.TableDirect;
                dbCommand.CommandText = tableName;

                dbAdapter = new OleDbDataAdapter(dbCommand);
                dataBase = new DataSet();

                dbAdapter.Fill(dataBase, tableName);

                list.DataSource = dataBase.Tables[tableName];
                list.DisplayMember = column;
                list.ValueMember = id;

                dbConnection.Close();
                dbAdapter.Dispose();
            }
            catch (Exception err)
            {
                MessageBox.Show("Error", err.Message);
            }
        }





    }
}
