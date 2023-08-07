namespace WebBlog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? ShortDescription { get; set; }
        public DateTime CreadDate { get; set; } = DateTime.Now;
        public string? Description { get; set; }
        public string? Slug { get; set; }   //Tạo Url

        //Relationship (Mối quan hệ)
        public string? ApplicationUserId { get; set; }
        public ApplicationUser ApplicationUser { get; set; }
    }
}
