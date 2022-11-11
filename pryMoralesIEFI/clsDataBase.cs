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
        public void ShowInGrid(DataGridView grid)
        {
            dbConnection = new OleDbConnection(stringConnection);
            sql = "SELECT * FROM "+ tableName;

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


        //PASARLO A LA CLASE CLIENTE
        

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


        public bool Exist(int cod)
        {
            dbConnection = new OleDbConnection(stringConnection);

            try
            {
                dbConnection.Open();

                dbCommand = new OleDbCommand(tableName, dbConnection);
                dbCommand.CommandType = CommandType.TableDirect;

                dbReader = dbCommand.ExecuteReader();

                if (dbReader.HasRows)
                {
                    while (dbReader.Read())
                    {
                        if (Convert.ToInt32(dbReader.GetValue(0)) == cod)
                        {
                            return true;
                        }
                    }
                }
                else
                {
                    return false;
                }

                dbReader.Close();
                DbConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);
            }

            //Suponiendo que no tiene filas
            return false;

        }





    }
}
