using Microsoft.AspNetCore.Mvc;
using Notit.Shared.Models;
using Thread = Notit.Shared.Models.Thread;

namespace Notit.API.Controllers
{
    [Route("api/thread")]
    [ApiController]
    public class ThreadController : ControllerBase
    {
        [HttpGet]
        public Thread Get(long id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public void Post(Thread thread)
        {
            throw new NotImplementedException();
        }

        [HttpPut]
        public void Put(Thread thread)
        {
            throw new NotImplementedException();
        }

        [HttpDelete]
        public void Delete(long id)
        {
            throw new NotImplementedException();
        }

        [HttpGet("comments")]
        public List<Comment> GetComments(long threadid)
        {
            throw new NotImplementedException();
        }
    }
}
