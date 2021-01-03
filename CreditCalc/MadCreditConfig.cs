using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CreditCalc
{
    public class MadCreditConfig
    {
        private double creditamt = 0.0; // Credit Amount
        private double percent = 0.0; // Percent rate
        private int period = 12; // Number of periods (month - 12, year - 365)
        private int mode = 0;

        public int Mode
        {
            get { return mode; }
            set { mode = value; }
        }

        public double CreditAmt
        {
            get { return creditamt; }
            set { creditamt = value; }
        }

        public double Percent
        {
            get { return percent; }
            set { percent = value; }
        }

        public int Period
        {
            get { return period; }
            set { period = value; }
        }
    }
}
