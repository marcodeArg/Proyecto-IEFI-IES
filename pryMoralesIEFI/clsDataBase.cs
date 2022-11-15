﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;

using System.Text.RegularExpressions;


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
        private int total = 0;
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
        public int Total { get { return total; } set { total = value; } }
        public int Counter { get { return counter; } set { counter = value; } }


        //METODOS
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



        //Manejo de inputs

        //Numeros enteros
        public bool IsNumber(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            return e.Handled;
        }


        //Letras y espacio
        public bool IsText(KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
            }


            return e.Handled;
        }






        

        //MOVER A CLASES
        public void GetInfoClient()
        {
            dbConnection = new OleDbConnection(stringConnection);
            dbCommand = new OleDbCommand(Sql, dbConnection);

            dbConnection.Open();
            dbReader = dbCommand.ExecuteReader();


            //Para que agarre el primer registro
            if(dbReader.Read())
            {
                higher = Convert.ToInt32(dbReader.GetValue(2));
                lower = Convert.ToInt32(dbReader.GetValue(2));
            }

            dbReader.Close();
            dbReader = dbCommand.ExecuteReader();


            while (dbReader.Read())
            {
                int saldo = Convert.ToInt32(dbReader["Saldo"]);

                if (saldo > higher)
                {
                    higher = saldo;
                }

                if (saldo < lower)
                {
                    lower = saldo;
                }

                total += saldo;
                counter++;
            }

            dbReader.Close();
            dbConnection.Close();
        }
    }
}
