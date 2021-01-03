using System;
using System.Collections.Generic;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Reflection;
using MadCalcSDK;

namespace MadCalc
{
    public partial class fmMain : Form
    {
        public fmMain()
        {
            InitializeComponent();
        }

        private string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        private List<string> history = new List<string>();
        private MadCalcPluginInfo curinfo = null;

        private void setControlsState(bool state)
        {
            btnExprAbout.Enabled = state;
            btnExprHelp.Enabled = state;
            btnPresetSetup.Enabled = state;
        }

        private void loadCalculators()
        {
            string currPath = Path.Combine(appPath, "calculators");
            if (!Directory.Exists(currPath))
            {
                try
                {
                    Directory.CreateDirectory(currPath);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Unable to create plugins directory.\r\nMessage: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    comboboxPreset.Items.Clear();
                    comboboxPreset.Items.Add("<Not found...>");
                    return;
                }
            }
            bool error = false;
            string[] plugins = Directory.GetFiles(currPath, "*.dll");
            List<Type> pluginTypes = new List<Type>();
            foreach (string plugin in plugins)
            {
                Assembly assmPlug = Assembly.LoadFile(plugin);
                Type[] types = null;
                try
                {
                    types = assmPlug.GetExportedTypes();
                }
                catch
                {
                    MessageBox.Show("Unable to load plugin cause internal SDK error (is installed SDK\\plugin version correct?).", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    error = true;
                }

                if (!error)
                {
                    foreach (Type t in types)
                    {
                        if (t.IsClass && typeof(IMadCalcMain).IsAssignableFrom(t))
                        {
                            pluginTypes.Add(t);
                        }
                    }
                }
            }

            comboboxPreset.Items.Clear();
            if (pluginTypes.Count == 0)
            {
                comboboxPreset.Items.Add("<Not found...>");
            }
            else
            {
                comboboxPreset.Items.Add("<Select a plugin...>");
            }
            comboboxPreset.SelectedIndex = 0;

            foreach(Type t in pluginTypes)
            {
                IMadCalcMain ia = (IMadCalcMain)Activator.CreateInstance(t);
                comboboxPreset.Items.Add(ia);
            }
        }

        private void fmMain_Load(object sender, EventArgs e)
        {
            this.Text = String.Format("{0} v.{1}", Application.ProductName, Application.ProductVersion);
            loadCalculators();
        }

        private void fmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = (MessageBox.Show("Do you want to exit MadCalc?","Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question) != DialogResult.Yes);
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (comboboxPreset.SelectedIndex == 0)
            {
                MessageBox.Show("Unable to calculate expression. Plugin was not selected.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            IMadCalcMain curCalc = (IMadCalcMain)comboboxPreset.SelectedItem;
            bool allow = curCalc.IsEmptyExprAllowed();

            if (String.IsNullOrWhiteSpace(richboxExpr.Text) && !allow)
            {
                MessageBox.Show("Unable to calculate empty expression.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!String.IsNullOrWhiteSpace(richboxResult.Text))
            {
                history.Add(richboxResult.Text + "\r\n------------");
            }

            richboxErrors.Clear();
            richboxResult.Clear();

            if (!curCalc.ParseExpression(richboxExpr.Text) && !allow)
            {
                richboxErrors.Text = "Unable to parse expression. Check it and try again.";
                return;
            }

            richboxResult.Text = curCalc.CalculateExpression(richboxExpr.Text);
            List<string> errs = curCalc.GetErrors();
            if (errs != null && errs.Count > 0)
            {
                richboxErrors.Lines = errs.ToArray();
            }
            else
            {
                richboxErrors.Text = "Calculated successfully.";
            }
        }

        private void btnExprHelp_Click(object sender, EventArgs e)
        {
            if (comboboxPreset.SelectedIndex == 0) return;
            IMadCalcMain calc = (IMadCalcMain)comboboxPreset.SelectedItem;
            MessageBox.Show((curinfo == null) ? "Help unavailable." : curinfo.HtmlHelp, "Help", MessageBoxButtons.OK, MessageBoxIcon.Question);
        }

        private void btnPresetSetup_Click(object sender, EventArgs e)
        {
            if (comboboxPreset.SelectedIndex == 0) return;
            IMadCalcMain calc = (IMadCalcMain)comboboxPreset.SelectedItem;
            Form frm = calc.GetSetupForm();
            if (frm == null) return;
            frm.Icon = this.Icon;
            DialogResult res = frm.ShowDialog(this);
            if (res == DialogResult.OK || res == DialogResult.Yes)
            {
                calc.SetSetupForm(frm);
                if (calc.IsEmptyExprAllowed())
                {
                    if (MessageBox.Show("Do you want to calculate result now?", "Question", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        btnCalculate_Click(btnCalculate, new EventArgs());
                    }
                }
            }
        }

        private void richboxExpr_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) && (e.Control))
            {
                btnCalculate_Click(btnCalculate, new EventArgs());
                e.Handled = true;
            }
        }

        private void comboboxPreset_SelectedIndexChanged(object sender, EventArgs e)
        {
            setControlsState(comboboxPreset.SelectedIndex != 0);
            curinfo = null;
            if (comboboxPreset.SelectedIndex > 0)
            {
                IMadCalcMain calc = (IMadCalcMain)comboboxPreset.SelectedItem;
                lbAllowed.Visible = calc.IsEmptyExprAllowed();
                curinfo = calc.GetInfo();
            }
            else
            {
                lbAllowed.Visible = false;
            }
        }

        private void btnExprAbout_Click(object sender, EventArgs e)
        {
            if (comboboxPreset.SelectedIndex == 0) return;
            IMadCalcMain calc = (IMadCalcMain)comboboxPreset.SelectedItem;
            MessageBox.Show((curinfo == null) ? "Information unavailable." : String.Format("{0} v.{1}\r\nAuthor: {2}\r\n{3}", curinfo.Name, curinfo.Version, curinfo.Author, curinfo.Description), "About", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void lnkHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            using (fmHistory frm = new fmHistory())
            {
                frm.Icon = this.Icon;
                frm.History = history;
                frm.ShowDialog(this);
            }
        }
    }
}
