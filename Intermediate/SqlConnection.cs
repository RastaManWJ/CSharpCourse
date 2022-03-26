using System;

namespace CSharpCourse.Intermediate
{
    public class SqlConnection : DatabaseConnection
    {
        public SqlConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            Console.WriteLine("Opening a SQL Connection");
        }

        public override void OpenConnection()
        {
            Console.WriteLine("Closing a SQL Connection");
        }
    }
}
