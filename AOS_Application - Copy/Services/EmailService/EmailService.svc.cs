using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Net.Mail;

namespace EmailService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "EmailService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select EmailService.svc or EmailService.svc.cs at the Solution Explorer and start debugging.
    public class EmailService : IEmailService
    {
        // Data Members;
        //private string _to;
        //private string _from;
        //private string _subject;
        //private string _body;
        private string _emailStatus;

        public string EmailStatus
        {
            get {return _emailStatus;}
        }

        public int TestMethod(int a, int b)
        {
            return a + b;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="emailFrom">From Email Address</param>
        /// <param name="emailTo">For multiple email addresses use ; as a separator</param>
        /// <param name="emailSubject"></param>
        /// <param name="emailBody"></param>
        /// <param name="isHTML">True or False</param>
        /// <param name="vHost">Host address to be used for the emails</param>
        /// <returns></returns>
        public bool SendMail(string emailFrom, string emailTo, string emailSubject, string emailBody, bool isHTML, string vHost)
        {
	        // email.StatusMessage = "Success";

	        //Create smtpclient object
	        SmtpClient vClient = new SmtpClient();
	        MailMessage vMessage = new MailMessage();
	        try 
            {
		        // Create smtpclient object
		        vClient = new SmtpClient(vHost);

		        // Set the From Address
		        if (!string.IsNullOrEmpty(emailFrom))
                {
			        vMessage.From = new MailAddress(emailFrom);
		        }

		        foreach (string ToID in emailTo.Split(';')) {
			        //Set the To Address
			        if (!string.IsNullOrEmpty(ToID)) {
				        vMessage.To.Add(new MailAddress(ToID.Trim()));
			        }
		        }

		        vMessage.IsBodyHtml = isHTML;
		        vMessage.Subject = emailSubject;
		        vMessage.Body = emailBody;

		        //Send the mail
		        if (vMessage.To.Count > 0)
                {
			        vClient.Send(vMessage);
                    _emailStatus = "Success";
			        return true;
		        }
                else
                {   
			        _emailStatus = "Failed";
                    return false;
		        }
	        }
            catch (Exception e)
            {
                throw e;
	        }
            finally
            {
		        vMessage.Dispose();
		        vClient.Dispose();
	        }
        }

    }
}
