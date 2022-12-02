using forumAppAPI.Models;

namespace forumAppAPI.Services.Posts
{
    public interface PostService
    {   
        public List<ForumPost> GetAllPosts();

        public List<ForumPost> GetAllPostsByThreadId(int id);

        public  bool CheckifPostExists(int id);
    }
}
