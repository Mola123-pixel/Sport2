namespace AmericanSportApp.Models
{
    public class People
    {
        public int PersonId { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public bool isAuthourised { get; set; }
        public bool isValid { get; set; }
        public bool isEnabled { get; set; }
    }
}
