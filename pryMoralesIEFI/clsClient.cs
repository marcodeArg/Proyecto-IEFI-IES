using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Data.Common;
using System.Reflection;
using System.Xml.Linq;

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

        //Mostrar toda la informacion de los clientes en una grilla, variante 1
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

        //Mostrar toda la informacion de los clientes en una grilla, variante 2
        public void ShowAllClients(DataGridView grid)
        {

            DbConnection = new OleDbConnection(StringConnection);
            Sql = "SELECT Dni_Socio AS DNI,Nombre_Apellido AS Nombre,Direccion,Codigo_Barrio AS Barrio,Codigo_Actividad AS Actividad,Saldo FROM Socio";
            int fg = 0;

            DbCommand = new OleDbCommand(Sql, DbConnection);


            try
            {
                DbConnection.Open();
                DbReader = DbCommand.ExecuteReader();

                while (DbReader.Read())
                {

                    grid.Rows.Add();

                    //PASAR TODO A UN ADAPTER Y DESPUES MANDARLO A LA GRID
                    grid.Rows[fg].Cells["DNI"].Value = Convert.ToInt32(DbReader["DNI"]);
                    grid.Rows[fg].Cells["Nombre"].Value = DbReader["Nombre"].ToString();
                    grid.Rows[fg].Cells["Direccion"].Value = DbReader["Direccion"].ToString();
                    grid.Rows[fg].Cells["Barrio"].Value = TransformCodeToDetail(Convert.ToInt32(DbReader["Barrio"]), "Barrio");
                    grid.Rows[fg].Cells["Actividad"].Value = TransformCodeToDetail(Convert.ToInt32(DbReader["Actividad"]), "Actividad");
                    grid.Rows[fg].Cells["Saldo"].Value = Convert.ToInt32(DbReader["Saldo"]);

                    fg++;
                }

            }
            catch (Exception err)
            {
                MessageBox.Show("Se produjo al cargar la información en la grilla:\n" + err.Message);
            }
        }

        //Obtener informacion sobre los saldos de los clientes (mayor, menor, cantidad, total)
        public void GetInfoClient()
        {

            DbConnection = new OleDbConnection(StringConnection);
            DbCommand = new OleDbCommand(Sql, DbConnection);

            DbConnection.Open();
            DbReader = DbCommand.ExecuteReader();


            //Para que agarre el primer registro
            if (DbReader.Read())
            {
                Higher = Convert.ToInt32(DbReader["Saldo"]);
                Lower = Convert.ToInt32(DbReader["Saldo"]);
            }

            DbReader.Close();
            DbReader = DbCommand.ExecuteReader();


            while (DbReader.Read())
            {
                int saldo = Convert.ToInt32(DbReader["Saldo"]);

                if (saldo > Higher)
                {
                    Higher = saldo;
                }

                if (saldo < Lower)
                {
                    Lower = saldo;
                }

                Total += saldo;
                Counter++;
            }

            DbReader.Close();
            DbConnection.Close();
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


       

        //Imprimir
        public void PrintGenericClient(PrintPageEventArgs e)
        {
            DbConnection = new OleDbConnection(StringConnection);
            DbCommand = new OleDbCommand(Sql, DbConnection);
            
            Font titleFont = new Font(FontFamily.GenericMonospace, 24, FontStyle.Bold);
            Font headerFont = new Font(FontFamily.GenericSansSerif, 16);
            Font textFont = new Font(FontFamily.GenericSansSerif, 12);

            try
            {
                DbConnection.Open();
                DbReader = DbCommand.ExecuteReader();

                //Titulo
                e.Graphics.DrawString("Clientes", titleFont, Brushes.Black, 100, 100);

                //Cabeceras
                e.Graphics.DrawString("DNI", headerFont, Brushes.Black, 100, 180);
                e.Graphics.DrawString("Nombre", headerFont, Brushes.Black, 210, 180);
                e.Graphics.DrawString("Saldo", headerFont, Brushes.Black, 400, 180);

                int f = 260;

                while (DbReader.Read())
                {
                    //Información
                    e.Graphics.DrawString(DbReader["DNI"].ToString(), textFont, Brushes.Black, 100, f);
                    e.Graphics.DrawString(DbReader["Nombre"].ToString(), textFont, Brushes.Black, 210, f);
                    e.Graphics.DrawString(DbReader["Saldo"].ToString(), textFont, Brushes.Black, 400, f);

                    f = f + 22;
                }

                DbReader.Close();
                DbConnection.Close();

                GetInfoClient();

                f += 35; 
                e.Graphics.DrawString("Total de saldos:", textFont, Brushes.Black, 100, f);
                e.Graphics.DrawString(Total.ToString("0.00"), textFont, Brushes.Black, 300, f);
                f += 22;
                e.Graphics.DrawString("Cantidad de clientes:", textFont, Brushes.Black, 100, f);
                e.Graphics.DrawString(Counter.ToString(), textFont, Brushes.Black, 300, f);
                f += 22;
                e.Graphics.DrawString("Promedio de saldos:", textFont, Brushes.Black, 100, f);
                e.Graphics.DrawString((Total / Counter).ToString("0.00"), textFont, Brushes.Black, 300, f);


            }
            catch (Exception err)
            {
                MessageBox.Show("Error al imprimir:" + err.Message);
            }
        }

        public void PrintSpecificClient(PrintPageEventArgs e, int dni)
        {
            DbConnection = new OleDbConnection(StringConnection);
            DbCommand = new OleDbCommand("SELECT * FROM Socio", DbConnection);

            Font titleFont = new Font(FontFamily.GenericMonospace, 24, FontStyle.Bold);
            Font headerFont = new Font(FontFamily.GenericSansSerif, 16);
            Font textFont = new Font(FontFamily.GenericSansSerif, 12);

            try
            {
                DbConnection.Open();
                DbReader = DbCommand.ExecuteReader();

                //Titulo
                e.Graphics.DrawString("Cliente solicitado", titleFont, Brushes.Black, 100, 100);

                //Cabeceras
                e.Graphics.DrawString("DNI", headerFont, Brushes.Black, 100, 180);
                e.Graphics.DrawString("Nombre", headerFont, Brushes.Black, 300, 180);
                e.Graphics.DrawString("Actividad", headerFont, Brushes.Black, 500, 180);
                e.Graphics.DrawString("Saldo", headerFont, Brushes.Black, 700, 180);

                while (DbReader.Read() && Convert.ToInt32(DbReader["Dni_Socio"]) != dni)
                {
                    //Leer
                }

                //Información
                e.Graphics.DrawString(DbReader["Dni_Socio"].ToString(), textFont, Brushes.Black, 100, 260);
                e.Graphics.DrawString(DbReader["Nombre_Apellido"].ToString(), textFont, Brushes.Black, 300, 260);
                e.Graphics.DrawString(TransformCodeToDetail(Convert.ToInt32(DbReader["Codigo_Actividad"]), "Actividad"), textFont, Brushes.Black, 500, 260);
                e.Graphics.DrawString(DbReader["Saldo"].ToString(), textFont, Brushes.Black, 700, 260);

                DbReader.Close();
                DbConnection.Close();

            }
            catch (Exception err)
            {
                MessageBox.Show("Error al imprimir:" + err.Message);
            }
        }

        public void PrintAllClients(PrintPageEventArgs e)
        {
            DbConnection = new OleDbConnection(StringConnection);
            DbCommand = new OleDbCommand("SELECT * FROM Socio", DbConnection);

            Font titleFont = new Font(FontFamily.GenericMonospace, 20, FontStyle.Bold);
            Font headerFont = new Font(FontFamily.GenericSansSerif, 14);
            Font textFont = new Font(FontFamily.GenericSansSerif, 10);

            try
            {
                DbConnection.Open();
                DbReader = DbCommand.ExecuteReader();

                //Titulo
                e.Graphics.DrawString("Clientes", titleFont, Brushes.Black, 100, 100);

                //Cabeceras
                e.Graphics.DrawString("DNI", headerFont, Brushes.Black, 100, 180);
                e.Graphics.DrawString("Nombre", headerFont, Brushes.Black, 180, 180);
                e.Graphics.DrawString("Direccion", headerFont, Brushes.Black, 320, 180);
                e.Graphics.DrawString("Barrio", headerFont, Brushes.Black, 490, 180);
                e.Graphics.DrawString("Actividad", headerFont, Brushes.Black, 600, 180);
                e.Graphics.DrawString("Saldo", headerFont, Brushes.Black, 700, 180);

                int f = 260;

                while (DbReader.Read())
                {
                    //Información
                    e.Graphics.DrawString(DbReader["Dni_Socio"].ToString(), textFont, Brushes.Black, 100, f);
                    e.Graphics.DrawString(DbReader["Nombre_Apellido"].ToString(), textFont, Brushes.Black, 180, f);
                    e.Graphics.DrawString(DbReader["Direccion"].ToString(), textFont, Brushes.Black, 320, f);
                    e.Graphics.DrawString(TransformCodeToDetail(Convert.ToInt32(DbReader["Codigo_Barrio"]), "Barrio"), textFont, Brushes.Black, 490, f);
                    e.Graphics.DrawString(TransformCodeToDetail(Convert.ToInt32(DbReader["Codigo_Actividad"]), "Actividad"), textFont, Brushes.Black, 600, f);
                    e.Graphics.DrawString(DbReader["Saldo"].ToString(), textFont, Brushes.Black, 700, f);

                    f = f + 22;
                }

                DbReader.Close();
                DbConnection.Close();

                //GetInfoClient();

                f += 35;
                e.Graphics.DrawString("Cantidad de clientes:", textFont, Brushes.Black, 100, f);
                e.Graphics.DrawString(Counter.ToString(), textFont, Brushes.Black, 320, f);
                f += 22;
                e.Graphics.DrawString("Total de saldos:", textFont, Brushes.Black, 100, f);
                e.Graphics.DrawString(Total.ToString("0.00"), textFont, Brushes.Black, 320, f);


            }
            catch (Exception err)
            {
                MessageBox.Show("Error al imprimir:" + err.Message);
            }
        }

        //Generar reporte
        public void GenerateGenericReport(string name)
        {
            DbConnection = new OleDbConnection(StringConnection);
            DbCommand = new OleDbCommand(Sql, DbConnection);

            try
            {
                DbConnection.Open();
                DbReader = DbCommand.ExecuteReader();

                StreamWriter sw = new StreamWriter("ReportePor" + name + ".csv", false, Encoding.UTF8);
                sw.WriteLine("Reporte por " + name + "!");
                sw.WriteLine("");
                sw.WriteLine("DNI;Nombre;Saldo");

                while (DbReader.Read())
                {
                    sw.WriteLine(DbReader["DNI"].ToString() + ";" + DbReader["Nombre"] + ";" + DbReader["Saldo"].ToString());
                }
                
                DbReader.Close();
                DbConnection.Close();

                //Obtener mayor, menor, total y cantidad de saldos
                GetInfoClient();

                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("Total de saldos:;;" + Total);
                sw.WriteLine("Cantidad de clientes:;;" + Counter);
                sw.WriteLine("Promedio de saldos:;;" + (Total / Counter).ToString("0.00"));

                sw.Close();


                MessageBox.Show("Reporte generado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show("Se produjo un error:" + err.Message);
            }
        }

        public void GenerateSpecificReport(int dni)
        {
            DbConnection = new OleDbConnection(StringConnection);
            DbCommand = new OleDbCommand("SELECT * FROM Socio", DbConnection);

            try
            {
                DbConnection.Open();
                DbReader = DbCommand.ExecuteReader();

                StreamWriter sw = new StreamWriter("ReporteClienteEspecifico.csv", false, Encoding.UTF8);
                

                while (DbReader.Read() && Convert.ToInt32(DbReader["Dni_Socio"]) != dni)
                {
                    //Leer
                }

                sw.WriteLine("Reporte de " + DbReader["Nombre_Apellido"].ToString());
                sw.WriteLine("");
                sw.WriteLine("DNI;Nombre;Actividad;Saldo");

                sw.Write(DbReader["Dni_Socio"].ToString());
                sw.Write(";");
                sw.Write(DbReader["Nombre_Apellido"].ToString());
                sw.Write(";");
                sw.Write(TransformCodeToDetail(Convert.ToInt32(DbReader["Codigo_Actividad"].ToString()), "Actividad"));
                sw.Write(";");
                sw.Write(DbReader["Saldo"].ToString());

                sw.Close();
                DbReader.Close();
                DbConnection.Close();

                MessageBox.Show("Reporte generado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show("Se produjo un error:" + err.Message);
            }
        }
        
        public void GenerateAllReport()
        {
            DbConnection = new OleDbConnection(StringConnection);
            DbCommand = new OleDbCommand("SELECT * FROM Socio", DbConnection);

            try
            {
                DbConnection.Open();
                DbReader = DbCommand.ExecuteReader();

                StreamWriter sw = new StreamWriter("ReporteGeneral.csv", false, Encoding.UTF8);
                sw.WriteLine("Reporte de todos los clientes!");
                sw.WriteLine("");
                sw.WriteLine("DNI;Nombre;Direccion;Barrio;Actividad;Saldo");

                while (DbReader.Read())
                {
                    sw.Write(DbReader["Dni_Socio"].ToString());
                    sw.Write(";");
                    sw.Write(DbReader["Nombre_Apellido"].ToString());
                    sw.Write(";");
                    sw.Write(DbReader["Direccion"].ToString());
                    sw.Write(";");
                    sw.Write(TransformCodeToDetail(Convert.ToInt32(DbReader["Codigo_Barrio"].ToString()), "Barrio"));
                    sw.Write(";");
                    sw.Write(TransformCodeToDetail(Convert.ToInt32(DbReader["Codigo_Actividad"].ToString()), "Actividad"));
                    sw.Write(";");
                    sw.WriteLine(DbReader["Saldo"].ToString());
                }

                DbReader.Close();
                DbConnection.Close();

                //Obtener mayor, menor, total y cantidad de saldos
                //GetInfoClient();

                sw.WriteLine("");
                sw.WriteLine("");
                sw.WriteLine("Cantidad de clientes:;;" + Counter);
                sw.WriteLine("Total de saldos:;;" + Total.ToString("0.00"));
                sw.Close();


                MessageBox.Show("Reporte generado correctamente");
            }
            catch (Exception err)
            {
                MessageBox.Show("Se produjo un error:" + err.Message);
            }
        }

        
    }
}
