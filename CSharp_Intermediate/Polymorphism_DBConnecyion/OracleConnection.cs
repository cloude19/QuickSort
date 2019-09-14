using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace Polymorphism_DBConnection
{
    class OracleConnection : DbConnection
    {
        public OracleConnection(string connectionString)
            :base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            WriteLine("Open Oracle connection");
        }

        public override void CloseConnection()
        {
            WriteLine("Close Oracle connection");
        }
    }
}
