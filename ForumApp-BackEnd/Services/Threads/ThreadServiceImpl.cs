using ForumApp.Repo;
using ForumApp.Models;

namespace ForumApp.Services.Threads
{
    public class ThreadServiceImpl : ThreadService
    {
        ForumRepo repo = new ForumRepo();
        public List<ForumThread> GetAllThreads()
        {
            return repo.GetAllThreads();
        }
    }
}
