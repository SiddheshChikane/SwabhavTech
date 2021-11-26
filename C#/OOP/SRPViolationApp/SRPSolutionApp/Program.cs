using SRPSolutionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SRPSolutionApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Invoice invoice = new Invoice(111, "Sony LED TV", 30000, 10f, 30f);
            InvoiceHtmlGenerator htmlGenerator = new InvoiceHtmlGenerator();
            htmlGenerator.SaveInvoice(invoice);
        }
    }
}
