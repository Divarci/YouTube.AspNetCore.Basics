namespace AppSettingsJson.Models
{
    public class EmailSettings
    {
        public string Host { get; set; }
        public string Port { get; set; }
        public Email Email { get; set; }

    }

    public class Email
    {
        public string Address { get; set; }
        public string Password { get; set; }
    }
}
