namespace AmericanSportApp.Models
{
    public class Sport
    {
        public int SportId { get; set; }
        public string SportName { get; set; } = string.Empty;
        public bool isEnabled { get; set; }
    }
}
