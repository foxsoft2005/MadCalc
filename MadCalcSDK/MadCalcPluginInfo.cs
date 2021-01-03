using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MadCalcSDK
{
    public sealed class MadCalcPluginInfo
    {
        private string name = String.Empty;
        private string version = String.Empty;
        private string author = String.Empty;
        private string description = String.Empty;
        private string htmlhelp = String.Empty;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string Version
        {
            get { return version; }
            set { version = value; }
        }

        public string Author
        {
            get { return author; }
            set { author = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        public string HtmlHelp
        {
            get { return htmlhelp; }
            set { htmlhelp = value; }
        }
    }
}
