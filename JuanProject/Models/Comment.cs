namespace JuanProject.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public string String { get; set; }   
        public DateTime CreateDate { get; set; }
        public string AppUserID { get; set; }
        public AppUser AppUser { get; set; }
        public int BlogId { get; set; }
        public Blog Blog { get; set; }

    }
}
