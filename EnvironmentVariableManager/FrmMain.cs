using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace EnvironmentVariableManager
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            IDictionary userEnvironmentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);
            IDictionary machineEnvironmentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine);

            dgvUserVariables.DataSource = dictionaryToDataTable(userEnvironmentVariables);
            dgvSystemVariables.DataSource = dictionaryToDataTable(machineEnvironmentVariables);
        }

        private DataTable dictionaryToDataTable(IDictionary dictVariables)
        {
            DataTable dtVariables = new DataTable();
            dtVariables.Columns.Add("variable_name");
            dtVariables.Columns.Add("variable_value");

            foreach (DictionaryEntry item in dictVariables)
            {
                DataRow newRow = dtVariables.NewRow();
                newRow["variable_name"] = item.Key;
                newRow["variable_value"] = item.Value;
                dtVariables.Rows.Add(newRow);
            }

            return dtVariables;
        }

        private void dgvUserVariables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String variable = dgvUserVariables.Rows[e.RowIndex].Cells[0].Value as String;
            String value = dgvUserVariables.Rows[e.RowIndex].Cells[1].Value as String;
            using (FrmAddEditVariable edit = new FrmAddEditVariable(EnvironmentVariableTarget.User, variable, value))
            {
                edit.ShowDialog();
            }
        }

        private void dgvSystemVariables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String variable = dgvSystemVariables.Rows[e.RowIndex].Cells[0].Value as String;
            String value = dgvSystemVariables.Rows[e.RowIndex].Cells[1].Value as String;
            using (FrmAddEditVariable edit = new FrmAddEditVariable(EnvironmentVariableTarget.Machine, variable, value))
            {
                edit.ShowDialog();
            }
        }

        private void userVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmAddEditVariable add = new FrmAddEditVariable(EnvironmentVariableTarget.User))
            {
                add.ShowDialog();
            }
        }

        private void systemVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmAddEditVariable add = new FrmAddEditVariable(EnvironmentVariableTarget.Machine))
            {
                add.ShowDialog();
            }
        }
    }
}
