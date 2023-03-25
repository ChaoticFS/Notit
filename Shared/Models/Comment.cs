using System;

namespace Notit.Shared.Models
{
    public class Comment
    {
        public Comment(string text, string user, long threadid) 
        { 
            Text = text;
            User = user;
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