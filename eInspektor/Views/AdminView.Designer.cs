namespace eInspektor.Views
{
    partial class AdminView
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
            this.components = new System.ComponentModel.Container();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this._is_projDataSet = new eInspektor._is_projDataSet();
            this.adminTableAdapter = new eInspektor._is_projDataSetTableAdapters.adminTableAdapter();
            this.inspectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSources = new eInspektor.DataSources();
            this.inspectorTableAdapter = new eInspektor.DataSourcesTableAdapters.inspectorTableAdapter();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.odjavaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.promjenaLozinkeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordhashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iscoordinatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordhashDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dodajKorisnikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._is_projDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this._is_projDataSet;
            // 
            // _is_projDataSet
            // 
            this._is_projDataSet.DataSetName = "_is_projDataSet";
            this._is_projDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // inspectorBindingSource
            // 
            this.inspectorBindingSource.DataMember = "inspector";
            this.inspectorBindingSource.DataSource = this.dataSources;
            // 
            // dataSources
            // 
            this.dataSources.DataSetName = "DataSources";
            this.dataSources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inspectorTableAdapter
            // 
            this.inspectorTableAdapter.ClearBeforeFill = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.odjavaToolStripMenuItem,
            this.promjenaLozinkeToolStripMenuItem,
            this.dodajKorisnikaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.menuStrip1.Size = new System.Drawing.Size(1241, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // odjavaToolStripMenuItem
            // 
            this.odjavaToolStripMenuItem.Name = "odjavaToolStripMenuItem";
            this.odjavaToolStripMenuItem.Size = new System.Drawing.Size(70, 24);
            this.odjavaToolStripMenuItem.Text = "Odjava";
            this.odjavaToolStripMenuItem.Click += new System.EventHandler(this.odjavaToolStripMenuItem_Click_1);
            // 
            // promjenaLozinkeToolStripMenuItem
            // 
            this.promjenaLozinkeToolStripMenuItem.Name = "promjenaLozinkeToolStripMenuItem";
            this.promjenaLozinkeToolStripMenuItem.Size = new System.Drawing.Size(137, 24);
            this.promjenaLozinkeToolStripMenuItem.Text = "Promjena lozinke";
            this.promjenaLozinkeToolStripMenuItem.Click += new System.EventHandler(this.promjenaLozinkeToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer1.Size = new System.Drawing.Size(1241, 422);
            this.splitContainer1.SplitterDistance = 413;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.saltDataGridViewTextBoxColumn,
            this.passwordhashDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.adminBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(413, 422);
            this.dataGridView1.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "Korisničko ime";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            // 
            // saltDataGridViewTextBoxColumn
            // 
            this.saltDataGridViewTextBoxColumn.DataPropertyName = "salt";
            this.saltDataGridViewTextBoxColumn.HeaderText = "salt";
            this.saltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saltDataGridViewTextBoxColumn.Name = "saltDataGridViewTextBoxColumn";
            this.saltDataGridViewTextBoxColumn.Visible = false;
            this.saltDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordhashDataGridViewTextBoxColumn
            // 
            this.passwordhashDataGridViewTextBoxColumn.DataPropertyName = "password_hash";
            this.passwordhashDataGridViewTextBoxColumn.HeaderText = "password_hash";
            this.passwordhashDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordhashDataGridViewTextBoxColumn.Name = "passwordhashDataGridViewTextBoxColumn";
            this.passwordhashDataGridViewTextBoxColumn.Visible = false;
            this.passwordhashDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewTextBoxColumn.HeaderText = "isActive";
            this.isActiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            this.isActiveDataGridViewTextBoxColumn.Visible = false;
            this.isActiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AutoGenerateColumns = false;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn1,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.unavailableDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.iscoordinatorDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn1,
            this.saltDataGridViewTextBoxColumn1,
            this.passwordhashDataGridViewTextBoxColumn1,
            this.isActiveDataGridViewTextBoxColumn1});
            this.dataGridView2.DataSource = this.inspectorBindingSource;
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(824, 422);
            this.dataGridView2.TabIndex = 0;
            // 
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Visible = false;
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Odsjek";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            // 
            // unavailableDataGridViewTextBoxColumn
            // 
            this.unavailableDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unavailableDataGridViewTextBoxColumn.DataPropertyName = "unavailable";
            this.unavailableDataGridViewTextBoxColumn.HeaderText = "Odsustvo";
            this.unavailableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unavailableDataGridViewTextBoxColumn.Name = "unavailableDataGridViewTextBoxColumn";
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "shift";
            this.shiftDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.Visible = false;
            this.shiftDataGridViewTextBoxColumn.Width = 125;
            // 
            // iscoordinatorDataGridViewTextBoxColumn
            // 
            this.iscoordinatorDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.iscoordinatorDataGridViewTextBoxColumn.DataPropertyName = "is_coordinator";
            this.iscoordinatorDataGridViewTextBoxColumn.HeaderText = "Koordinator";
            this.iscoordinatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iscoordinatorDataGridViewTextBoxColumn.Name = "iscoordinatorDataGridViewTextBoxColumn";
            this.iscoordinatorDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.iscoordinatorDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "Korisničko ime";
            this.usernameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            // 
            // saltDataGridViewTextBoxColumn1
            // 
            this.saltDataGridViewTextBoxColumn1.DataPropertyName = "salt";
            this.saltDataGridViewTextBoxColumn1.HeaderText = "salt";
            this.saltDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.saltDataGridViewTextBoxColumn1.Name = "saltDataGridViewTextBoxColumn1";
            this.saltDataGridViewTextBoxColumn1.Visible = false;
            this.saltDataGridViewTextBoxColumn1.Width = 125;
            // 
            // passwordhashDataGridViewTextBoxColumn1
            // 
            this.passwordhashDataGridViewTextBoxColumn1.DataPropertyName = "password_hash";
            this.passwordhashDataGridViewTextBoxColumn1.HeaderText = "password_hash";
            this.passwordhashDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.passwordhashDataGridViewTextBoxColumn1.Name = "passwordhashDataGridViewTextBoxColumn1";
            this.passwordhashDataGridViewTextBoxColumn1.Visible = false;
            this.passwordhashDataGridViewTextBoxColumn1.Width = 125;
            // 
            // isActiveDataGridViewTextBoxColumn1
            // 
            this.isActiveDataGridViewTextBoxColumn1.DataPropertyName = "isActive";
            this.isActiveDataGridViewTextBoxColumn1.HeaderText = "isActive";
            this.isActiveDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.isActiveDataGridViewTextBoxColumn1.Name = "isActiveDataGridViewTextBoxColumn1";
            this.isActiveDataGridViewTextBoxColumn1.Visible = false;
            this.isActiveDataGridViewTextBoxColumn1.Width = 125;
            // 
            // dodajKorisnikaToolStripMenuItem
            // 
            this.dodajKorisnikaToolStripMenuItem.Name = "dodajKorisnikaToolStripMenuItem";
            this.dodajKorisnikaToolStripMenuItem.Size = new System.Drawing.Size(126, 24);
            this.dodajKorisnikaToolStripMenuItem.Text = "Dodaj korisnika";
            this.dodajKorisnikaToolStripMenuItem.Click += new System.EventHandler(this.dodajKorisnikaToolStripMenuItem_Click);
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1241, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "AdminView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administratorska aplikacija";
            this.Load += new System.EventHandler(this.AdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._is_projDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private _is_projDataSet _is_projDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private _is_projDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private DataSources dataSources;
        private System.Windows.Forms.BindingSource inspectorBindingSource;
        private DataSourcesTableAdapters.inspectorTableAdapter inspectorTableAdapter;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem odjavaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem promjenaLozinkeToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordhashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unavailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn iscoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordhashDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn1;
        private System.Windows.Forms.ToolStripMenuItem dodajKorisnikaToolStripMenuItem;
    }
}