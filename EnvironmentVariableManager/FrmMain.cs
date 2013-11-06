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
using System.Xml;

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
            bindUserVariableTable();
            bindSystemVariableTable();
        }

        private void bindSystemVariableTable()
        {
            IDictionary machineEnvironmentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.Machine);
            dgvSystemVariables.DataSource = dictionaryToDataTable(machineEnvironmentVariables);
        }

        private void bindUserVariableTable()
        {
            IDictionary userEnvironmentVariables = Environment.GetEnvironmentVariables(EnvironmentVariableTarget.User);
            dgvUserVariables.DataSource = dictionaryToDataTable(userEnvironmentVariables);
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

            foreach(DataRow row in dataTable.Rows)
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
            
        }

        private void dgvSystemVariables_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}
