using System;
using System.Collections.Generic;
using System.Text;

namespace CSharpCourse.Intermediate
{
    class Post
    {
        private readonly DateTime _dateTime = DateTime.Now;
        public string Title { get; set; }
        public string Description { get; set; }
        public int VoteLevel { get; private set; }
        public DateTime GetDateTime() { return _dateTime; }

        public void UpVote() { VoteLevel++; }
        public void DownVote(){ VoteLevel--; }
    }
}
