using Notit.Shared.Models;
using System.Net.Http.Json;

namespace Notit.Client.Services
{
    public class CommentService
    {
        private readonly HttpClient httpClient;

        public CommentService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public Task<Comment> GetComment(int commentId)
        {
            var result = httpClient.GetFromJsonAsync<Comment>($"api/comment?id={commentId}");
            return result;
        }
    }
}