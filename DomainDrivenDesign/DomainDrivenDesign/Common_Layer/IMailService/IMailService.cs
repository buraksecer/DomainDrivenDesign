using Domain_Layer.Models.MailServices;

namespace Common_Layer.IMailService
{
    public interface IMailService
    {
        void MailSendToSmtp(MailModel model);
    }
}
