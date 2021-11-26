using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountCustomExceptionApp.Model
{
    class InsuffiecientFundsException:Exception
    {
        private string _message;
        public InsuffiecientFundsException()
        {
            
        }
        public InsuffiecientFundsException(Account acc)
        {
            _message = $"a/c no : {acc.GetAccountNum()} have insucfficient funds to withdraw \n " +
                        $"you can't withdraw more than {acc.GetAccountBalance() - 500}\n" +
                        $"you should have minimum balance of 500\n" +
                        $"Transaction Declined";
        }
        public override string Message
        {
            get
            {
                return _message;
            }
        }
    }
}
