using forumAppAPI.Models;
using forumAppAPI.Repo;

namespace forumAppAPI.Services.Posts
{
    public class PostServiceImpl : PostService
    {
        Repository repo = new Repository();

        public bool CheckifPostExists(int id)
        {
            return repo.CheckifPostExists(id);  
        }

        public List<ForumPost> GetAllPosts()
        {
            return repo.GetAllPosts();
        }
        public List<ForumPost> GetAllPostsByThreadId(int id)
        {
            return repo.GetAllPostsByThreadId(id);
        }
    }
}
