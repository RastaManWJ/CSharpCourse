namespace CSharpCourse.Intermediate
{
    public class OracleConnection : DatabaseConnection
    {
        public OracleConnection(string connectionString) : base(connectionString)
        {
        }

        public override void CloseConnection()
        {
            System.Console.WriteLine("Closing an Oracle Connection");
        }

        public override void OpenConnection()
        {
            System.Console.WriteLine("Opening an Oracle Connection");
        }
    }
}
