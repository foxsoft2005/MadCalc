using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections;

namespace SimpleCalc
{
    class SimpleCalcEngine
    {
        // private definitions
        private object value = 0.0;
        private List<string> errors = null;
        private string expression = String.Empty;
        private bool debugmode = false;

        // properties
        public object Value
        {
            get { return value; }
        }

        public List<string> Errors
        {
            get { return errors; }
        }

        public string Expression
        {
            get { return expression; }
            set { expression = value; }
        }

        public bool DebugMode
        {
            get { return debugmode; }
            set { debugmode = value; }
        }

        // constructors
        public SimpleCalcEngine()
        {
            errors = new List<string>();
        }

        // private methods
        private void Calculate()
        {
            errors.Clear();
            
            if (String.IsNullOrWhiteSpace(expression))
            {
                value = 0.0;
                errors.Add("Error. Empty expression was passed.");
                return;
            }
            
            // создаем компилятор
            CodeDomProvider codeDOM = CodeDomProvider.CreateProvider("C#");
            
            // параметризуем его: DLL в памяти
            CompilerParameters cp = new CompilerParameters();
            cp.ReferencedAssemblies.Add("system.dll");
            cp.GenerateExecutable = false; // создать DLL
            cp.GenerateInMemory = true; // создать в памяти

            // runtime класс, который, собственно, реализует вычисление
            // именно тут вводятся поддерживаемые "функции" калькулятора
            string code = string.Empty;
            code += "using System;";
            code += "using System.Security.Cryptography;";
            code += "using System.Text;";
            code += "namespace SimpleCalc {";
            code += " public class Evaluate {";
            code += "   public object GetResult(){ return(" + expression + "); }";
            code += "   private double sin(double x){ return(Math.Sin(x)); }";
            code += "   private double cos(double x){ return(Math.Cos(x)); }";
            code += "   private double tan(double x){ return(Math.Tan(x)); }";
            code += "   private double asin(double x){ return(Math.Asin(x)); }";
            code += "   private double acos(double x){ return(Math.Acos(x)); }";
            code += "   private double atan(double x){ return(Math.Atan(x)); }";
            code += "   private double sqrt(double x){ return(Math.Sqrt(x)); }";
            code += "   private double log(double x, double y = 10){ return(Math.Log(x,y)); }";
            code += "   private double log10(double x){ return(Math.Log10(x)); }";
            code += "   private double abs(double x){ return(Math.Abs(x)); }";
            code += "   private double power(double x, double y = 2){ return(Math.Pow(x, y)); }";
            code += "   private double pi(){ return Math.PI; }";
            code += "   private double e(){ return Math.E; }";
            code += "   private string md5(string x) {";
            code += "     MD5 md5Hasher = MD5.Create();";
            code += "     byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(x));";
            code += "     StringBuilder sBuilder = new StringBuilder();";
            code += "     for (int i = 0; i < data.Length; i++) {";
            code += "       sBuilder.Append(data[i].ToString(\"x2\"));";
            code += "     }";
            code += "     return sBuilder.ToString();";
            code += "   }";
            code += "   private string guid(string format = \"D\") {";
            code += "     return Guid.NewGuid().ToString(format);";
            code += "   }";
            code += " }";
            code += "}";
            
            // компиляция исходного кода и получение сборки
            CompilerResults cr = codeDOM.CompileAssemblyFromSource(cp, code);
            if (cr.Errors != null && cr.Errors.Count > 0) // ? ошибки 
            {
                if (debugmode)
                {
                    for (int i = 0; i < cr.Errors.Count; i++)
                    {
                        errors.Add(String.Format("Internal error: Line {0} - {1}.", cr.Errors[i].Line, cr.Errors[i].ErrorText));
                    }
                }
                value = 0.0;
                return;
            }

            try // создать объект и вызвать метод для вычисления выражения
            {
                object ob = cr.CompiledAssembly.CreateInstance("SimpleCalc.Evaluate");
                value = ob.GetType().InvokeMember("GetResult", BindingFlags.InvokeMethod, null, ob, new object[] { });
            }
            catch (Exception ex)
            {
                value = 0.0;
                errors.Add(String.Format("Unable to calculate expression [{0}] cause internal error.\r\nError text: {1}", expression, ex.Message));
                return;
            }
        }

        // public methods
        public void CalculateExpression(string exp)
        {
            expression = exp;
            Calculate();
        }
    }
}
