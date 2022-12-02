using ForumApp.Models;

namespace ForumApp.Services.Posts
{
    public interface PostService
    {   
        public List<ForumPost> GetAllPosts();

        public List<ForumPost> GetAllPostsByThreadId(int id);

        public  bool CheckifPostExists(string title);

        public ForumPost SavePost(ForumPost post);
    }
}
