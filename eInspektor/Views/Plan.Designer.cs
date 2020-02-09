namespace eInspektor.Views
{
    partial class Plan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.blaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ponedjeljakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utorakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.srijedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.četvrtakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.companiesGridView = new System.Windows.Forms.DataGridView();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSources = new eInspektor.DataSources();
            this.controlsGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicles_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isfinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_regular = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.reportcontentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controljustifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlTableAdapter = new eInspektor.DataSourcesTableAdapters.controlTableAdapter();
            this.companyTableAdapter = new eInspektor.DataSourcesTableAdapters.companyTableAdapter();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ručnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automatskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.id_subject = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookkeeperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_control_date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastcontroltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.companiesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blaToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.bbToolStripMenuItem,
            this.obrišiToolStripMenuItem,
            this.bToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1257, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // blaToolStripMenuItem
            // 
            this.blaToolStripMenuItem.Name = "blaToolStripMenuItem";
            this.blaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.blaToolStripMenuItem.Text = "Nazad";
            this.blaToolStripMenuItem.Click += new System.EventHandler(this.nazadToolStripMenuItem_Click);
            // 
            // bbToolStripMenuItem
            // 
            this.bbToolStripMenuItem.Name = "bbToolStripMenuItem";
            this.bbToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.bbToolStripMenuItem.Text = "Sačuvaj";
            this.bbToolStripMenuItem.Click += new System.EventHandler(this.sacuvaj_ToolStripMenuItem_Click);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.CheckOnClick = true;
            this.bToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ponedjeljakToolStripMenuItem,
            this.utorakToolStripMenuItem,
            this.srijedaToolStripMenuItem,
            this.četvrtakToolStripMenuItem,
            this.petakToolStripMenuItem,
            this.subotaToolStripMenuItem});
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(50, 24);
            this.bToolStripMenuItem.Text = "Dan";
            // 
            // ponedjeljakToolStripMenuItem
            // 
            this.ponedjeljakToolStripMenuItem.Name = "ponedjeljakToolStripMenuItem";
            this.ponedjeljakToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.ponedjeljakToolStripMenuItem.Text = "Ponedjeljak";
            // 
            // utorakToolStripMenuItem
            // 
            this.utorakToolStripMenuItem.Name = "utorakToolStripMenuItem";
            this.utorakToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.utorakToolStripMenuItem.Text = "Utorak";
            // 
            // srijedaToolStripMenuItem
            // 
            this.srijedaToolStripMenuItem.Name = "srijedaToolStripMenuItem";
            this.srijedaToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.srijedaToolStripMenuItem.Text = "Srijeda";
            // 
            // četvrtakToolStripMenuItem
            // 
            this.četvrtakToolStripMenuItem.Name = "četvrtakToolStripMenuItem";
            this.četvrtakToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.četvrtakToolStripMenuItem.Text = "Četvrtak";
            // 
            // petakToolStripMenuItem
            // 
            this.petakToolStripMenuItem.Name = "petakToolStripMenuItem";
            this.petakToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.petakToolStripMenuItem.Text = "Petak";
            // 
            // subotaToolStripMenuItem
            // 
            this.subotaToolStripMenuItem.Name = "subotaToolStripMenuItem";
            this.subotaToolStripMenuItem.Size = new System.Drawing.Size(168, 26);
            this.subotaToolStripMenuItem.Text = "Subota";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.companiesGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.controlsGridView);
            this.splitContainer1.Size = new System.Drawing.Size(1257, 436);
            this.splitContainer1.SplitterDistance = 316;
            this.splitContainer1.TabIndex = 1;
            // 
            // companiesGridView
            // 
            this.companiesGridView.AllowUserToAddRows = false;
            this.companiesGridView.AllowUserToDeleteRows = false;
            this.companiesGridView.AutoGenerateColumns = false;
            this.companiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id_subject,
            this.nameColumn,
            this.jibDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.bookkeeperDataGridViewTextBoxColumn,
            this.last_control_date,
            this.lastcontroltypeDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn1});
            this.companiesGridView.DataSource = this.companyBindingSource;
            this.companiesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companiesGridView.Location = new System.Drawing.Point(0, 0);
            this.companiesGridView.Name = "companiesGridView";
            this.companiesGridView.ReadOnly = true;
            this.companiesGridView.RowHeadersWidth = 51;
            this.companiesGridView.RowTemplate.Height = 24;
            this.companiesGridView.Size = new System.Drawing.Size(316, 436);
            this.companiesGridView.TabIndex = 0;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.dataSources;
            // 
            // dataSources
            // 
            this.dataSources.DataSetName = "DataSources";
            this.dataSources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controlsGridView
            // 
            this.controlsGridView.AllowUserToAddRows = false;
            this.controlsGridView.AllowUserToDeleteRows = false;
            this.controlsGridView.AutoGenerateColumns = false;
            this.controlsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.controlsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.company,
            this.address,
            this.inspector,
            this.vehicles_column,
            this.company_id,
            this.startdateDataGridViewTextBoxColumn,
            this.finishdateDataGridViewTextBoxColumn,
            this.isfinishedDataGridViewTextBoxColumn,
            this.is_regular,
            this.reportcontentDataGridViewTextBoxColumn,
            this.controljustifiedDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.controlsGridView.DataSource = this.controlBindingSource;
            this.controlsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsGridView.Location = new System.Drawing.Point(0, 0);
            this.controlsGridView.Name = "controlsGridView";
            this.controlsGridView.ReadOnly = true;
            this.controlsGridView.RowHeadersWidth = 51;
            this.controlsGridView.RowTemplate.Height = 24;
            this.controlsGridView.Size = new System.Drawing.Size(937, 436);
            this.controlsGridView.TabIndex = 0;
            this.controlsGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleGridView_CellValueChanged);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // company
            // 
            this.company.HeaderText = "Subjekt";
            this.company.MinimumWidth = 6;
            this.company.Name = "company";
            this.company.ReadOnly = true;
            this.company.Width = 300;
            // 
            // address
            // 
            this.address.HeaderText = "Adresa";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            this.address.ReadOnly = true;
            this.address.Width = 300;
            // 
            // inspector
            // 
            this.inspector.HeaderText = "Inspektor";
            this.inspector.MinimumWidth = 6;
            this.inspector.Name = "inspector";
            this.inspector.ReadOnly = true;
            this.inspector.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inspector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.inspector.Width = 200;
            // 
            // vehicles_column
            // 
            this.vehicles_column.HeaderText = "Vozila";
            this.vehicles_column.MinimumWidth = 6;
            this.vehicles_column.Name = "vehicles_column";
            this.vehicles_column.ReadOnly = true;
            this.vehicles_column.Width = 200;
            // 
            // company_id
            // 
            this.company_id.DataPropertyName = "company_id";
            this.company_id.HeaderText = "company_id";
            this.company_id.MinimumWidth = 6;
            this.company_id.Name = "company_id";
            this.company_id.ReadOnly = true;
            this.company_id.Visible = false;
            this.company_id.Width = 125;
            // 
            // startdateDataGridViewTextBoxColumn
            // 
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "start_date";
            this.startdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.startdateDataGridViewTextBoxColumn.Visible = false;
            this.startdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // finishdateDataGridViewTextBoxColumn
            // 
            this.finishdateDataGridViewTextBoxColumn.DataPropertyName = "finish_date";
            this.finishdateDataGridViewTextBoxColumn.HeaderText = "finish_date";
            this.finishdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finishdateDataGridViewTextBoxColumn.Name = "finishdateDataGridViewTextBoxColumn";
            this.finishdateDataGridViewTextBoxColumn.ReadOnly = true;
            this.finishdateDataGridViewTextBoxColumn.Visible = false;
            this.finishdateDataGridViewTextBoxColumn.Width = 125;
            // 
            // isfinishedDataGridViewTextBoxColumn
            // 
            this.isfinishedDataGridViewTextBoxColumn.DataPropertyName = "is_finished";
            this.isfinishedDataGridViewTextBoxColumn.HeaderText = "is_finished";
            this.isfinishedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isfinishedDataGridViewTextBoxColumn.Name = "isfinishedDataGridViewTextBoxColumn";
            this.isfinishedDataGridViewTextBoxColumn.ReadOnly = true;
            this.isfinishedDataGridViewTextBoxColumn.Visible = false;
            this.isfinishedDataGridViewTextBoxColumn.Width = 125;
            // 
            // is_regular
            // 
            this.is_regular.DataPropertyName = "is_regular";
            this.is_regular.HeaderText = "Redovna";
            this.is_regular.MinimumWidth = 6;
            this.is_regular.Name = "is_regular";
            this.is_regular.ReadOnly = true;
            this.is_regular.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_regular.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.is_regular.Width = 80;
            // 
            // reportcontentDataGridViewTextBoxColumn
            // 
            this.reportcontentDataGridViewTextBoxColumn.DataPropertyName = "report_content";
            this.reportcontentDataGridViewTextBoxColumn.HeaderText = "report_content";
            this.reportcontentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.reportcontentDataGridViewTextBoxColumn.Name = "reportcontentDataGridViewTextBoxColumn";
            this.reportcontentDataGridViewTextBoxColumn.ReadOnly = true;
            this.reportcontentDataGridViewTextBoxColumn.Visible = false;
            this.reportcontentDataGridViewTextBoxColumn.Width = 125;
            // 
            // controljustifiedDataGridViewTextBoxColumn
            // 
            this.controljustifiedDataGridViewTextBoxColumn.DataPropertyName = "control_justified";
            this.controljustifiedDataGridViewTextBoxColumn.HeaderText = "control_justified";
            this.controljustifiedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.controljustifiedDataGridViewTextBoxColumn.Name = "controljustifiedDataGridViewTextBoxColumn";
            this.controljustifiedDataGridViewTextBoxColumn.ReadOnly = true;
            this.controljustifiedDataGridViewTextBoxColumn.Visible = false;
            this.controljustifiedDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewTextBoxColumn.HeaderText = "isActive";
            this.isActiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            this.isActiveDataGridViewTextBoxColumn.ReadOnly = true;
            this.isActiveDataGridViewTextBoxColumn.Visible = false;
            this.isActiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // controlBindingSource
            // 
            this.controlBindingSource.DataMember = "control";
            this.controlBindingSource.DataSource = this.dataSources;
            // 
            // controlTableAdapter
            // 
            this.controlTableAdapter.ClearBeforeFill = true;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ručnoToolStripMenuItem,
            this.automatskiToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.dodajToolStripMenuItem.Text = "Dodaj...";
            // 
            // ručnoToolStripMenuItem
            // 
            this.ručnoToolStripMenuItem.Name = "ručnoToolStripMenuItem";
            this.ručnoToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.ručnoToolStripMenuItem.Text = "Ručno";
            this.ručnoToolStripMenuItem.Click += new System.EventHandler(this.ručnoToolStripMenuItem_Click);
            // 
            // automatskiToolStripMenuItem
            // 
            this.automatskiToolStripMenuItem.Name = "automatskiToolStripMenuItem";
            this.automatskiToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.automatskiToolStripMenuItem.Text = "Automatski";
            // 
            // id_subject
            // 
            this.id_subject.DataPropertyName = "id";
            this.id_subject.HeaderText = "id";
            this.id_subject.MinimumWidth = 6;
            this.id_subject.Name = "id_subject";
            this.id_subject.ReadOnly = true;
            this.id_subject.Visible = false;
            this.id_subject.Width = 125;
            // 
            // nameColumn
            // 
            this.nameColumn.DataPropertyName = "name";
            this.nameColumn.HeaderText = "Subjekti";
            this.nameColumn.MinimumWidth = 6;
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.ReadOnly = true;
            this.nameColumn.Width = 200;
            // 
            // jibDataGridViewTextBoxColumn
            // 
            this.jibDataGridViewTextBoxColumn.DataPropertyName = "jib";
            this.jibDataGridViewTextBoxColumn.HeaderText = "jib";
            this.jibDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.jibDataGridViewTextBoxColumn.Name = "jibDataGridViewTextBoxColumn";
            this.jibDataGridViewTextBoxColumn.ReadOnly = true;
            this.jibDataGridViewTextBoxColumn.Visible = false;
            this.jibDataGridViewTextBoxColumn.Width = 125;
            // 
            // locationDataGridViewTextBoxColumn
            // 
            this.locationDataGridViewTextBoxColumn.DataPropertyName = "location";
            this.locationDataGridViewTextBoxColumn.HeaderText = "location";
            this.locationDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.locationDataGridViewTextBoxColumn.Name = "locationDataGridViewTextBoxColumn";
            this.locationDataGridViewTextBoxColumn.ReadOnly = true;
            this.locationDataGridViewTextBoxColumn.Visible = false;
            this.locationDataGridViewTextBoxColumn.Width = 125;
            // 
            // ownerDataGridViewTextBoxColumn
            // 
            this.ownerDataGridViewTextBoxColumn.DataPropertyName = "owner";
            this.ownerDataGridViewTextBoxColumn.HeaderText = "owner";
            this.ownerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.ownerDataGridViewTextBoxColumn.Name = "ownerDataGridViewTextBoxColumn";
            this.ownerDataGridViewTextBoxColumn.ReadOnly = true;
            this.ownerDataGridViewTextBoxColumn.Visible = false;
            this.ownerDataGridViewTextBoxColumn.Width = 125;
            // 
            // bookkeeperDataGridViewTextBoxColumn
            // 
            this.bookkeeperDataGridViewTextBoxColumn.DataPropertyName = "bookkeeper";
            this.bookkeeperDataGridViewTextBoxColumn.HeaderText = "bookkeeper";
            this.bookkeeperDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.bookkeeperDataGridViewTextBoxColumn.Name = "bookkeeperDataGridViewTextBoxColumn";
            this.bookkeeperDataGridViewTextBoxColumn.ReadOnly = true;
            this.bookkeeperDataGridViewTextBoxColumn.Visible = false;
            this.bookkeeperDataGridViewTextBoxColumn.Width = 125;
            // 
            // last_control_date
            // 
            this.last_control_date.DataPropertyName = "last_control";
            this.last_control_date.HeaderText = "Datum posljednje kontrole";
            this.last_control_date.MinimumWidth = 6;
            this.last_control_date.Name = "last_control_date";
            this.last_control_date.ReadOnly = true;
            this.last_control_date.Width = 125;
            // 
            // lastcontroltypeDataGridViewTextBoxColumn
            // 
            this.lastcontroltypeDataGridViewTextBoxColumn.DataPropertyName = "last_control_type";
            this.lastcontroltypeDataGridViewTextBoxColumn.HeaderText = "last_control_type";
            this.lastcontroltypeDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastcontroltypeDataGridViewTextBoxColumn.Name = "lastcontroltypeDataGridViewTextBoxColumn";
            this.lastcontroltypeDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastcontroltypeDataGridViewTextBoxColumn.Visible = false;
            this.lastcontroltypeDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewTextBoxColumn1
            // 
            this.isActiveDataGridViewTextBoxColumn1.DataPropertyName = "isActive";
            this.isActiveDataGridViewTextBoxColumn1.HeaderText = "isActive";
            this.isActiveDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.isActiveDataGridViewTextBoxColumn1.Name = "isActiveDataGridViewTextBoxColumn1";
            this.isActiveDataGridViewTextBoxColumn1.ReadOnly = true;
            this.isActiveDataGridViewTextBoxColumn1.Visible = false;
            this.isActiveDataGridViewTextBoxColumn1.Width = 125;
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1257, 464);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Plan";
            this.Text = "Plan";
            this.Load += new System.EventHandler(this.Plan_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.companiesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem blaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView controlsGridView;
        private System.Windows.Forms.ToolStripMenuItem ponedjeljakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utorakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem srijedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem četvrtakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subotaToolStripMenuItem;
        private System.Windows.Forms.DataGridView companiesGridView;
        private DataSources dataSources;
        private System.Windows.Forms.BindingSource controlBindingSource;
        private DataSourcesTableAdapters.controlTableAdapter controlTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DataSourcesTableAdapters.companyTableAdapter companyTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicles_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isfinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_regular;
        private System.Windows.Forms.DataGridViewTextBoxColumn reportcontentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controljustifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ručnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automatskiToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id_subject;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn jibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookkeeperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_control_date;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastcontroltypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn1;
    }
}