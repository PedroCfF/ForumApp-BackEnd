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
            new ForumPost(1, 1, "first post", 1),
            new ForumPost(2, 2, "first post", 1),
            new ForumPost(3, 3, "first post", 1),
            new ForumPost(4, 1, "first post", 2),
            new ForumPost(5, 2, "first post", 2),
            new ForumPost(6, 3, "first post", 2),
            new ForumPost(7, 1, "first post", 3),
            new ForumPost(8, 2, "first post", 3),
            new ForumPost(9, 3, "first post", 3)

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

        public ForumPost SavePost(ForumPost post)
        {
            bool badWord = post.body.Split(' ').Contains("puta");

            if (badWord) return null;

            return post;
        }


    }
}
