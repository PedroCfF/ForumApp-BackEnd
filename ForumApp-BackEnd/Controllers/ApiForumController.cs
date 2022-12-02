using ForumApp.Models;
using ForumApp.Services;
using ForumApp.Services.Posts;
using ForumApp.Services.Threads;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace ForumApp.Controllers
{
    [ApiController]
    [Route("/")]
    public class ApiController : ControllerBase
    { 
        public static ThreadService threadService = new ThreadServiceImpl();
        public static PostService postService = new PostServiceImpl();

        [HttpGet("Threads")]
        public ActionResult<List<ForumThread>> GetAllThreads()
        {
             return Ok(threadService.GetAllThreads());
        }

        [HttpGet("Posts")]
        public ActionResult<List<ForumPost>> GetAllPosts()
        {
            return Ok(postService.GetAllPosts());
        }

        [HttpGet("Posts/{threadId}")]
        public ActionResult<List<ForumPost>> GetAllPostsByThreadId(int threadId)
        {
            return Ok(postService.GetAllPostsByThreadId(threadId));
        }

        [HttpGet("Posts/chk")]
        public ActionResult<bool> CheckifPostExists(string title)
        {
            return Ok(postService.CheckifPostExists(title));
        }

        [HttpPost("Post")]
        public ActionResult<ForumPost> SavePost(ForumPost post)
        {
            return Ok(postService.SavePost(post));
        }
    }
}
