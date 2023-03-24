using Notit.Shared.Models;
using System.Net.Http.Json;
using Thread = Notit.Shared.Models.Thread;

namespace Notit.Client.Services
{
    public class ThreadService
    {
        private readonly HttpClient httpClient;

        public ThreadService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<Thread> GetThread (int threadId) 
        {
            var result = httpClient.GetFromJsonAsync<Thread>($"api/thread?id={threadId}");
            return result;
        }
    }
}
