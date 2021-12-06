using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using V4mvc.Entities;

namespace V4mvc.Presentation
{
    public class SendEmail
    {
        private const int _clientcount = 15;
        private SmtpClient[] _smtpClients = new SmtpClient[_clientcount + 1];
        private CancellationTokenSource _cancelToken;

        public SendEmail() { setupSMTPClients(); }

        public void EnviarEmails(List<Correo> mails)
        {
            try
            {
                ParallelOptions po = new ParallelOptions();
                _cancelToken = new CancellationTokenSource();
                po.CancellationToken = _cancelToken.Token;
                po.MaxDegreeOfParallelism = System.Environment.ProcessorCount * 2;
                try
                {
                    Parallel.ForEach(mails, po, (Correo dataobject) =>
                    {
                        try
                        {
                            MailMessage msg = new MailMessage(dataobject.Emisor, dataobject.Receptor);
                            msg.Subject = dataobject.Asunto;
                            msg.Body = GenerarFormatoCorreo("<h1>" + dataobject.Mensaje + "</h1>");
                            msg.Priority = MailPriority.Normal;
                            msg.IsBodyHtml = true;
                            var mylist = dataobject.Attachments;
                            if (dataobject.Attachments != null)
                            {
                                for (int i = 0; i < dataobject.Attachments.Count(); i++)
                                {
                                    msg.Attachments.Add(mylist.ElementAt(i));
                                }
                            }
                            EnviarEmail(msg);
                        }
                        catch (Exception ex) { throw ex; }
                    });
                }
                catch (OperationCanceledException ex) { throw ex; }
            }
            finally { disposeSMTPClients(); }
        }

        public void EnviarEmail(Correo email)
        {
            try
            {
                string mailfrom = email.Emisor;
                string mailto;
                if (ConfigurationManager.AppSettings["MAILredirect"] != null && ConfigurationManager.AppSettings["MAILredirect"].ToString() != "")
                    mailto = (ConfigurationManager.AppSettings["MAILredirect"].ToString());
                else
                    mailto = (email.Receptor.Replace(';', ','));

                MailMessage newmsg = new MailMessage(mailfrom, mailto);
                newmsg.Subject = email.Asunto;
                newmsg.Body = GenerarFormatoCorreo(email.Mensaje);
                newmsg.Priority = MailPriority.High;
                newmsg.IsBodyHtml = true;
                if (email.Attachments != null)
                    foreach (var item in email.Attachments) { newmsg.Attachments.Add(item); }
                if (ConfigurationManager.AppSettings["MAILmethod"].ToString() == "2")
                {
                    SmtpClient smtps = new SmtpClient(ConfigurationManager.AppSettings["MAILsmtp"].ToString());
                    smtps.Port = Convert.ToInt32(ConfigurationManager.AppSettings["MAILport"].ToString());
                    newmsg.From = new MailAddress(ConfigurationManager.AppSettings["MAILusuario"].ToString());
                    smtps.Send(newmsg);
                }
                else
                {
                    SmtpClient smtps = new SmtpClient(ConfigurationManager.AppSettings["MAILsmtp"].ToString());
                    smtps.UseDefaultCredentials = false;
                    smtps.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["MAILusuario"].ToString()
                                                            , ConfigurationManager.AppSettings["MAILpassword"].ToString());
                    smtps.Port = Convert.ToInt32(ConfigurationManager.AppSettings["MAILport"].ToString());
                    smtps.EnableSsl = Convert.ToBoolean(ConfigurationManager.AppSettings["MAILssl"].ToString());
                    smtps.Send(newmsg);
                }
            }
            catch (Exception ex) { throw ex; }
        }
        public void CancelEmailRun() {  _cancelToken.Cancel(); }

        private void EnviarEmail(MailMessage mail)
        {
            try
            {
                bool _gotlocked = false;
                while (!_gotlocked)
                {
                    for (int i = 0; i <= _clientcount; i++)
                    {
                        if (Monitor.TryEnter(_smtpClients[i]))
                        {
                            try { _smtpClients[i].Send(mail); }
                            finally { Monitor.Exit(_smtpClients[i]); }
                            _gotlocked = true;
                            break;
                        }
                    }
                    System.Threading.Thread.Sleep(1);
                }
            }
            finally { mail.Dispose(); }
        }
        private void setupSMTPClients()
        {
            for (int i = 0; i <= _clientcount; i++)
            {
                try
                {
                    SmtpClient _client = new SmtpClient(ConfigurationManager.AppSettings["MAILsmtp"].ToString());
                    _client.Credentials = new NetworkCredential(ConfigurationManager.AppSettings["MAILusuario"].ToString()
                                                            , ConfigurationManager.AppSettings["MAILpassword"].ToString());
                    _client.Port = Convert.ToInt32(ConfigurationManager.AppSettings["MAILport"].ToString());
                    _client.EnableSsl = true;
                    _smtpClients[i] = _client;
                }
                catch (Exception ex) { throw ex; }
            }
        }
        private void disposeSMTPClients()
        {
            for (int i = 0; i <= _clientcount; i++)
            {
                try { _smtpClients[i].Dispose(); }
                catch (Exception ex) { throw ex; }
            }
        }
        public string GenerarFormatoCorreo(string body)
        {
            try
            {
                string Header = @"<html>" +
                    "<body style='background-color: #fffff; height: 90%;'>" +
                    "<div style ='color: #4d4d4d; font-family: Helvetica,Arial,sans-serif; font-size: 14px; font-weight: normal; line-height: 19px; margin: 0; min-width: 100%; padding: 0; text-align: left; width: 100%' >" +
                                    "<table style = 'border-collapse: collapse; border-spacing: 0; color: #4d4d4d; font-family: Helvetica,Arial,sans-serif; font-size: 14px; font-weight: normal; height: 100%; line-height: 19px; margin: 0; padding: 0; text-align: left; vertical-align: top; width: 100%'>" +
                                         "<tbody>" +
                                             "<tr style = 'padding: 0; text-align: left; vertical-align: top'>" +
                                                 "<td align = center valign = top style = 'border-collapse: collapse; color: #4d4d4d; font-family: Helvetica,Arial,sans-serif; font-size: 14px; font-weight: normal; line-height: 19px; margin: 0; padding: 0; text-align: center; vertical-align: top; word-break: break-word'>" +
                                                     "<center style = 'width: 100%'>" +
                                                       "<table>" +

                                                       "</table>";

                string Footer = "<table>" +

                                    "</table>" +
                            "</center>" +
                        "</td>" +
                    "</tr>" +
                "</tbody>" +
            "</table>" +
        "</div>" +
        " </body>" +
        "</html>";
                return Header + body + Footer;
            }
            catch (Exception ex) { throw ex; }
        }
    }
}