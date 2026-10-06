namespace WebApplication1.Models
{
    public class Portfolio_View_Model
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

        public class ProfileModel
        {
            public string FullName { get; set; } = "Aliza Joie R. Rumbaoa";
            public string Bio { get; set; } = "Computer Science Student & Aspiring Software Developer";
            public List<string> Skills { get; set; } = new() { "C#", "ASP.NET Core", "JavaScript", "HTML/CSS", "Git" };
            public List<ProjectItem> Projects { get; set; } = new();
          
        }
    }
}

