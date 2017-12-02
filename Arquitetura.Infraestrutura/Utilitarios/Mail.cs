using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Arquitetura.Infraestrutura.Utilitarios
{
    public class Mail
    {
        public void EnviarEmail(string de, string para, string assunto, string corpo)
        {
            try
            {
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(de);
                mail.To.Add(para);
                mail.Subject = assunto;
                SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
    }
}
