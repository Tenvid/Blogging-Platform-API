namespace PostsApi.Models
{
    public class Post
    {
        public int Id { get; set; }
        public required string title { get; set; }
        public required string content { get; set; }
        public required Category category { get; set; }

    }
}
