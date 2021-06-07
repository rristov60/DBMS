using System;
using System.Collections.Generic;
using System.Text;
using System.Data;

namespace SQL
{
    public class CurrentTable
    {
        public static DataTable dtb = new DataTable();
        public static bool Sucess = true;
        public static string tableKind;
        public static bool filled = true;
        public static DataTable reserve = new DataTable();
    }
}
