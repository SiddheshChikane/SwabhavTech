using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OCPSolutionApp.Lib;
namespace OCPSolutionApp.Client
{
    class DiwaliFestivalPolicy : IFestivalPolicy
    {
        public double CalCulateRate()
        {
            float interestRate = 8.5f;
            return interestRate;
        }

      
    }
}
