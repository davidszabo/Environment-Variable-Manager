using System;
using System.Collections;
using System.Data;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

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
            try
            {
                bindUserVariableTable();
                bindSystemVariableTable();
            }
            catch (Exception)
            {
                string errorMessage = "An error occured while populating variable lists. Probably you do not have right to read environment variables. \nThe application closes itself.";
                string errorCaption = "Error while reading environment variables";
                MessageBox.Show(errorMessage, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void bindSystemVariableTable()
        {
            IDictionary machineEnvironmentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine);

            string keyName = @"SYSTEM\CurrentControlSet\Control\Session Manager\Environment\";
            dgvSystemVariables.DataSource = dictionaryToDataTable(machineEnvironmentVariables, Registry.LocalMachine.OpenSubKey(keyName));
        }

        private void bindUserVariableTable()
        {
            IDictionary userEnvironmentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);

            string keyName = @"Environment\";
            dgvUserVariables.DataSource = dictionaryToDataTable(userEnvironmentVariables, Registry.CurrentUser.OpenSubKey(keyName));
        }

        private DataTable dictionaryToDataTable(IDictionary dictVariables, RegistryKey subKey)
        {
            DataTable dtVariables = new DataTable();
            dtVariables.Columns.Add("variable_name");
            dtVariables.Columns.Add("variable_value");

            foreach (DictionaryEntry item in dictVariables)
            {
                DataRow newRow = dtVariables.NewRow();
                newRow["variable_name"] = item.Key;
                newRow["variable_value"] = subKey.GetValue(item.Key as String, string.Empty, RegistryValueOptions.DoNotExpandEnvironmentNames) as String;
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
            bindUserVariableTable();
        }

        private void dgvSystemVariables_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            String variable = dgvSystemVariables.Rows[e.RowIndex].Cells[0].Value as String;
            String value = dgvSystemVariables.Rows[e.RowIndex].Cells[1].Value as String;
            using (FrmAddEditVariable edit = new FrmAddEditVariable(EnvironmentVariableTarget.Machine, variable, value))
            {
                edit.ShowDialog();
            }
            bindSystemVariableTable();
        }

        private void userVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmAddEditVariable add = new FrmAddEditVariable(EnvironmentVariableTarget.User))
            {
                add.ShowDialog();
            }
            bindUserVariableTable();
        }

        private void systemVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (FrmAddEditVariable add = new FrmAddEditVariable(EnvironmentVariableTarget.Machine))
            {
                add.ShowDialog();
            }
            bindSystemVariableTable();
        }

        private void userVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog exportUserVariablesDialog = new SaveFileDialog())
            {
                exportUserVariablesDialog.Filter = "XML Document|*.xml";
                exportUserVariablesDialog.Title = "Export user variables";
                exportUserVariablesDialog.ShowDialog();
                if (exportUserVariablesDialog.FileName != string.Empty)
                {
                    XmlDocument exportedUserVariables = exportVariablesToXml(dgvUserVariables.DataSource as DataTable);
                    exportedUserVariables.Save(exportUserVariablesDialog.FileName);
                }
            }
        }

        private void systemVariablesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog exportSystemVariablesDialog = new SaveFileDialog())
            {
                exportSystemVariablesDialog.Filter = "XML Document|*.xml";
                exportSystemVariablesDialog.Title = "Export system variables";
                exportSystemVariablesDialog.ShowDialog();
                if (exportSystemVariablesDialog.FileName != string.Empty)
                {
                    XmlDocument exportedSystemVariables = exportVariablesToXml(dgvSystemVariables.DataSource as DataTable);
                    exportedSystemVariables.Save(exportSystemVariablesDialog.FileName);
                }
            }
        }

        private XmlDocument exportVariablesToXml(DataTable dataTable)
        {
            XmlDocument document = new XmlDocument();
            XmlNode declarationNode = document.CreateXmlDeclaration("1.0", "UTF-8", null);
            document.AppendChild(declarationNode);
            XmlNode rootNode = document.CreateElement("variables");
            document.AppendChild(rootNode);

            foreach (DataRow row in dataTable.Rows)
            {
                XmlNode variableNode = document.CreateElement("variable");

                XmlAttribute nameAttribute = document.CreateAttribute("name");
                nameAttribute.Value = row[0] as String;
                XmlAttribute valueAttribute = document.CreateAttribute("value");
                valueAttribute.Value = row[1] as String;

                variableNode.Attributes.Append(nameAttribute);
                variableNode.Attributes.Append(valueAttribute);

                rootNode.AppendChild(variableNode);
            }

            return document;
        }

        private void dgvUserVariables_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteUserVariables();
                bindUserVariableTable();
            }
        }

        private void deleteUserVariables()
        {
            if (dgvUserVariables.SelectedRows.Count == 0)
            {
                return;
            }
            string warningText = "After deleting user variables, some of your applications may stop running. \nAre you sure you want to continue?";
            string warningCaption = "Deleting user variables";
            DialogResult result = MessageBox.Show(warningText, warningCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvUserVariables.SelectedRows)
                {
                    Environment.SetEnvironmentVariable(row.Cells[0].Value as String, string.Empty, EnvironmentVariableTarget.User);
                }
            }
        }

        private void dgvSystemVariables_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                deleteSystemVariables();
                bindSystemVariableTable();
            }
        }

        private void deleteSystemVariables()
        {
            if (dgvSystemVariables.SelectedRows.Count == 0)
            {
                return;
            }
            string warningText = "After deleting system variables, your operating system may stop working properly. \nAre you sure you want to continue?";
            string warningCaption = "Deleting system variables";
            DialogResult result = MessageBox.Show(warningText, warningCaption, MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                foreach (DataGridViewRow row in dgvSystemVariables.SelectedRows)
                {
                    try
                    {
                        Environment.SetEnvironmentVariable(row.Cells[0].Value as String, string.Empty, EnvironmentVariableTarget.Machine);
                    }
                    catch (Exception)
                    {
                        string errorMessage = "An error occured while deleting variable(s). Probably you do not have right to delete environment variables.";
                        string errorCaption = "Error while deleting environment variable(s)";
                        MessageBox.Show(errorMessage, errorCaption, MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
