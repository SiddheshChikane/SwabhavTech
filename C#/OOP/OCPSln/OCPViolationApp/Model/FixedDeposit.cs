using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OCPViolationApp.Model
{
    class FixedDeposit
    {
        private string _name;
        private double _amount;
        private int _duration;
        private FestivalType _festival;

        public FixedDeposit(string name, double amount, int duration, FestivalType festival)
        {
            this._name = name;
            this._amount = amount;
            this._duration = duration;
            this._festival = festival;
        }
        public double SimpleInterest()
        {
            float interest = (float)(_amount * CalculateRate() * _duration / 100);
            return interest;
        } 
        public double CalculateRate()
        {
            float interestRate = 7f;
            if (_festival == FestivalType.DIWALI)
            {
                interestRate = 8f;
                return interestRate;
            }
            else if (_festival == FestivalType.EID)
            {
                interestRate = 8.5f;
                return interestRate;
            }
            else if (_festival == FestivalType.NEW_YEAR)
            {
                interestRate = 9f;
                return interestRate;
            }
            else
            {
                return interestRate;
            }

        }
    }
}
