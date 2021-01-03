using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;

namespace CreditCalc
{
    class MadCreditEngine
    {
        private List<string> errors = new List<string>();
        private string expression = String.Empty;
        private MadCreditConfig config = null;
        private List<string> values = new List<string>();

        public List<string> Values
        {
            get { return values; }
        }
        
        public List<string> Errors
        {
            get { return errors; }
        }

        public MadCreditConfig Config
        {
            get { return config; }
            set { config = value; }
        }

        private void clearLists()
        {
            values.Clear();
            errors.Clear();
        }

        public void CalculateValues()
        {
            clearLists();

            if (config == null)
            {
                errors.Add("Unable to calculate expression without valid settings.");
                return;
            }

            double res = 0;
            double koef = 0;
            double amt = config.CreditAmt;
            double percent = config.Percent / 1200;
            double prd = (double)config.Period;
            double overpayment = 0;

            switch (config.Mode)
            {
                // annual
                case 1:
                    koef = percent * Math.Pow(1 + percent, prd) / (Math.Pow(1 + percent, prd) - 1);
                    res = Math.Round(koef * amt, 2);
                    overpayment = Math.Round(res * prd - amt, 2);
                    break;
                // differential
                case 2:
                    double sum1 = amt / prd;
                    double sum2 = amt * percent;
                    res = Math.Round(sum1 + sum2, 2);
                    double tmp = amt;
                    while (tmp > 0)
                    {
                        sum2 = tmp * percent;
                        overpayment += sum2;
                        tmp -= sum1;
                    }
                    overpayment = Math.Round(overpayment, 2);
                    break;
                // Unknown mode - raise error
                default:
                    errors.Add("Unknown calculator mode. Check settings and try again.");
                    break;
            }

            if (errors.Count == 0)
            {
                values.Add(String.Format("Credit Amount: {0:F}, Percent Rate: {1:F}%, Period: {2} month(s).", config.CreditAmt, config.Percent, config.Period));
                values.Add(String.Format("{0} payment sum: {1}.\r\nOverpayment sum: {2}.", (config.Mode == 1) ? "Periodical" : "First",res.ToString("F"), overpayment.ToString("F")));
            }
            else
            {
                values.Add("Unable to calculate result. See errors list.");
            }
        }
    }
}
