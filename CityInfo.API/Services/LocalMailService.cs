namespace CityInfo.API.Services
{
    public class LocalMailService
    {
        private string _mailTo = "kevin@mycompany.com";
        private string _mailFrom = "noreply@mycompany.com";

        public void Send(string subject, string message)
        {
            //mimic email - send to console
            Console.WriteLine($"Mail from {_mailFrom} to {_mailTo}, " +
                $"with {nameof(LocalMailService)}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Messgae: {message}");
        }
    }
}
