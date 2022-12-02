using forumAppAPI.Models;
using forumAppAPI.Services;
using forumAppAPI.Services.Posts;
using forumAppAPI.Services.Threads;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace forumAppAPI.Controllers
{
    [ApiController]
    [Route("/")]
    public class ApiController : ControllerBase
    { 
        public static ThreadService threadService = new ThreadServiceImpl();
        public static PostService threadPost = new PostServiceImpl();

        [HttpGet("Threads")]
        public ActionResult<List<ForumThread>> GetAllThreads()
        {
             return Ok(threadService.GetAllThreads());
        }

        [HttpGet("Posts")]
        public ActionResult<List<ForumThread>> GetAllPosts()
        {
            return Ok(threadPost.GetAllPosts());
        }

        [HttpGet("Posts/{threadId}")]
        public ActionResult<List<ForumThread>> GetAllPostsByThreadId(int threadId)
        {
            return Ok(threadPost.GetAllPostsByThreadId(threadId));
        }

        [HttpGet("Posts/chk")]
        public ActionResult<bool> CheckifPostExists(int id)
        {
            return Ok(threadPost.CheckifPostExists(id));
        }
    }
}
