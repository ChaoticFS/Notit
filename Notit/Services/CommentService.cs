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

        public Task PostComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task PutComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task DeleteComment(Comment comment)
        {
            throw new NotImplementedException();
        }

        public Task GetComments(int threadid)
        {
            throw new NotImplementedException();
        }
    }
}