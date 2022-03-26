using System;

namespace CSharpCourse.Intermediate
{
    class DbCommand
    {
        public DatabaseConnection Connection { get; set; }
        public string TsqlInstruction { get; private set; }

        public DbCommand(DatabaseConnection connection, string tsqlInstruction)
        {
            Connection = connection ?? throw new NullReferenceException("Your connection cannot be null");
            TsqlInstruction = tsqlInstruction ?? throw new ArgumentException("Your command cannot be null or empty");
        }

        public void Execute()
        {
            Connection.OpenConnection();
            Console.WriteLine("Executing the command");
            Connection.CloseConnection();
        }

    }
}

