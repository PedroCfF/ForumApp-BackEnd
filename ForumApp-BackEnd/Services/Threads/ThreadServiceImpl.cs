using forumAppAPI.Models;
using forumAppAPI.Repo;

namespace forumAppAPI.Services.Threads
{
    public class ThreadServiceImpl : ThreadService
    {
        Repository repo = new Repository();
        public List<ForumThread> GetAllThreads()
        {
            return repo.GetAllThreads();
        }
    }
}
