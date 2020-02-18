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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nazadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sačuvajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reclamationGV = new System.Windows.Forms.DataGridView();
            this.complaintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSources1 = new eInspektor.DataSources();
            this.complaintTableAdapter1 = new eInspektor.DataSourcesTableAdapters.complaintTableAdapter();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new eInspektor.DataSourcesTableAdapters.companyTableAdapter();
            this.resolvedRec = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.justifiedRec = new System.Windows.Forms.TextBox();
            this.kontrolaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.complaintBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_name_column = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.text = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_justified = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.is_resolved = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.control_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reclamationGV)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem,
            this.sačuvajToolStripMenuItem,
            this.obrišiToolStripMenuItem,
            this.kontrolaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(950, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nazadToolStripMenuItem
            // 
            this.nazadToolStripMenuItem.Name = "nazadToolStripMenuItem";
            this.nazadToolStripMenuItem.Size = new System.Drawing.Size(66, 26);
            this.nazadToolStripMenuItem.Text = "Nazad";
            this.nazadToolStripMenuItem.Click += new System.EventHandler(this.nazadToolStripMenuItem_Click);
            // 
            // sačuvajToolStripMenuItem
            // 
            this.sačuvajToolStripMenuItem.Name = "sačuvajToolStripMenuItem";
            this.sačuvajToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.sačuvajToolStripMenuItem.Text = "Sačuvaj";
            this.sačuvajToolStripMenuItem.Click += new System.EventHandler(this.sačuvajToolStripMenuItem_Click);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(62, 26);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // reclamationGV
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reclamationGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reclamationGV.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reclamationGV.AutoGenerateColumns = false;
            this.reclamationGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.reclamationGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reclamationGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.company_id,
            this.company_name_column,
            this.text,
            this.issuer,
            this.date,
            this.is_justified,
            this.is_resolved,
            this.control_id,
            this.is_active});
            this.reclamationGV.DataSource = this.complaintBindingSource;
            this.reclamationGV.Location = new System.Drawing.Point(0, 31);
            this.reclamationGV.Name = "reclamationGV";
            this.reclamationGV.RowHeadersWidth = 51;
            this.reclamationGV.RowTemplate.Height = 24;
            this.reclamationGV.Size = new System.Drawing.Size(950, 433);
            this.reclamationGV.TabIndex = 1;
            this.reclamationGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellValueChanged);
            this.reclamationGV.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
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
            // resolvedRec
            // 
            this.resolvedRec.Location = new System.Drawing.Point(610, 6);
            this.resolvedRec.Name = "resolvedRec";
            this.resolvedRec.Size = new System.Drawing.Size(75, 22);
            this.resolvedRec.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(453, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Riješenih reklamacija:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(691, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(166, 18);
            this.label2.TabIndex = 4;
            this.label2.Text = "Opravdanih reklamacija:";
            // 
            // justifiedRec
            // 
            this.justifiedRec.Location = new System.Drawing.Point(863, 3);
            this.justifiedRec.Name = "justifiedRec";
            this.justifiedRec.Size = new System.Drawing.Size(75, 22);
            this.justifiedRec.TabIndex = 5;
            // 
            // kontrolaToolStripMenuItem
            // 
            this.kontrolaToolStripMenuItem.Name = "kontrolaToolStripMenuItem";
            this.kontrolaToolStripMenuItem.Size = new System.Drawing.Size(89, 26);
            this.kontrolaToolStripMenuItem.Text = "Kontrola...";
            this.kontrolaToolStripMenuItem.Click += new System.EventHandler(this.kontrolaToolStripMenuItem_Click);
            // 
            // complaintBindingSource1
            // 
            this.complaintBindingSource1.DataMember = "complaint";
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
            this.company_id.Visible = false;
            this.company_id.Width = 125;
            // 
            // company_name_column
            // 
            this.company_name_column.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.company_name_column.HeaderText = "Subjekt";
            this.company_name_column.MinimumWidth = 6;
            this.company_name_column.Name = "company_name_column";
            // 
            // text
            // 
            this.text.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.text.DataPropertyName = "text";
            this.text.HeaderText = "Sadržaj";
            this.text.MinimumWidth = 6;
            this.text.Name = "text";
            // 
            // issuer
            // 
            this.issuer.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.issuer.DataPropertyName = "issuer";
            this.issuer.HeaderText = "Podnosilac";
            this.issuer.MinimumWidth = 6;
            this.issuer.Name = "issuer";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Datum";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            // 
            // is_justified
            // 
            this.is_justified.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.is_justified.DataPropertyName = "is_justified";
            this.is_justified.HeaderText = "Opravdana";
            this.is_justified.MinimumWidth = 6;
            this.is_justified.Name = "is_justified";
            this.is_justified.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_justified.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // is_resolved
            // 
            this.is_resolved.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.is_resolved.DataPropertyName = "is_resolved";
            this.is_resolved.HeaderText = "Riješena";
            this.is_resolved.MinimumWidth = 6;
            this.is_resolved.Name = "is_resolved";
            this.is_resolved.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.is_resolved.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
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
            // is_active
            // 
            this.is_active.DataPropertyName = "isActive";
            this.is_active.HeaderText = "isActive";
            this.is_active.MinimumWidth = 6;
            this.is_active.Name = "is_active";
            this.is_active.Visible = false;
            this.is_active.Width = 125;
            // 
            // Reclamation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 467);
            this.Controls.Add(this.justifiedRec);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resolvedRec);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.reclamationGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reclamation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reklamacije";
            this.Load += new System.EventHandler(this.Reclamation_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reclamationGV)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sačuvajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
        private System.Windows.Forms.DataGridView reclamationGV;
        private System.Windows.Forms.BindingSource complaintBindingSource1;
        private DataSources dataSources1;
        private System.Windows.Forms.BindingSource complaintBindingSource;
        private DataSourcesTableAdapters.complaintTableAdapter complaintTableAdapter1;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DataSourcesTableAdapters.companyTableAdapter companyTableAdapter;
        private System.Windows.Forms.TextBox resolvedRec;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox justifiedRec;
        private System.Windows.Forms.ToolStripMenuItem kontrolaToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_id;
        private System.Windows.Forms.DataGridViewComboBoxColumn company_name_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn text;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuer;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_justified;
        private System.Windows.Forms.DataGridViewCheckBoxColumn is_resolved;
        private System.Windows.Forms.DataGridViewTextBoxColumn control_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_active;
    }
}