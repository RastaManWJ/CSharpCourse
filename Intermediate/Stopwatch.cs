using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Intermediate
{
    /// <summary>
    /// Design a class called Stopwatch. The job of this class is to simulate a stopwatch. It should
    /// provide two methods: Start and Stop.We call the start method first, and the stop method next.
    /// Then we ask the stopwatch about the duration between start and stop.Duration should be a
    /// value in TimeSpan.Display the duration on the console.
    /// We should also be able to use a stopwatch multiple times.So we may start and stop it and then
    /// start and stop it again. Make sure the duration value each time is calculated properly.
    /// We should not be able to start a stopwatch twice in a row (because that may overwrite the initial
    /// start time). So the class should throw an InvalidOperationException if its started twice
    /// </summary>


    class Stopwatch
    {
        private DateTime StartTime { get; set; }
        private DateTime EndTime { get; set; }

        public void Start()
        {
            if (StartTime != DateTime.MinValue)
                throw new InvalidOperationException("Stopwatch is already started!");
            StartTime = DateTime.Now;
        }

        public void Stop()
        {
            if (StartTime == DateTime.MinValue)
                throw new InvalidOperationException("Stopwatch is not started!");
            EndTime = DateTime.Now;
            ShowSpan();
            ResetValues();
        }

        private void ShowSpan()
        {
            TimeSpan timeSpan = EndTime - StartTime;
            Console.WriteLine("The time span is {0}", timeSpan);
        }
        
        private void ResetValues()
        {
            StartTime = DateTime.MinValue;
            EndTime = DateTime.MinValue;
        }
    }
}
