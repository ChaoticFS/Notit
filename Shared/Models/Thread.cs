using System;
using Notit.Shared.Models;

namespace Notit.Shared.Models
{
    public class Thread
    {
        public Thread(string content, string user)
        {
            Content = content;
            User = user;
        }

        public long ThreadId { get; set; }
        public string Content { get; set; }
        public string User { get; set; }
        public DateTime Date { get; set; }
        public int Score { get; set; }
    }
}