using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Net;
using System.Windows.Forms;
using System.Xml.Linq;

namespace pryMoralesIEFI
{
    internal class clsActivity : clsDataBase
    {
        public clsActivity(string tn)
        {
            TableName = tn;
        }

        private int cod_activity;
        private string description;

        public int Cod_activity { get { return cod_activity; } set { cod_activity = value; } }
        public string Description { get { return description; } set { description = value; } }

        
        public void InsertActivity()
        {
            Sql = "INSERT INTO Actividad (Detalle_Actividad) VALUES (@name)";

            DbConnection = new OleDbConnection(StringConnection);

            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(Sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@name", description);

                DbCommand.ExecuteNonQuery();

                DbConnection.Close();

                MessageBox.Show("Actividad agregada correctamente");

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);

            }
        }

        public void UpdateActivity()
        {
            Sql = "UPDATE Actividad SET Detalle_Actividad=@name WHERE Codigo_Actividad=@code";

            DbConnection = new OleDbConnection(StringConnection);

            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(Sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@name", description);
                DbCommand.Parameters.AddWithValue("@code", cod_activity);

                DbCommand.ExecuteNonQuery();

                DbConnection.Close();

                MessageBox.Show("Actividad modificada correctamente");

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);

            }
        }

        public void DeleteActivity()
        {
            Sql = "DELETE FROM Actividad WHERE Codigo_Actividad=@code";

            DbConnection = new OleDbConnection(StringConnection);

            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(Sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@code", cod_activity);

                DbCommand.ExecuteNonQuery();

                DbConnection.Close();

                MessageBox.Show("Actividad eliminada correctamente");

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);

            }
        }


    }
}
