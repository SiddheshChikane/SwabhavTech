using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DIPSln.Common_Module;
namespace DIPSln.High_Level_Module
{
    class TaxCalculator
    {
        private ILogger _logger;

        public TaxCalculator(ILogger logger)
        {
            this._logger = logger;
            Console.WriteLine(_logger.Log());
           
        }
        public int Calculate(int value1, int value2)
        {
            int result = 0;
            try
            {
                result = value1 / value2;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            return result;
        }
    }
}
