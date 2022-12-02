namespace forumAppAPI.Models
{
    public class ForumPost
    {
        public ForumPost(int idpost, int category, string body, int threadid)
        {
            this.idpost = idpost;
            this.category = category;
            this.body = body;
            this.threadid = threadid;
        }

        public int idpost { get; set; } 
        public int category { get; set; }  
        public string body { get; set; }
        public int threadid { get; set; } 
    }
}
