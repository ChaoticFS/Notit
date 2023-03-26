using System;

namespace Notit.Shared.Models
{
    public class Comment
    {
        public Comment(string text, string user, DateTime date) 
        { 
            Text = text;
            User = user;
            Date = date;
            Score = 0;
        }
        public Comment(string text, string user)
        {
            Text = text;
            User = user;
            Date = DateTime.Now;
            Score = 0;
        }

        public long CommentId { get; set; }
        public string Text { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}