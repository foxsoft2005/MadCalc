using System;
using System.Collections.Generic;
using System.Collections;
using System.Windows.Forms;
using System.Linq;
using System.Text;

namespace MadCalcSDK
{
    // Main MadCalc plugin interface definitions
    public interface IMadCalcMain
    {
        // Main method that calculates expression and returns the result
        string CalculateExpression(string Expression);

        // Parsing method (if it return "false" calculation will not start)
        bool ParseExpression(string Expression);

        // Getting list of errors occured
        List<string> GetErrors();
        
        // Getting info about current plugin
        MadCalcPluginInfo GetInfo();

        // Getting plugin setup form
        Form GetSetupForm();

        // Setting plugin setup form
        // it's must be a form that is result of GetSetupForm() method
        void SetSetupForm(Form param);

        // Determines calculation possibility of "empty" expression
        // It's possible when all necessary plugin data is already on setup form
        // and user expression is not necessary
        bool IsEmptyExprAllowed();
    }
}
