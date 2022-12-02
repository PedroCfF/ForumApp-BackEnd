namespace forumAppAPI.Models
{
    public class ForumPost
    {
        public ForumPost(int idpost, string category, string body, string image, int threadid)
        {
            this.idpost = idpost;
            this.category = category;
            this.body = body;
            this.image = image;
            this.threadid = threadid;

        }

        public int idpost { get; set; } 
        public string? category { get; set; }  
        public string? body { get; set; }
        public string? image { get; set; }
        public int? threadid { get; set; } 
    }
}
