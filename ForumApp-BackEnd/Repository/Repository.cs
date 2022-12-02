using forumAppAPI.Models;

namespace forumAppAPI.Repo
{
    public class Repository
    {
        List<ForumThread> threads = new() { 
            new ForumThread(1, "first thread", "lorem ipsum"), 
            new ForumThread(2, "second thread","lorem ipsum"), 
            new ForumThread(3, "third thread", "lorem ipsum") 
        };

        List<ForumPost> posts = new ()
        {
            new ForumPost(1, "post 1", 1, "first post", 1),
            new ForumPost(2, "post 2", 2, "first post", 1),
            new ForumPost(3, "post 3", 3, "first post", 1),
            new ForumPost(4, "post 4", 1, "first post", 2),
            new ForumPost(5, "post 5", 2, "first post", 2),
            new ForumPost(6, "post 5", 3, "first post", 2),
            new ForumPost(7, "post 5", 1, "first post", 3),
            new ForumPost(8, "post 5", 2, "first post", 3),
            new ForumPost(9, "post 5", 3, "first post", 3)

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

        public bool CheckifPostExists(string title)
        {
            foreach (ForumPost post in posts)
            {
                if (post.title == title) return true;    
            }

            return false;
        }

        public ForumPost SavePost(ForumPost post)
        {
            bool badWord = post.body.Split(' ').Contains("puta");

            if (badWord) return null;

            posts.Add(post);

            return post;
        }


    }
}
