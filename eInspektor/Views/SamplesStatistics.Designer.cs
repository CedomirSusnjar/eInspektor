namespace eInspektor.Views
{
    partial class SamplesStatistics
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
            this.samplesGV = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.nazadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.brišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTB1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.companyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labsampleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSources = new eInspektor.DataSources();
            this.lab_sampleTableAdapter = new eInspektor.DataSourcesTableAdapters.lab_sampleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.samplesGV)).BeginInit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labsampleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).BeginInit();
            this.SuspendLayout();
            // 
            // samplesGV
            // 
            this.samplesGV.AllowUserToAddRows = false;
            this.samplesGV.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.samplesGV.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.samplesGV.AutoGenerateColumns = false;
            this.samplesGV.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.samplesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.samplesGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.companyColumn,
            this.inspectorColumn,
            this.date,
            this.description,
            this.idColumn,
            this.companyid,
            this.inspectorid,
            this.isActiveDataGridViewTextBoxColumn});
            this.samplesGV.DataSource = this.labsampleBindingSource;
            this.samplesGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samplesGV.Location = new System.Drawing.Point(0, 30);
            this.samplesGV.Name = "samplesGV";
            this.samplesGV.ReadOnly = true;
            this.samplesGV.RowHeadersWidth = 51;
            this.samplesGV.RowTemplate.Height = 24;
            this.samplesGV.Size = new System.Drawing.Size(922, 420);
            this.samplesGV.TabIndex = 0;
            this.samplesGV.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.samplesGV_CellValueChanged);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem,
            this.dodajToolStripMenuItem,
            this.brišiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(922, 30);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // nazadToolStripMenuItem
            // 
            this.nazadToolStripMenuItem.Name = "nazadToolStripMenuItem";
            this.nazadToolStripMenuItem.Size = new System.Drawing.Size(73, 26);
            this.nazadToolStripMenuItem.Text = "Sačuvaj";
            this.nazadToolStripMenuItem.Click += new System.EventHandler(this.sacuvajToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(64, 26);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // brišiToolStripMenuItem
            // 
            this.brišiToolStripMenuItem.Name = "brišiToolStripMenuItem";
            this.brišiToolStripMenuItem.Size = new System.Drawing.Size(51, 26);
            this.brišiToolStripMenuItem.Text = "Briši";
            this.brišiToolStripMenuItem.Click += new System.EventHandler(this.brišiToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(565, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pretraži po subjektu:";
            // 
            // searchTB1
            // 
            this.searchTB1.Location = new System.Drawing.Point(709, 1);
            this.searchTB1.Name = "searchTB1";
            this.searchTB1.Size = new System.Drawing.Size(112, 22);
            this.searchTB1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(827, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pretraži";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // companyColumn
            // 
            this.companyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyColumn.HeaderText = "Subjekt";
            this.companyColumn.MinimumWidth = 6;
            this.companyColumn.Name = "companyColumn";
            this.companyColumn.ReadOnly = true;
            // 
            // inspectorColumn
            // 
            this.inspectorColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inspectorColumn.HeaderText = "Inspektor";
            this.inspectorColumn.MinimumWidth = 6;
            this.inspectorColumn.Name = "inspectorColumn";
            this.inspectorColumn.ReadOnly = true;
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "Datum preuzimanja";
            this.date.MinimumWidth = 6;
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.DataPropertyName = "description";
            this.description.HeaderText = "Opis";
            this.description.MinimumWidth = 6;
            this.description.Name = "description";
            this.description.ReadOnly = true;
            // 
            // idColumn
            // 
            this.idColumn.DataPropertyName = "id";
            this.idColumn.HeaderText = "id";
            this.idColumn.MinimumWidth = 6;
            this.idColumn.Name = "idColumn";
            this.idColumn.ReadOnly = true;
            this.idColumn.Visible = false;
            this.idColumn.Width = 125;
            // 
            // companyid
            // 
            this.companyid.DataPropertyName = "company_id";
            this.companyid.HeaderText = "company_id";
            this.companyid.MinimumWidth = 6;
            this.companyid.Name = "companyid";
            this.companyid.ReadOnly = true;
            this.companyid.Visible = false;
            this.companyid.Width = 125;
            // 
            // inspectorid
            // 
            this.inspectorid.DataPropertyName = "inspector_id";
            this.inspectorid.HeaderText = "inspector_id";
            this.inspectorid.MinimumWidth = 6;
            this.inspectorid.Name = "inspectorid";
            this.inspectorid.ReadOnly = true;
            this.inspectorid.Visible = false;
            this.inspectorid.Width = 125;
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
            // labsampleBindingSource
            // 
            this.labsampleBindingSource.DataMember = "lab_sample";
            this.labsampleBindingSource.DataSource = this.dataSources;
            // 
            // dataSources
            // 
            this.dataSources.DataSetName = "DataSources";
            this.dataSources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lab_sampleTableAdapter
            // 
            this.lab_sampleTableAdapter.ClearBeforeFill = true;
            // 
            // SamplesStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(922, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchTB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.samplesGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SamplesStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uzorci";
            this.Load += new System.EventHandler(this.SamplesStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.samplesGV)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.labsampleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView samplesGV;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTB1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem brišiToolStripMenuItem;
        private DataSources dataSources;
        private System.Windows.Forms.BindingSource labsampleBindingSource;
        private DataSourcesTableAdapters.lab_sampleTableAdapter lab_sampleTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.DataGridViewTextBoxColumn idColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyid;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspectorid;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
    }
}