using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Intermediate
{
    class WorkflowEngine
    {
        private readonly IList<IActivities> _activities;

        public WorkflowEngine()
        {
            _activities = new List<IActivities>();
        }

        public void AddActivity(IActivities activity)
        {
            _activities.Add(activity);
        }

        public void Run()
        {
            foreach (var activity in _activities)
                activity.Execute();
        }
    }
}
