using ForumApp.Models;

namespace ForumApp.Services.Threads
{
    public interface ThreadService
    {
        public List<ForumThread> GetAllThreads();
    }
}
