namespace JuanProject.Models
{
    public class Blog
    {
        public int Id { get; set; }
        public string ImagrUrl { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Desc { get; set; }
        public string AuthorName { get; set; }
        public List<Comment> Comments { get; set; }
    }
}
