using Microsoft.AspNetCore.Mvc;
using Notit.Shared.Models;

namespace Notit.API.Controllers
{
    [Route("api/comment")]
    [ApiController]
    public class CommentController : ControllerBase
    {
        [HttpGet]
        public Comment Get(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void Post(Comment comment)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public void Put(Comment comment)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public void Delete(long id)
        {
            throw new NotImplementedException();
        }
    }
}
