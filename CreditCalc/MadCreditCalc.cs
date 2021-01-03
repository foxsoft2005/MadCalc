using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Reflection;
using MadCalcSDK;

namespace CreditCalc
{
    public sealed class MadCreditCalc : IMadCalcMain
    {
        private MadCreditEngine eng = null;
        private fmCreditCalc frm = null;
        private bool allowempty = true;
        private MadCalcPluginInfo info = null;
        
        // main interface methods
        public string CalculateExpression(string Expression)
        {
            string result = String.Empty;
            eng = new MadCreditEngine();
            eng.Config = (frm == null) ? null : frm.Data;
            eng.CalculateValues();
            result = (eng.Values.Count > 0) ? String.Join("\r\n", eng.Values) : "Empty result.";
            return result;
        }

        public bool ParseExpression(string Expression)
        {
            return (allowempty) ? allowempty : Expression.ToLower().StartsWith("calc");
        }

        public List<string> GetErrors()
        {
            return (eng == null) ? null: eng.Errors;
        }

        public MadCalcPluginInfo GetInfo()
        {
            if (info == null)
            {
                info = new MadCalcPluginInfo();
                info.Author = "foxsoft2005";
                info.Description = "Simple credit calculator plugin for MadCalc.";
                info.HtmlHelp = "Under construction.";
                info.Name = "MadCreditCalc";
                info.Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            return info;
        }

        public Form GetSetupForm()
        {
            if (frm == null) frm = new fmCreditCalc();
            return frm;
        }

        public void SetSetupForm(Form param)
        {
            frm = (fmCreditCalc)param;
        }

        public bool IsEmptyExprAllowed()
        {
            return allowempty;
        }

        // overrided method for correct view
        public override string ToString()
        {
            return String.Format("Credit Calculator (version {0})", Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }
    }
}
