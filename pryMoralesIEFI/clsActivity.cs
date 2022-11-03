using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Data.OleDb;

namespace pryMoralesIEFI
{
    internal class clsActivity : clsDataBase
    {
        private int cod_activity;
        private string description;

        public int Cod_activity { get; set; }
        public string Description { get; set; }
    }
}
