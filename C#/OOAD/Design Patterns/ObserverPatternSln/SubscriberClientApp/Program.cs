using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PublisherLib.Publisher;
using SubscriberClientApp.Subscriber;
namespace SubscriberClientApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Account acc1 = new Account(101, "Sid", 4000, "Sid@gmail.com");
            acc1.AddNotifier(new SmsNotifier());
            acc1.AddNotifier(new EmailNotifier());
            acc1.Deposit(2000);

        }
    }
}
