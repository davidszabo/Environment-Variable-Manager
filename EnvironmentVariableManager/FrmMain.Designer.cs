namespace EnvironmentVariableManager
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvUserVariables = new System.Windows.Forms.DataGridView();
            this.clUserVariableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUserVariableValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSystemVariables = new System.Windows.Forms.DataGridView();
            this.clSystemVariableName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clSystemVariableValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scMainContainer = new System.Windows.Forms.SplitContainer();
            this.gbUserVariables = new System.Windows.Forms.GroupBox();
            this.gbSystemVariables = new System.Windows.Forms.GroupBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addNewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemVariableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userVariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.systemVariablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.importToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.userVariablesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.systemVariablesToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemVariables)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scMainContainer)).BeginInit();
            this.scMainContainer.Panel1.SuspendLayout();
            this.scMainContainer.Panel2.SuspendLayout();
            this.scMainContainer.SuspendLayout();
            this.gbUserVariables.SuspendLayout();
            this.gbSystemVariables.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUserVariables
            // 
            this.dgvUserVariables.AllowUserToAddRows = false;
            this.dgvUserVariables.AllowUserToDeleteRows = false;
            this.dgvUserVariables.AllowUserToResizeRows = false;
            this.dgvUserVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUserVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUserVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clUserVariableName,
            this.clUserVariableValue});
            this.dgvUserVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUserVariables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvUserVariables.Location = new System.Drawing.Point(10, 23);
            this.dgvUserVariables.Name = "dgvUserVariables";
            this.dgvUserVariables.ReadOnly = true;
            this.dgvUserVariables.RowHeadersVisible = false;
            this.dgvUserVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUserVariables.Size = new System.Drawing.Size(604, 176);
            this.dgvUserVariables.TabIndex = 2;
            this.dgvUserVariables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUserVariables_CellDoubleClick);
            this.dgvUserVariables.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvUserVariables_KeyDown);
            // 
            // clUserVariableName
            // 
            this.clUserVariableName.DataPropertyName = "variable_name";
            this.clUserVariableName.FillWeight = 30F;
            this.clUserVariableName.HeaderText = "Variable";
            this.clUserVariableName.Name = "clUserVariableName";
            this.clUserVariableName.ReadOnly = true;
            // 
            // clUserVariableValue
            // 
            this.clUserVariableValue.DataPropertyName = "variable_value";
            this.clUserVariableValue.FillWeight = 70F;
            this.clUserVariableValue.HeaderText = "Value";
            this.clUserVariableValue.Name = "clUserVariableValue";
            this.clUserVariableValue.ReadOnly = true;
            // 
            // dgvSystemVariables
            // 
            this.dgvSystemVariables.AllowUserToAddRows = false;
            this.dgvSystemVariables.AllowUserToDeleteRows = false;
            this.dgvSystemVariables.AllowUserToResizeRows = false;
            this.dgvSystemVariables.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSystemVariables.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSystemVariables.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clSystemVariableName,
            this.clSystemVariableValue});
            this.dgvSystemVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSystemVariables.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.dgvSystemVariables.Location = new System.Drawing.Point(10, 23);
            this.dgvSystemVariables.Name = "dgvSystemVariables";
            this.dgvSystemVariables.ReadOnly = true;
            this.dgvSystemVariables.RowHeadersVisible = false;
            this.dgvSystemVariables.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSystemVariables.Size = new System.Drawing.Size(604, 172);
            this.dgvSystemVariables.TabIndex = 3;
            this.dgvSystemVariables.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSystemVariables_CellDoubleClick);
            this.dgvSystemVariables.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvSystemVariables_KeyDown);
            // 
            // clSystemVariableName
            // 
            this.clSystemVariableName.DataPropertyName = "variable_name";
            this.clSystemVariableName.FillWeight = 30F;
            this.clSystemVariableName.HeaderText = "Variable";
            this.clSystemVariableName.Name = "clSystemVariableName";
            this.clSystemVariableName.ReadOnly = true;
            // 
            // clSystemVariableValue
            // 
            this.clSystemVariableValue.DataPropertyName = "variable_value";
            this.clSystemVariableValue.FillWeight = 70F;
            this.clSystemVariableValue.HeaderText = "Value";
            this.clSystemVariableValue.Name = "clSystemVariableValue";
            this.clSystemVariableValue.ReadOnly = true;
            // 
            // scMainContainer
            // 
            this.scMainContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scMainContainer.Location = new System.Drawing.Point(0, 24);
            this.scMainContainer.Name = "scMainContainer";
            this.scMainContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scMainContainer.Panel1
            // 
            this.scMainContainer.Panel1.Controls.Add(this.gbUserVariables);
            // 
            // scMainContainer.Panel2
            // 
            this.scMainContainer.Panel2.Controls.Add(this.gbSystemVariables);
            this.scMainContainer.Size = new System.Drawing.Size(624, 418);
            this.scMainContainer.SplitterDistance = 209;
            this.scMainContainer.TabIndex = 4;
            // 
            // gbUserVariables
            // 
            this.gbUserVariables.Controls.Add(this.dgvUserVariables);
            this.gbUserVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbUserVariables.Location = new System.Drawing.Point(0, 0);
            this.gbUserVariables.Margin = new System.Windows.Forms.Padding(5);
            this.gbUserVariables.Name = "gbUserVariables";
            this.gbUserVariables.Padding = new System.Windows.Forms.Padding(10);
            this.gbUserVariables.Size = new System.Drawing.Size(624, 209);
            this.gbUserVariables.TabIndex = 3;
            this.gbUserVariables.TabStop = false;
            this.gbUserVariables.Text = "User variables";
            // 
            // gbSystemVariables
            // 
            this.gbSystemVariables.Controls.Add(this.dgvSystemVariables);
            this.gbSystemVariables.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbSystemVariables.Location = new System.Drawing.Point(0, 0);
            this.gbSystemVariables.Name = "gbSystemVariables";
            this.gbSystemVariables.Padding = new System.Windows.Forms.Padding(10);
            this.gbSystemVariables.Size = new System.Drawing.Size(624, 205);
            this.gbSystemVariables.TabIndex = 4;
            this.gbSystemVariables.TabStop = false;
            this.gbSystemVariables.Text = "System variables";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addNewToolStripMenuItem,
            this.manageToolStripMenuItem,
            this.importToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(624, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addNewToolStripMenuItem
            // 
            this.addNewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userVariableToolStripMenuItem,
            this.systemVariableToolStripMenuItem});
            this.addNewToolStripMenuItem.Name = "addNewToolStripMenuItem";
            this.addNewToolStripMenuItem.Size = new System.Drawing.Size(77, 20);
            this.addNewToolStripMenuItem.Text = "Add New...";
            // 
            // userVariableToolStripMenuItem
            // 
            this.userVariableToolStripMenuItem.Name = "userVariableToolStripMenuItem";
            this.userVariableToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.userVariableToolStripMenuItem.Text = "User Variable";
            this.userVariableToolStripMenuItem.Click += new System.EventHandler(this.userVariableToolStripMenuItem_Click);
            // 
            // systemVariableToolStripMenuItem
            // 
            this.systemVariableToolStripMenuItem.Name = "systemVariableToolStripMenuItem";
            this.systemVariableToolStripMenuItem.Size = new System.Drawing.Size(157, 22);
            this.systemVariableToolStripMenuItem.Text = "System Variable";
            this.systemVariableToolStripMenuItem.Click += new System.EventHandler(this.systemVariableToolStripMenuItem_Click);
            // 
            // manageToolStripMenuItem
            // 
            this.manageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userVariablesToolStripMenuItem,
            this.systemVariablesToolStripMenuItem});
            this.manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            this.manageToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.manageToolStripMenuItem.Text = "Export...";
            // 
            // userVariablesToolStripMenuItem
            // 
            this.userVariablesToolStripMenuItem.Name = "userVariablesToolStripMenuItem";
            this.userVariablesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.userVariablesToolStripMenuItem.Text = "User Variables";
            this.userVariablesToolStripMenuItem.Click += new System.EventHandler(this.userVariablesToolStripMenuItem_Click);
            // 
            // systemVariablesToolStripMenuItem
            // 
            this.systemVariablesToolStripMenuItem.Name = "systemVariablesToolStripMenuItem";
            this.systemVariablesToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.systemVariablesToolStripMenuItem.Text = "System Variables";
            this.systemVariablesToolStripMenuItem.Click += new System.EventHandler(this.systemVariablesToolStripMenuItem_Click);
            // 
            // importToolStripMenuItem
            // 
            this.importToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.userVariablesToolStripMenuItem1,
            this.systemVariablesToolStripMenuItem1});
            this.importToolStripMenuItem.Name = "importToolStripMenuItem";
            this.importToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.importToolStripMenuItem.Text = "Import...";
            // 
            // userVariablesToolStripMenuItem1
            // 
            this.userVariablesToolStripMenuItem1.Name = "userVariablesToolStripMenuItem1";
            this.userVariablesToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.userVariablesToolStripMenuItem1.Text = "User Variables";
            // 
            // systemVariablesToolStripMenuItem1
            // 
            this.systemVariablesToolStripMenuItem1.Name = "systemVariablesToolStripMenuItem1";
            this.systemVariablesToolStripMenuItem1.Size = new System.Drawing.Size(162, 22);
            this.systemVariablesToolStripMenuItem1.Text = "System Variables";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 442);
            this.Controls.Add(this.scMainContainer);
            this.Controls.Add(this.menuStrip1);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Environment Variable Manager";
            this.Load += new System.EventHandler(this.FrmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvUserVariables)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSystemVariables)).EndInit();
            this.scMainContainer.Panel1.ResumeLayout(false);
            this.scMainContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scMainContainer)).EndInit();
            this.scMainContainer.ResumeLayout(false);
            this.gbUserVariables.ResumeLayout(false);
            this.gbSystemVariables.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvUserVariables;
        private System.Windows.Forms.DataGridView dgvSystemVariables;
        private System.Windows.Forms.SplitContainer scMainContainer;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserVariableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUserVariableValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSystemVariableName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clSystemVariableValue;
        private System.Windows.Forms.GroupBox gbUserVariables;
        private System.Windows.Forms.GroupBox gbSystemVariables;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addNewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemVariableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userVariablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem systemVariablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem importToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem userVariablesToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem systemVariablesToolStripMenuItem1;
    }
}

