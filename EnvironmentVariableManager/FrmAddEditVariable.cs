using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace EnvironmentVariableManager
{
    public partial class FrmAddEditVariable : Form
    {
        EnvironmentVariableTarget target;

        public FrmAddEditVariable(EnvironmentVariableTarget target)
        {
            InitializeComponent();
            if (target == EnvironmentVariableTarget.User)
            {
                this.Text = "Add user variable";
            }
            else if (target == EnvironmentVariableTarget.Machine)
            {
                this.Text = "Add system variable";
            }

            this.target = target;
        }

        public FrmAddEditVariable(EnvironmentVariableTarget target, string variable, string value)
        {
            InitializeComponent();
            tbVariable.Text = variable;
            tbVariable.ReadOnly = true;
            tbValue.Text = value.Replace(";", ";" + Environment.NewLine);
            if (target == EnvironmentVariableTarget.User)
            {
                this.Text = "Edit user variable";
            }
            else if (target == EnvironmentVariableTarget.Machine)
            {
                this.Text = "Edit system variable";
            }
            this.target = target;
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (tbValue.Text.Equals(string.Empty) || tbVariable.Text.Equals(string.Empty))
            {
                MessageBox.Show("The variable name or value cannot be empty.", "Empty variable name or value", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            tbValue.Text = tbValue.Text.Replace(Environment.NewLine, string.Empty);
            Environment.SetEnvironmentVariable(tbVariable.Text, tbValue.Text, target);
            this.Close();
        }
    }
}
