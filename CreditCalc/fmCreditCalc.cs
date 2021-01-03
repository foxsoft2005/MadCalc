using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CreditCalc
{
    public partial class fmCreditCalc : Form
    {
        private MadCreditConfig data = new MadCreditConfig();
        
        public fmCreditCalc()
        {
            InitializeComponent();
        }

        public MadCreditConfig Data
        {
            get { return data; }
            set { data = value; }
        }

        private void fmCreditCalc_Load(object sender, EventArgs e)
        {
            cboxMode.SelectedIndex = (data == null) ? 0 : data.Mode;
            
            if (data == null) return;
            madCreditConfigBindingSource.Add(data);
        }

        private void cboxMode_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (data.Mode != cboxMode.SelectedIndex)
            {
                data.Mode = cboxMode.SelectedIndex;
            }
        }
    }
}
