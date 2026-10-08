namespace WebApplication1.Models
{
    public class ProjectItem
    {
        public int Id { get; set; }
        public string Title { get; set; } = string.Empty;
        public string Subtitle { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public List<string> TechStack { get; set; } = new();
        public string Category { get; set; } = string.Empty;
        public string Url { get; set; } = string.Empty;

    }
}
