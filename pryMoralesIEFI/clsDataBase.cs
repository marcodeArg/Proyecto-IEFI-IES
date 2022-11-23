using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

using System.Text.RegularExpressions;
using System.Diagnostics.Tracing;
using System.Drawing;

namespace pryMoralesIEFI
{
    internal class clsDataBase
    {
        //Variables para la base de datos
        private OleDbConnection dbConnection;
        private OleDbCommand dbCommand;
        private OleDbDataAdapter dbAdapter;
        private OleDbDataReader dbReader;
        private DataSet dataBase;

        private string tableName;
        private string stringConnection = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=BD_Clientes.mdb";
        private string sql;


        //Variables para otros metodos
        private int higher;
        private int lower;
        private decimal total = 0;
        private int counter = 0;

        //Metodos getter y setter para la base de datos
        public OleDbConnection DbConnection { get { return dbConnection; } set { dbConnection = value; } }
        public OleDbCommand DbCommand { get { return dbCommand; } set { dbCommand = value; } }
        public OleDbDataAdapter DbAdapter { get { return dbAdapter; } set { dbAdapter = value; } }
        public OleDbDataReader DbReader { get { return dbReader; } set { dbReader = value; } }
        public DataSet DataBase { get { return dataBase; } set { dataBase = value; } }


        public string TableName { get { return tableName; } set { tableName = value; } }
        public string StringConnection { get { return stringConnection; } }
        public string Sql { get { return sql; } set { sql = value; } }


        //Metodos getter y setter para otros metodos
        public int Higher { get { return higher; } set { higher = value; } }
        public int Lower { get { return lower; } set { lower = value; } }
        public decimal Total { get { return total; } set { total = value; } }
        public int Counter { get { return counter; } set { counter = value; } }


        //METODOS

        //Cargan una grilla, general
        public void ShowInGrid(DataGridView grid, string sqls)
        {
            dbConnection = new OleDbConnection(stringConnection);

            try
            {
                dbConnection.Open();
                
                dbCommand = new OleDbCommand(sqls, dbConnection);
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

        //Cargar una lista desplegable
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

        //Saber si un DNI ya existe para poder modificarlo o eliminarlo. Tambien para que no se ingrese un dni repetido
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

        //Transformar el codigo de indentificacion (Codigo_Barrio || Codigo_Actividad) a detalle (Detalle_Barrio || Detalle_Actividad)
        public string TransformCodeToDetail(int code, string tn)
        {
            OleDbConnection connection = new OleDbConnection(StringConnection);
            OleDbCommand command = new OleDbCommand("SELECT * FROM " + tn, connection);
            OleDbDataReader reader;
            string varDetail = "";

            try
            {
                connection.Open();
                reader = command.ExecuteReader();

                while (reader.Read() && Convert.ToInt32(reader["Codigo_" + tn]) != code)
                {
                    //Leer
                }

                varDetail = reader["Detalle_" + tn].ToString();

                reader.Close();
                connection.Close();


            }
            catch (Exception err)
            {
                MessageBox.Show("Se produjo un error(" + tn + "):\n" + err.Message);
            }

            return varDetail;
        }

        //Saber si una tabla tiene contenido
        public bool ExistContent()
        {
            dbConnection = new OleDbConnection(stringConnection);
            bool result = false;

            try
            {
                dbConnection.Open();

                dbCommand = new OleDbCommand(TableName, dbConnection);
                dbCommand.CommandType = CommandType.TableDirect;

                dbReader = dbCommand.ExecuteReader();

                if (dbReader.HasRows)
                {
                    result = true;
                }


                dbReader.Close();
                DbConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);
            }

            return result;
        }

        public bool ExistContent(string tn)
        {
            dbConnection = new OleDbConnection(stringConnection);
            bool result = false;

            try
            {
                dbConnection.Open();

                dbCommand = new OleDbCommand(tn, dbConnection);
                dbCommand.CommandType = CommandType.TableDirect;

                dbReader = dbCommand.ExecuteReader();

                if (dbReader.HasRows)
                {
                    result = true;
                }


                dbReader.Close();
                DbConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error:" + err.Message);
            }

            return result;
        }


        //Estilo de la grilla
        public void GridStyle(DataGridView grid)
        {

            //COLUMNAS
            //grid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            grid.AllowUserToResizeColumns = false;
            grid.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            grid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            grid.ColumnHeadersHeight = 25;
            grid.BorderStyle = BorderStyle.None;
            grid.EnableHeadersVisualStyles = false;

           

            //FILAS
            Padding newPadding = new Padding(2, 5, 20, 5);
            grid.RowTemplate.DefaultCellStyle.Padding = newPadding;
            grid.RowHeadersVisible = false;
            grid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            grid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grid.MultiSelect = false;
            grid.RowTemplate.Height = 35;
            grid.AllowUserToResizeRows = false;
        }


        //Manejo de inputs

        //Numeros naturales
        public bool IsNatural(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            return e.Handled;
        }

        //Numeros Racionales
        public bool IsRational(KeyPressEventArgs e, TextBox textbox)
        {
            string varNumbers = "0123456789";
            string varInput = textbox.Text;
            bool alreadyOne = false;


            //solo se puede poner - en la primera posicion. Solo se puede poner . luego de un numero
            if (varInput.Length == 0)
            {
                varNumbers += "-";
            } else
            {
                varNumbers += ".";
            }

            //Controlar que se introduzca solamente numeros, guion o punto
            foreach (char c in varNumbers)
            {
                if (e.KeyChar == c)
                {
                    e.Handled = false;
                    break;
                }
                else
                {
                    e.Handled = true;
                }
            }

            //Validar si ya se colocó un punto
            foreach (char c in varInput)
            {

                if (c == Convert.ToChar("."))
                {
                    alreadyOne = true;
                    break;
                }
            }

            //Permitir borrar
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
            }

            //Controlar que se pueda colocar un solo punto
            if (e.KeyChar == Convert.ToChar(".") && alreadyOne == true)
            {
                e.Handled = true;
            }

            return e.Handled;
        }

        //Letras
        public bool IsText(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }


            return e.Handled;
        }

        
    }
}
