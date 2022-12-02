namespace ForumApp.Models
{
    public class ForumPost
    {
        public ForumPost(int idpost, string title, int category, string body, int threadid)
        {
            this.idpost = idpost;
            this.title = title;
            this.category = category;
            this.body = body;
            this.threadid = threadid;
        }

        public int idpost { get; set; }
        public string title { get; set; }
        public int category { get; set; }  
        public string body { get; set; }
        public int threadid { get; set; } 
    }
}
