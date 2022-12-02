using forumAppAPI.Repo;

namespace forumAppAPI.Models
{
    public class ForumThread
    {      
        public ForumThread(int idthread, string? title, string? description)
        {
            this.idthread = idthread;
            this.title = title;
            this.description = description;
        }

        public int idthread { get; set; }
        public string? title { get; set; }  
        public string? description { get; set; }
        
    }
}
