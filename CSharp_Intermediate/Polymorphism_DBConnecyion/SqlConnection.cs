using System;
using System.Collections.Generic;
using System.Text;

using static System.Console;

namespace Polymorphism_DBConnection
{
    class SqlConnection : DbConnection
    {
        public SqlConnection(string connectionString)
            :base(connectionString)
        {

        }
        public override void OpenConnection()
        {
            WriteLine("Open Sql connection");
        }

        public override void CloseConnection()
        {
            WriteLine("Close Sql connection");
        }
    }
}
