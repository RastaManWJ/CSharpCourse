using CSharpCourse.Basic;
using CSharpCourse.Intermediate;
using System.Threading;

namespace CSharpCourse
{
    class Program
    {
        static void Main(string[] args)
        {
            //IntermediateExOne();
            //IntermediateExTwo();
            IntermediateStack();
        }

        private static void IntermediateExOne()
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

        private static void IntermediateExTwo()
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

        private static void IntermediateStack()
        {
            Stack defaultStack = new Stack();
            defaultStack.Push(10);
            defaultStack.Push(new Stack());
            defaultStack.Push("Alalala");

            defaultStack.Pop();
            defaultStack.Clear();
        }
    }
}

