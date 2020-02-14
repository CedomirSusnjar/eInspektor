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
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ručnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.automatskiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjekteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subjekteIInspektoreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dayMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ponedjeljakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utorakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.srijedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.četvrtakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.companiesGridView = new System.Windows.Forms.DataGridView();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.location = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastcontrolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSources = new eInspektor.DataSources();
            this.controlsGridView = new System.Windows.Forms.DataGridView();
            this.controlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.controlTableAdapter = new eInspektor.DataSourcesTableAdapters.controlTableAdapter();
            this.companyTableAdapter = new eInspektor.DataSourcesTableAdapters.companyTableAdapter();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicles_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.control_justified = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.is_finished = new System.Windows.Forms.DataGridViewCheckBoxColumn();
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
            this.dayMI});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1249, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // blaToolStripMenuItem
            // 
            this.blaToolStripMenuItem.Name = "blaToolStripMenuItem";
            this.blaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.blaToolStripMenuItem.Text = "Nazad";
            this.blaToolStripMenuItem.Click += new System.EventHandler(this.nazadToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ručnoToolStripMenuItem,
            this.automatskiToolStripMenuItem});
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.dodajToolStripMenuItem.Text = "Dodaj...";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // ručnoToolStripMenuItem
            // 
            this.ručnoToolStripMenuItem.Name = "ručnoToolStripMenuItem";
            this.ručnoToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.ručnoToolStripMenuItem.Text = "Ručno";
            this.ručnoToolStripMenuItem.Click += new System.EventHandler(this.ručnoToolStripMenuItem_Click);
            // 
            // automatskiToolStripMenuItem
            // 
            this.automatskiToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.subjekteToolStripMenuItem,
            this.subjekteIInspektoreToolStripMenuItem});
            this.automatskiToolStripMenuItem.Name = "automatskiToolStripMenuItem";
            this.automatskiToolStripMenuItem.Size = new System.Drawing.Size(159, 26);
            this.automatskiToolStripMenuItem.Text = "Automatski";
            // 
            // subjekteToolStripMenuItem
            // 
            this.subjekteToolStripMenuItem.Name = "subjekteToolStripMenuItem";
            this.subjekteToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.subjekteToolStripMenuItem.Text = "Subjekte";
            this.subjekteToolStripMenuItem.Click += new System.EventHandler(this.subjekteToolStripMenuItem_Click);
            // 
            // subjekteIInspektoreToolStripMenuItem
            // 
            this.subjekteIInspektoreToolStripMenuItem.Name = "subjekteIInspektoreToolStripMenuItem";
            this.subjekteIInspektoreToolStripMenuItem.Size = new System.Drawing.Size(222, 26);
            this.subjekteIInspektoreToolStripMenuItem.Text = "Subjekte i inspektore";
            this.subjekteIInspektoreToolStripMenuItem.Click += new System.EventHandler(this.subjekteIInspektoreToolStripMenuItem_Click);
            // 
            // bbToolStripMenuItem
            // 
            this.bbToolStripMenuItem.Name = "bbToolStripMenuItem";
            this.bbToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.bbToolStripMenuItem.Text = "Sačuvaj";
            this.bbToolStripMenuItem.Click += new System.EventHandler(this.sacuvaj_ToolStripMenuItem_Click);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // dayMI
            // 
            this.dayMI.CheckOnClick = true;
            this.dayMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ponedjeljakToolStripMenuItem,
            this.utorakToolStripMenuItem,
            this.srijedaToolStripMenuItem,
            this.četvrtakToolStripMenuItem,
            this.petakToolStripMenuItem,
            this.subotaToolStripMenuItem});
            this.dayMI.Name = "dayMI";
            this.dayMI.Size = new System.Drawing.Size(138, 24);
            this.dayMI.Text = "Dan - Ponedjeljak";
            // 
            // ponedjeljakToolStripMenuItem
            // 
            this.ponedjeljakToolStripMenuItem.Name = "ponedjeljakToolStripMenuItem";
            this.ponedjeljakToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.ponedjeljakToolStripMenuItem.Text = "Ponedjeljak";
            this.ponedjeljakToolStripMenuItem.Click += new System.EventHandler(this.ponedjeljakToolStripMenuItem_Click);
            // 
            // utorakToolStripMenuItem
            // 
            this.utorakToolStripMenuItem.Name = "utorakToolStripMenuItem";
            this.utorakToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.utorakToolStripMenuItem.Text = "Utorak";
            this.utorakToolStripMenuItem.Click += new System.EventHandler(this.utorakToolStripMenuItem_Click);
            // 
            // srijedaToolStripMenuItem
            // 
            this.srijedaToolStripMenuItem.Name = "srijedaToolStripMenuItem";
            this.srijedaToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.srijedaToolStripMenuItem.Text = "Srijeda";
            this.srijedaToolStripMenuItem.Click += new System.EventHandler(this.srijedaToolStripMenuItem_Click);
            // 
            // četvrtakToolStripMenuItem
            // 
            this.četvrtakToolStripMenuItem.Name = "četvrtakToolStripMenuItem";
            this.četvrtakToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.četvrtakToolStripMenuItem.Text = "Četvrtak";
            this.četvrtakToolStripMenuItem.Click += new System.EventHandler(this.četvrtakToolStripMenuItem_Click);
            // 
            // petakToolStripMenuItem
            // 
            this.petakToolStripMenuItem.Name = "petakToolStripMenuItem";
            this.petakToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.petakToolStripMenuItem.Text = "Petak";
            this.petakToolStripMenuItem.Click += new System.EventHandler(this.petakToolStripMenuItem_Click);
            // 
            // subotaToolStripMenuItem
            // 
            this.subotaToolStripMenuItem.Name = "subotaToolStripMenuItem";
            this.subotaToolStripMenuItem.Size = new System.Drawing.Size(160, 26);
            this.subotaToolStripMenuItem.Text = "Subota";
            this.subotaToolStripMenuItem.Click += new System.EventHandler(this.subotaToolStripMenuItem_Click);
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
            this.splitContainer1.Size = new System.Drawing.Size(1249, 436);
            this.splitContainer1.SplitterDistance = 313;
            this.splitContainer1.TabIndex = 1;
            // 
            // companiesGridView
            // 
            this.companiesGridView.AutoGenerateColumns = false;
            this.companiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.name,
            this.location,
            this.lastcontrolDataGridViewTextBoxColumn});
            this.companiesGridView.DataSource = this.companyBindingSource;
            this.companiesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.companiesGridView.Location = new System.Drawing.Point(0, 0);
            this.companiesGridView.Name = "companiesGridView";
            this.companiesGridView.RowHeadersWidth = 51;
            this.companiesGridView.RowTemplate.Height = 24;
            this.companiesGridView.Size = new System.Drawing.Size(313, 436);
            this.companiesGridView.TabIndex = 0;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Subjekt";
            this.name.Name = "name";
            // 
            // location
            // 
            this.location.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.location.DataPropertyName = "location";
            this.location.HeaderText = "Lokacija";
            this.location.Name = "location";
            // 
            // lastcontrolDataGridViewTextBoxColumn
            // 
            this.lastcontrolDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastcontrolDataGridViewTextBoxColumn.DataPropertyName = "last_control";
            this.lastcontrolDataGridViewTextBoxColumn.HeaderText = "Datum poslednje kontrole";
            this.lastcontrolDataGridViewTextBoxColumn.Name = "lastcontrolDataGridViewTextBoxColumn";
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
            this.controlsGridView.AllowUserToResizeColumns = false;
            this.controlsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.controlsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.company,
            this.address,
            this.inspector,
            this.vehicles_column,
            this.control_justified,
            this.is_finished});
            this.controlsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.controlsGridView.Location = new System.Drawing.Point(0, 0);
            this.controlsGridView.Name = "controlsGridView";
            this.controlsGridView.RowHeadersWidth = 51;
            this.controlsGridView.RowTemplate.Height = 24;
            this.controlsGridView.Size = new System.Drawing.Size(932, 436);
            this.controlsGridView.TabIndex = 0;
            this.controlsGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleGridView_CellValueChanged);
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
            // company
            // 
            this.company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.company.HeaderText = "Subjekt";
            this.company.MinimumWidth = 6;
            this.company.Name = "company";
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.HeaderText = "Adresa";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            // 
            // inspector
            // 
            this.inspector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inspector.HeaderText = "Inspektor";
            this.inspector.MinimumWidth = 6;
            this.inspector.Name = "inspector";
            this.inspector.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.inspector.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // vehicles_column
            // 
            this.vehicles_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vehicles_column.HeaderText = "Vozila";
            this.vehicles_column.MinimumWidth = 6;
            this.vehicles_column.Name = "vehicles_column";
            // 
            // control_justified
            // 
            this.control_justified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.control_justified.HeaderText = "Kontrola opravdana";
            this.control_justified.Name = "control_justified";
            // 
            // is_finished
            // 
            this.is_finished.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.is_finished.HeaderText = "Kontrola završena";
            this.is_finished.Name = "is_finished";
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1249, 464);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Plan";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
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
        private System.Windows.Forms.ToolStripMenuItem dayMI;
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
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ručnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem automatskiToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjekteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subjekteIInspektoreToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn location;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastcontrolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicles_column;
        private System.Windows.Forms.DataGridViewCheckBoxColumn control_justified;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_finished;
    }
}