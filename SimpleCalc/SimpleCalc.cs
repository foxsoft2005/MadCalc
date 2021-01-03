using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;
using System.Collections;
using System.Windows.Forms;
using MadCalcSDK;

namespace SimpleCalc
{
    // it is recommended to make a sealed class
    public sealed class SimpleCalc : IMadCalcMain
    {
        private SimpleCalcEngine eng = null;
        private SimpleCalcSetup fm = null;
        private MadCalcPluginInfo info = null;
        
        // main interface methods
        public string CalculateExpression(string Expression)
        {
            eng = new SimpleCalcEngine();
            eng.DebugMode = true;
            eng.CalculateExpression(Expression);
            return String.Format("{0} = {1}", Expression, (eng.Errors.Count > 0) ? "ERROR!" : eng.Value);
        }

        public bool ParseExpression(string Expression)
        {
            return true;
        }

        public List<string> GetErrors()
        {
            return (eng == null) ? null : eng.Errors;
        }

        public MadCalcPluginInfo GetInfo()
        {
            if (info == null)
            {
                info = new MadCalcPluginInfo();
                info.Author = "foxsoft2005";
                info.Description = "Simple calculator plugin for MadCalc.";
                info.HtmlHelp = "Under construction.";
                info.Name = "SimpleCalc";
                info.Version = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();
            }
            return info;
        }

        public Form GetSetupForm()
        {
            if (fm == null) fm = new SimpleCalcSetup();
            return fm;
        }

        public void SetSetupForm(Form param)
        {
            if (param == null) return;
            fm = (SimpleCalcSetup)param;
        }

        public bool IsEmptyExprAllowed()
        {
            return false;
        }

        // overrided method for correct view
        public override string ToString()
        {
            return String.Format("Simple Calculator (version {0})", Assembly.GetExecutingAssembly().GetName().Version.ToString());
        }
    }
}