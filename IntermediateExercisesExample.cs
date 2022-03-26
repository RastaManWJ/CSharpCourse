using CSharpCourse.Intermediate;
using System.Threading;

namespace CSharpCourse
{
    class IntermediateExercisesExample
    {
        public static void IntermediateExOne()
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();
            Thread.Sleep(1000);
            stopwatch.Stop();

            stopwatch.Start();
            try
            {
                stopwatch.Start();
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Starting a started watch is not possible.");
            }
            stopwatch.Stop();
            try
            {
                stopwatch.Stop();
            }
            catch (System.Exception)
            {
                System.Console.WriteLine("Stopping a stopped watch is not possible.");
            }
        }

        public static void IntermediateExTwo()
        {
            var post = new Post();
            System.Console.WriteLine(post.VoteLevel);
            post.UpVote();
            System.Console.WriteLine(post.VoteLevel);
            post.DownVote();
            System.Console.WriteLine(post.VoteLevel);
            post.UpVote();
            System.Console.WriteLine(post.VoteLevel);
            System.Console.WriteLine(post.GetDateTime());
        }

        public static void IntermediateStack()
        {
            Stack defaultStack = new Stack();
            defaultStack.Push(10);
            defaultStack.Push(new Stack());
            defaultStack.Push("Alalala");

            defaultStack.Pop();
            defaultStack.Clear();
        }

        public static void IntermediateDB()
        {
            SqlConnection sql = new SqlConnection("Sql connection string");
            OracleConnection oracle = new OracleConnection("Oracle connection string");

            sql.OpenConnection();
            oracle.OpenConnection();
            sql.CloseConnection();
            oracle.CloseConnection();

        }

        public static void IntermediateDBCommand()
        {
            SqlConnection sql = new SqlConnection("Sql connection string");
            OracleConnection oracle = new OracleConnection("Oracle connection string");

            DbCommand sqlCommand = new DbCommand(sql, "some string");
            DbCommand oracleCommand = new DbCommand(oracle, "another string");
            sqlCommand.Execute();
            oracleCommand.Execute();
        }

        public static void IntermediateWorkflowActivity()
        {
            WorkflowEngine workflowEngine = new WorkflowEngine();
            workflowEngine.AddActivity(new ActivityOne());
            workflowEngine.AddActivity(new ActivityTwo());
            workflowEngine.Run();
        }
    }
}
