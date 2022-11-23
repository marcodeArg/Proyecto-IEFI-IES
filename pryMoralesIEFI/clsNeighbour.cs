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
    internal class clsNeighbour : clsDataBase
    {

        public clsNeighbour(string tn)
        {
            TableName = tn;
        }

        private int cod_neighbour;
        private string description;

        public int Cod_neighbour { get { return cod_neighbour; } set { cod_neighbour = value; } }
        public string Description { get { return description; } set { description = value; } }

        //Metodos

        public void InsertNeighbour()
        {
            Sql = "INSERT INTO Barrio (Detalle_Barrio) VALUES (@name)";

            DbConnection = new OleDbConnection(StringConnection);

            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(Sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@name", description);

                DbCommand.ExecuteNonQuery();

                DbConnection.Close();

                MessageBox.Show("Barrio agregado correctamente");

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);

            }
        }

        public void UpdateNeighbour()
        {
            Sql = "UPDATE Barrio SET Detalle_Barrio=@name WHERE Codigo_Barrio=@code";

            DbConnection = new OleDbConnection(StringConnection);

            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(Sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@name", description);
                DbCommand.Parameters.AddWithValue("@code", cod_neighbour);

                DbCommand.ExecuteNonQuery();

                DbConnection.Close();

                MessageBox.Show("Barrio modificado correctamente");

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);

            }
        }

        public void DeletNeighbour()
        {
            Sql = "DELETE FROM Barrio WHERE Codigo_Barrio=@code";

            DbConnection = new OleDbConnection(StringConnection);

            try
            {
                DbConnection.Open();

                DbCommand = new OleDbCommand(Sql, DbConnection);
                DbCommand.Parameters.AddWithValue("@code", cod_neighbour);

                DbCommand.ExecuteNonQuery();

                DbConnection.Close();

                MessageBox.Show("Barrio eliminado correctamente");

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);

            }
        }
    }
}
