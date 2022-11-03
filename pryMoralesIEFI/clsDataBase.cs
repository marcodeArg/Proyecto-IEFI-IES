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

        public string tableName;
        private string stringConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_Clientes.mdb";
        private string sql;


        public OleDbConnection DbConnection { get; set; }
        public OleDbCommand DbCommand { get; set; }
        public OleDbDataAdapter DbAdapter { get; set; }
        public OleDbDataReader DbReader { get; set; }
        public DataSet DataBase { get; set; }

        public string TableName { get; set; }
        public string StringConection { get; }
        public string Sql { get; set; }

        public void ShowInGrid(DataGridView grid)
        {
            dbConnection = new OleDbConnection(stringConnection);
            sql = "SELECT * FROM Socio";

            try
            {
                dbConnection.Open();
                
                dbCommand = new OleDbCommand(sql, dbConnection);
                dbAdapter = new OleDbDataAdapter(dbCommand);
                dataBase = new DataSet();

                dbAdapter.Fill(dataBase, tableName);

                grid.DataSource = dataBase;
                grid.DataMember = tableName;

                dbConnection.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show("Erro:" + err.Message);
            }
        } 





    }
}
