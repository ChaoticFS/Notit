using System;

namespace Notit.Shared.Models
{
    public class Comment
    {
        public Comment(string text, string user) 
        { 
            Text = text;
            User = user;
        }

        public long CommentId { get; set; }
        public string Text { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}