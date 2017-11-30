using Domain.Entityes;

namespace Domain.Abstrac
{
    public interface IEmailSending
    {
        void SendMailToAdministrator(Basket basket, OrderDetails details, string mailFrom, string mailPasword, string hostName, int port, bool enableSsl, string mailAdmin, string attachFile);
        void SendMail(Basket basket, OrderDetails details, string mailFrom, string mailPasword, string hostName, int port, bool enableSsl, string attachFile);
    }
}