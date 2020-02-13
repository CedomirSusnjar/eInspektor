namespace eInspektor
{
    partial class Subjects
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
            this.nazadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sačuvajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ukloniToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jib = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.owner = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLastCtrl = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookkeeper = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.last_control_type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSources1 = new eInspektor.DataSources();
            this.companyBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter1 = new eInspektor.DataSourcesTableAdapters.companyTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem,
            this.sačuvajToolStripMenuItem,
            this.ukloniToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(953, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nazadToolStripMenuItem
            // 
            this.nazadToolStripMenuItem.Name = "nazadToolStripMenuItem";
            this.nazadToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.nazadToolStripMenuItem.Text = "Nazad";
            this.nazadToolStripMenuItem.Click += new System.EventHandler(this.nazadToolStripMenuItem_Click);
            // 
            // sačuvajToolStripMenuItem
            // 
            this.sačuvajToolStripMenuItem.Name = "sačuvajToolStripMenuItem";
            this.sačuvajToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.sačuvajToolStripMenuItem.Text = "Sačuvaj";
            this.sačuvajToolStripMenuItem.Click += new System.EventHandler(this.sačuvajToolStripMenuItem_Click);
            // 
            // ukloniToolStripMenuItem
            // 
            this.ukloniToolStripMenuItem.Name = "ukloniToolStripMenuItem";
            this.ukloniToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.ukloniToolStripMenuItem.Text = "Obriši";
            this.ukloniToolStripMenuItem.Click += new System.EventHandler(this.ukloniToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.address,
            this.jib,
            this.owner,
            this.dateLastCtrl,
            this.bookkeeper,
            this.last_control_type,
            this.is_active});
            this.dataGridView1.DataSource = this.companyBindingSource;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(953, 422);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Visible = false;
            this.id.Width = 125;
            // 
            // name
            // 
            this.name.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "Naziv";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // address
            // 
            this.address.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.address.DataPropertyName = "location";
            this.address.HeaderText = "Adresa";
            this.address.MinimumWidth = 6;
            this.address.Name = "address";
            // 
            // jib
            // 
            this.jib.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.jib.DataPropertyName = "jib";
            this.jib.HeaderText = "JIB";
            this.jib.MinimumWidth = 6;
            this.jib.Name = "jib";
            // 
            // owner
            // 
            this.owner.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.owner.DataPropertyName = "owner";
            this.owner.HeaderText = "Vlasnik";
            this.owner.MinimumWidth = 6;
            this.owner.Name = "owner";
            // 
            // dateLastCtrl
            // 
            this.dateLastCtrl.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dateLastCtrl.DataPropertyName = "last_control";
            this.dateLastCtrl.HeaderText = "Datum poslednje kontrole";
            this.dateLastCtrl.MinimumWidth = 6;
            this.dateLastCtrl.Name = "dateLastCtrl";
            // 
            // bookkeeper
            // 
            this.bookkeeper.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.bookkeeper.DataPropertyName = "bookkeeper";
            this.bookkeeper.HeaderText = "Knjigovođa";
            this.bookkeeper.MinimumWidth = 6;
            this.bookkeeper.Name = "bookkeeper";
            // 
            // last_control_type
            // 
            this.last_control_type.DataPropertyName = "last_control_type";
            this.last_control_type.HeaderText = "last_control_type";
            this.last_control_type.MinimumWidth = 6;
            this.last_control_type.Name = "last_control_type";
            this.last_control_type.Visible = false;
            this.last_control_type.Width = 125;
            // 
            // is_active
            // 
            this.is_active.DataPropertyName = "isActive";
            this.is_active.HeaderText = "isActive";
            this.is_active.MinimumWidth = 6;
            this.is_active.Name = "is_active";
            this.is_active.Visible = false;
            this.is_active.Width = 125;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.dataSources1;
            // 
            // dataSources1
            // 
            this.dataSources1.DataSetName = "DataSources";
            this.dataSources1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // companyBindingSource1
            // 
            this.companyBindingSource1.DataMember = "company";
            // 
            // companyTableAdapter1
            // 
            this.companyTableAdapter1.ClearBeforeFill = true;
            // 
            // Subjects
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Subjects";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Subjekti";
            this.Load += new System.EventHandler(this.Subjects_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource companyBindingSource1;
        private DataSources dataSources1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DataSourcesTableAdapters.companyTableAdapter companyTableAdapter1;
        private System.Windows.Forms.ToolStripMenuItem sačuvajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ukloniToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn address;
        private System.Windows.Forms.DataGridViewTextBoxColumn jib;
        private System.Windows.Forms.DataGridViewTextBoxColumn owner;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateLastCtrl;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookkeeper;
        private System.Windows.Forms.DataGridViewTextBoxColumn last_control_type;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_active;
    }
}