using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_DBConnection
{
    public abstract class DbConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DbConnection(string connectionString)
        {
            if(connectionString == null)
            {
                throw new Exception("DbConnections must have a connection string");
            }
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();

       
    }
}
