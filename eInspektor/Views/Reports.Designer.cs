﻿namespace eInspektor
{
    partial class Reports
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
            this.detaljiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statistikaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kontroleSaDrugimOdjelimaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.uzorciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchLabel = new System.Windows.Forms.Label();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.reportsGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.company_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.startdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.finishdateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isfinishedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isregularDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.controljustifiedDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.report_content = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSources = new eInspektor.DataSources();
            this.controlTableAdapter = new eInspektor.DataSourcesTableAdapters.controlTableAdapter();
            this._is_projDataSet1 = new eInspektor._is_projDataSet();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._is_projDataSet1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem,
            this.detaljiToolStripMenuItem,
            this.statistikaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1077, 28);
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
            // detaljiToolStripMenuItem
            // 
            this.detaljiToolStripMenuItem.Name = "detaljiToolStripMenuItem";
            this.detaljiToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.detaljiToolStripMenuItem.Text = "Izvjestaj";
            this.detaljiToolStripMenuItem.Click += new System.EventHandler(this.detaljiToolStripMenuItem_Click);
            // 
            // statistikaToolStripMenuItem
            // 
            this.statistikaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.kontroleSaDrugimOdjelimaToolStripMenuItem,
            this.uzorciToolStripMenuItem});
            this.statistikaToolStripMenuItem.Name = "statistikaToolStripMenuItem";
            this.statistikaToolStripMenuItem.Size = new System.Drawing.Size(66, 24);
            this.statistikaToolStripMenuItem.Text = "Ostalo";
            this.statistikaToolStripMenuItem.Click += new System.EventHandler(this.statistikaToolStripMenuItem_Click);
            // 
            // kontroleSaDrugimOdjelimaToolStripMenuItem
            // 
            this.kontroleSaDrugimOdjelimaToolStripMenuItem.Name = "kontroleSaDrugimOdjelimaToolStripMenuItem";
            this.kontroleSaDrugimOdjelimaToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.kontroleSaDrugimOdjelimaToolStripMenuItem.Text = "Zajedničke kontrole";
            this.kontroleSaDrugimOdjelimaToolStripMenuItem.Click += new System.EventHandler(this.kontroleSaDrugimOdjelimaToolStripMenuItem_Click);
            // 
            // uzorciToolStripMenuItem
            // 
            this.uzorciToolStripMenuItem.Name = "uzorciToolStripMenuItem";
            this.uzorciToolStripMenuItem.Size = new System.Drawing.Size(223, 26);
            this.uzorciToolStripMenuItem.Text = "Uzorci";
            this.uzorciToolStripMenuItem.Click += new System.EventHandler(this.uzorciToolStripMenuItem_Click);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchLabel.Location = new System.Drawing.Point(449, 5);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(165, 18);
            this.searchLabel.TabIndex = 1;
            this.searchLabel.Text = "Pretraži po imenu firme:";
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(654, 4);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(233, 22);
            this.searchTextBox.TabIndex = 2;
            // 
            // searchButton
            // 
            this.searchButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.searchButton.Location = new System.Drawing.Point(893, 4);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(75, 23);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Pretraži";
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // reportsGridView
            // 
            this.reportsGridView.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.reportsGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.reportsGridView.AutoGenerateColumns = false;
            this.reportsGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.reportsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.companyColumn,
            this.company_id,
            this.startdateDataGridViewTextBoxColumn,
            this.finishdateDataGridViewTextBoxColumn,
            this.isfinishedDataGridViewTextBoxColumn,
            this.isregularDataGridViewCheckBoxColumn,
            this.controljustifiedDataGridViewCheckBoxColumn,
            this.report_content,
            this.isActiveDataGridViewTextBoxColumn});
            this.reportsGridView.DataSource = this.controlBindingSource;
            this.reportsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportsGridView.Location = new System.Drawing.Point(0, 28);
            this.reportsGridView.Name = "reportsGridView";
            this.reportsGridView.ReadOnly = true;
            this.reportsGridView.RowHeadersWidth = 51;
            this.reportsGridView.RowTemplate.Height = 24;
            this.reportsGridView.Size = new System.Drawing.Size(1077, 422);
            this.reportsGridView.TabIndex = 4;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Visible = false;
            this.id.Width = 150;
            // 
            // companyColumn
            // 
            this.companyColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.companyColumn.HeaderText = "Firma";
            this.companyColumn.MinimumWidth = 6;
            this.companyColumn.Name = "companyColumn";
            this.companyColumn.ReadOnly = true;
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
            this.startdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.startdateDataGridViewTextBoxColumn.DataPropertyName = "start_date";
            this.startdateDataGridViewTextBoxColumn.HeaderText = "Datum početka";
            this.startdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.startdateDataGridViewTextBoxColumn.Name = "startdateDataGridViewTextBoxColumn";
            this.startdateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // finishdateDataGridViewTextBoxColumn
            // 
            this.finishdateDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.finishdateDataGridViewTextBoxColumn.DataPropertyName = "finish_date";
            this.finishdateDataGridViewTextBoxColumn.HeaderText = "Datum kraja";
            this.finishdateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.finishdateDataGridViewTextBoxColumn.Name = "finishdateDataGridViewTextBoxColumn";
            this.finishdateDataGridViewTextBoxColumn.ReadOnly = true;
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
            // isregularDataGridViewCheckBoxColumn
            // 
            this.isregularDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.isregularDataGridViewCheckBoxColumn.DataPropertyName = "is_regular";
            this.isregularDataGridViewCheckBoxColumn.HeaderText = "Redovna";
            this.isregularDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.isregularDataGridViewCheckBoxColumn.Name = "isregularDataGridViewCheckBoxColumn";
            this.isregularDataGridViewCheckBoxColumn.ReadOnly = true;
            this.isregularDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.isregularDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // controljustifiedDataGridViewCheckBoxColumn
            // 
            this.controljustifiedDataGridViewCheckBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.controljustifiedDataGridViewCheckBoxColumn.DataPropertyName = "control_justified";
            this.controljustifiedDataGridViewCheckBoxColumn.HeaderText = "Opravdana";
            this.controljustifiedDataGridViewCheckBoxColumn.MinimumWidth = 6;
            this.controljustifiedDataGridViewCheckBoxColumn.Name = "controljustifiedDataGridViewCheckBoxColumn";
            this.controljustifiedDataGridViewCheckBoxColumn.ReadOnly = true;
            this.controljustifiedDataGridViewCheckBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.controljustifiedDataGridViewCheckBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // report_content
            // 
            this.report_content.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.report_content.DataPropertyName = "report_content";
            this.report_content.HeaderText = "Sadržaj";
            this.report_content.MinimumWidth = 6;
            this.report_content.Name = "report_content";
            this.report_content.ReadOnly = true;
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
            // dataSources
            // 
            this.dataSources.DataSetName = "DataSources";
            this.dataSources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // controlTableAdapter
            // 
            this.controlTableAdapter.ClearBeforeFill = true;
            // 
            // _is_projDataSet1
            // 
            this._is_projDataSet1.DataSetName = "_is_projDataSet";
            this._is_projDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Reports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1077, 450);
            this.Controls.Add(this.reportsGridView);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Reports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Izvještaji";
            this.Load += new System.EventHandler(this.Reports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.controlBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._is_projDataSet1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statistikaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem detaljiToolStripMenuItem;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.DataGridView reportsGridView;
        private DataSources dataSources;
        private System.Windows.Forms.BindingSource controlBindingSource;
        private DataSourcesTableAdapters.controlTableAdapter controlTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn company_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn startdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn finishdateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isfinishedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn isregularDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn controljustifiedDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn report_content;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.ToolStripMenuItem kontroleSaDrugimOdjelimaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem uzorciToolStripMenuItem;
        private _is_projDataSet _is_projDataSet1;
    }
}