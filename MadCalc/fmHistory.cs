using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace MadCalc
{
    public partial class fmHistory : Form
    {
        public fmHistory()
        {
            InitializeComponent();
        }

        private List<string> history = null;

        public List<string> History
        {
            set { history = value; }
            get { return history; }
        }

        private void fmHistory_Load(object sender, EventArgs e)
        {
            if (history == null) return;
            richHistory.Clear();
            richHistory.Lines = history.ToArray();
        }
    }
}
