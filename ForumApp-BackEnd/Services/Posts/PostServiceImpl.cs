using ForumApp.Repo;
using ForumApp.Models;

namespace ForumApp.Services.Posts
{
    public class PostServiceImpl : PostService
    {
        ForumRepo repo = new ForumRepo();

        public List<ForumPost> GetAllPosts()
        {
            return repo.GetAllPosts();
        }

        public List<ForumPost> GetAllPostsByThreadId(int id)
        {
            return repo.GetAllPostsByThreadId(id);
        }

        public bool CheckifPostExists(string title)
        {
            return repo.CheckifPostExists(title);
        }

        public ForumPost SavePost(ForumPost post)
        {
            return repo.SavePost(post);
        }
    }
}
