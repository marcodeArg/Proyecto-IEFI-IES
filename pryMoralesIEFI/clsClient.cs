using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace pryMoralesIEFI
{
    internal class clsClient : clsDataBase
    {
        public clsClient(string ass)
        {
            tableName = ass;
        }

        private int dni;
        private string name;
        private string address;
        private int cod_neighbour;
        private int cod_activity;
        private int balance;


        public int Dni { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public int Cod_neighbour { get; set; }
        public int Cod_activity { get; set; }
        public int Balance { get; set; }

    }
}
