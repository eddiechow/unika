using System.Net;
using System.Net.Mail;

namespace BackendClassLibrary
{
    public class Email
    {
        public static void send(string recipients, string subject, string body)
        {
            var client = new SmtpClient("smtp.gmail.com", 587)
            {
                Credentials = new NetworkCredential("unikapims@gmail.com", "unikafinalfyp"),
                EnableSsl = true
            };
            MailMessage message = new MailMessage("UNIKA <unikapims@gmail.com>", recipients, subject, body);
            message.Sender = new MailAddress("unikapims@gmail.com", "UNIKA");
            client.Send(message);
        }
    }
}
