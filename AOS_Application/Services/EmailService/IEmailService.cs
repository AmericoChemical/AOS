using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace EmailService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IEmailService" in both code and config file together.
    [ServiceContract]
    public interface IEmailService
    {
        [DataMember]
        string EmailStatus { get; }

        [OperationContract]
        bool SendMail(string emailFrom, string emailTo, string emailSubject, string emailBody, bool isHTML, string vHost);

        [OperationContract]
        int TestMethod(int a, int b);
    }
}
