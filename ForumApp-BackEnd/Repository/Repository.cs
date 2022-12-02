using forumAppAPI.Models;

namespace forumAppAPI.Repo
{
    public class Repository
    {
        ForumThread[] threads = new ForumThread[] { 
            new ForumThread(1, "first thread", "lorem ipsum"), 
            new ForumThread(2, "second thread","lorem ipsum"), 
            new ForumThread(3, "third thread", "lorem ipsum") 
        };

        ForumPost[] posts = new ForumPost[]
        {
            new ForumPost(1, "sports", "first post", "image.jpg", 1),
            new ForumPost(2, "sports", "first post", "image.jpg", 1),
            new ForumPost(3, "sports", "first post", "image.jpg", 1),
            new ForumPost(4, "sports", "first post", "image.jpg", 2),
            new ForumPost(5, "sports", "first post", "image.jpg", 2),
            new ForumPost(6, "sports", "first post", "image.jpg", 2),
            new ForumPost(7, "sports", "first post", "image.jpg", 3),
            new ForumPost(8, "sports", "first post", "image.jpg", 3),
            new ForumPost(9, "sports", "first post", "image.jpg", 3)

        };

        public List<ForumThread> GetAllThreads()
        {
            return threads.ToList();
        }

        public List<ForumPost> GetAllPosts()
        {
            return posts.ToList();
        }

        public List<ForumPost> GetAllPostsByThreadId(int id)
        {
            var filteredList = posts.Where(p => p.threadid == id);
            return filteredList.ToList();
        }

        public bool CheckifPostExists(int id)
        {
            foreach (ForumPost post in posts)
            {
                if (post.threadid == id) return true;    
            }

            return false;
        }


    }
}
