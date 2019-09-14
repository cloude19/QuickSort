using System;
using System.Collections.Generic;
using System.Text;

namespace Polymorphism_DBConnection
{
    class DbCommand
    {
        private DbConnection _connection { get; set; }
        private string _instruction { get; set; }

        /// <summary>
        /// Creates a DbCommand from an connection and instruction
        /// </summary>
        /// <param name="connection"></param>
        /// <param name="insturction"></param>
        public DbCommand(DbConnection connection, string insturction)
        {
            if(connection == null || insturction == null)
            {
                throw new Exception("A connection and instruction is needed for a DbCommand");
            }

            _connection = connection;
            _instruction = insturction;

        }

        /// <summary>
        /// Open run with the instruction using the provided SQL connection. 
        /// </summary>
        public void Execute()
        {
            //open the connection
            _connection.OpenConnection();

            //run the instruciton
            Console.WriteLine(_instruction);

            //close connection
            _connection.CloseConnection();
        }

    }
}
