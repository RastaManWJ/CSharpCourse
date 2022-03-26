using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Intermediate
{
    public abstract class DatabaseConnection
    {
        public string ConnectionString { get; set; }
        public TimeSpan Timeout { get; set; }

        public DatabaseConnection(string connectionString)
        {
            if (connectionString == "" || connectionString == null)
                throw new InvalidOperationException("Your connection string cannot be empty or null");
            ConnectionString = connectionString;
        }

        public abstract void OpenConnection();
        public abstract void CloseConnection();
    }
}
