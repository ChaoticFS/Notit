using System;

namespace Notit.Shared.Models
{
    public class Comment
    {
        public Comment(string text, string user, DateTime date, long threadid) 
        { 
            Text = text;
            User = user;
            Date = date;
            Score = 0;
            ThreadId = threadid;
        }
        public Comment(string text, string user, long threadid)
        {
            Text = text;
            User = user;
            Date = DateTime.Now;
            Score = 0;
            ThreadId = threadid;
        }

        public long CommentId { get; set; }
        public string Text { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
        public long ThreadId { get; set; }
    }
}