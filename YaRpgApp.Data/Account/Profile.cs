namespace YaRpgApp.Data.Account
{
    public record Profile
    {
        public string ProfileId { get; set; }
        public string Login { get; set; }
        public bool IsAdmin { get; set; }
    }
}