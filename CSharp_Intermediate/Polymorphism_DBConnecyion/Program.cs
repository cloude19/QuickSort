using System;

namespace Polymorphism_DBConnection
{
    class Program
    {
        static void Main(string[] args)
        {
            DbCommand command = new DbCommand(new SqlConnection("localhost/something"), "select mood where thePain = false");

            command.Execute();
        }
    }
}
