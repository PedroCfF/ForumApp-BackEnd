using forumAppAPI.Models;

namespace forumAppAPI.Services.Threads
{
    public interface ThreadService
    {
        public List<ForumThread> GetAllThreads();
    }
}
