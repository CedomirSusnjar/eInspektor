namespace eInspektor
{
    partial class Reclamation
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
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.complaintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSources1 = new eInspektor.DataSources();
            this.complaintBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.complaintTableAdapter1 = new eInspektor.DataSourcesTableAdapters.complaintTableAdapter();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new eInspektor.DataSourcesTableAdapters.companyTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_justified = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.control_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_resolved = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_name_column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem,
            this.sačuvajToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.obrišiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(930, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nazadToolStripMenuItem
            // 
            this.nazadToolStripMenuItem.Name = "nazadToolStripMenuItem";
            this.nazadToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.nazadToolStripMenuItem.Text = "Nazad";
            this.nazadToolStripMenuItem.Click += new System.EventHandler(this.nazadToolStripMenuItem_Click);
            // 
            // sačuvajToolStripMenuItem
            // 
            this.sačuvajToolStripMenuItem.Name = "sačuvajToolStripMenuItem";
            this.sačuvajToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sačuvajToolStripMenuItem.Text = "Sačuvaj";
            this.sačuvajToolStripMenuItem.Click += new System.EventHandler(this.sačuvajToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.company_id,
            this.text,
            this.issuer,
            this.is_justified,
            this.date,
            this.control_id,
            this.is_resolved,
            this.is_active,
            this.company_name_column});
            this.dataGridView1.DataSource = this.complaintBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(930, 416);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // complaintBindingSource
            // 
            this.complaintBindingSource.DataMember = "complaint";
            this.complaintBindingSource.DataSource = this.dataSources1;
            // 
            // dataSources1
            // 
            this.dataSources1.DataSetName = "DataSources";
            this.dataSources1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // complaintBindingSource1
            // 
            this.complaintBindingSource1.DataMember = "complaint";
            // 
            // complaintTableAdapter1
            // 
            this.complaintTableAdapter1.ClearBeforeFill = true;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.dataSources1;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
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
            // company_id
            // 
            this.company_id.DataPropertyName = "company_id";
            this.company_id.HeaderText = "company_id";
            this.company_id.MinimumWidth = 6;
            this.company_id.Name = "company_id";
            this.company_id.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.company_id.Width = 125;
            // 
            // text
            // 
            this.text.DataPropertyName = "text";
            this.text.HeaderText = "Sadržaj";
            this.text.MinimumWidth = 6;
            this.text.Name = "text";
            this.text.Width = 125;
            // 
            // issuer
            // 
            this.issuer.DataPropertyName = "issuer";
            this.issuer.HeaderText = "Podnosilac";
            this.issuer.MinimumWidth = 6;
            this.issuer.Name = "issuer";
            this.issuer.Width = 125;
            // 
            // is_justified
            // 
            this.is_justified.DataPropertyName = "is_justified";
            this.is_justified.HeaderText = "Opravdana";
            this.is_justified.MinimumWidth = 6;
            this.is_justified.Name = "is_justified";
            this.is_justified.Width = 125;
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Datum";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.Width = 125;
            // 
            // control_id
            // 
            this.control_id.DataPropertyName = "control_id";
            this.control_id.HeaderText = "control_id";
            this.control_id.MinimumWidth = 6;
            this.control_id.Name = "control_id";
            this.control_id.Visible = false;
            this.control_id.Width = 125;
            // 
            // is_resolved
            // 
            this.is_resolved.DataPropertyName = "is_resolved";
            this.is_resolved.HeaderText = "Riješena";
            this.is_resolved.MinimumWidth = 6;
            this.is_resolved.Name = "is_resolved";
            this.is_resolved.Width = 125;
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
            // company_name_column
            // 
            this.company_name_column.HeaderText = "Ime firme";
            this.company_name_column.MinimumWidth = 6;
            this.company_name_column.Name = "company_name_column";
            this.company_name_column.Width = 125;
            // 
            // Reclamation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(930, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reclamation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reklamacije";
            this.Load += new System.EventHandler(this.Reclamation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sačuvajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.BindingSource complaintBindingSource1;
        private DataSources dataSources1;
        private System.Windows.Forms.BindingSource complaintBindingSource;
        private DataSourcesTableAdapters.complaintTableAdapter complaintTableAdapter1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DataSourcesTableAdapters.companyTableAdapter companyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuer;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_justified;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn control_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_resolved;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_active;
        private System.Windows.Forms.DataGridViewComboBoxColumn company_name_column;
    }
}