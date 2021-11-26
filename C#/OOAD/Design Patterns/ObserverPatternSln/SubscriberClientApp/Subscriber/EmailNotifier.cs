using PublisherLib.Publisher;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SubscriberClientApp.Subscriber
{
    class EmailNotifier:INotifier
    {
        public void Notify(Account account)
        {
            Console.WriteLine("Email sent successfully : {0} {1} {2}",account.AccNo,account.Balance,account.Email);
        }
    }
}
