﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

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

        public int Cod_activity { get; set; }
        public string Description { get; set; }
    }
}
