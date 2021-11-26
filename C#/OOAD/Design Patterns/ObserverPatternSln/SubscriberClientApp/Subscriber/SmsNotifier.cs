using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Publisher;
namespace SubscriberClientApp.Subscriber
{
     class SmsNotifier:INotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Sms sent successfully : {0} {1} {2} ",account.AccNo,account.Balance,account.Email);
        }
    }
}
