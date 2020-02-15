namespace eInspektor.Views
{
    partial class NewControlsView
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
            this.potvrdiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.vehiclesGridView = new System.Windows.Forms.DataGridView();
            this.vehicle_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.registrationnum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.maxcapacity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicleBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSources = new eInspektor.DataSources();
            this.inspectorsGridView = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iscoordinatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordhashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.titleLabel = new System.Windows.Forms.Label();
            this.refreshButton = new System.Windows.Forms.Button();
            this.responsibilitiesGridView = new System.Windows.Forms.DataGridView();
            this.vehicleNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspectorResponsibilityColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.inspector_id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.vehicle_id_column = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateLabel = new System.Windows.Forms.Label();
            this.controlDatePicker = new System.Windows.Forms.DateTimePicker();
            this.regularControl = new System.Windows.Forms.CheckBox();
            this.inspectorTableAdapter = new eInspektor.DataSourcesTableAdapters.inspectorTableAdapter();
            this.vehicleTableAdapter = new eInspektor.DataSourcesTableAdapters.vehicleTableAdapter();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsibilitiesGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem,
            this.potvrdiToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(935, 28);
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
            // potvrdiToolStripMenuItem
            // 
            this.potvrdiToolStripMenuItem.Name = "potvrdiToolStripMenuItem";
            this.potvrdiToolStripMenuItem.Size = new System.Drawing.Size(67, 24);
            this.potvrdiToolStripMenuItem.Text = "Potvrdi";
            this.potvrdiToolStripMenuItem.Click += new System.EventHandler(this.potvrdiToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.vehiclesGridView);
            this.splitContainer1.Panel1.Controls.Add(this.inspectorsGridView);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.titleLabel);
            this.splitContainer1.Panel2.Controls.Add(this.refreshButton);
            this.splitContainer1.Panel2.Controls.Add(this.responsibilitiesGridView);
            this.splitContainer1.Panel2.Controls.Add(this.dateLabel);
            this.splitContainer1.Panel2.Controls.Add(this.controlDatePicker);
            this.splitContainer1.Panel2.Controls.Add(this.regularControl);
            this.splitContainer1.Size = new System.Drawing.Size(935, 422);
            this.splitContainer1.SplitterDistance = 402;
            this.splitContainer1.TabIndex = 1;
            // 
            // vehiclesGridView
            // 
            this.vehiclesGridView.AllowUserToAddRows = false;
            this.vehiclesGridView.AllowUserToDeleteRows = false;
            this.vehiclesGridView.AutoGenerateColumns = false;
            this.vehiclesGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.vehiclesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicle_id,
            this.nameData,
            this.registrationnum,
            this.maxcapacity,
            this.tag,
            this.isActive});
            this.vehiclesGridView.DataSource = this.vehicleBindingSource;
            this.vehiclesGridView.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.vehiclesGridView.Location = new System.Drawing.Point(0, 201);
            this.vehiclesGridView.Name = "vehiclesGridView";
            this.vehiclesGridView.ReadOnly = true;
            this.vehiclesGridView.RowHeadersWidth = 51;
            this.vehiclesGridView.RowTemplate.Height = 24;
            this.vehiclesGridView.Size = new System.Drawing.Size(402, 221);
            this.vehiclesGridView.TabIndex = 1;
            // 
            // vehicle_id
            // 
            this.vehicle_id.DataPropertyName = "id";
            this.vehicle_id.HeaderText = "id";
            this.vehicle_id.MinimumWidth = 6;
            this.vehicle_id.Name = "vehicle_id";
            this.vehicle_id.ReadOnly = true;
            this.vehicle_id.Visible = false;
            this.vehicle_id.Width = 125;
            // 
            // nameData
            // 
            this.nameData.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.nameData.DataPropertyName = "name";
            this.nameData.HeaderText = "Naziv";
            this.nameData.MinimumWidth = 6;
            this.nameData.Name = "nameData";
            this.nameData.ReadOnly = true;
            // 
            // registrationnum
            // 
            this.registrationnum.DataPropertyName = "registration_num";
            this.registrationnum.HeaderText = "registration_num";
            this.registrationnum.MinimumWidth = 6;
            this.registrationnum.Name = "registrationnum";
            this.registrationnum.ReadOnly = true;
            this.registrationnum.Visible = false;
            this.registrationnum.Width = 125;
            // 
            // maxcapacity
            // 
            this.maxcapacity.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.maxcapacity.DataPropertyName = "max_capacity";
            this.maxcapacity.HeaderText = "Broj mjesta";
            this.maxcapacity.MinimumWidth = 6;
            this.maxcapacity.Name = "maxcapacity";
            this.maxcapacity.ReadOnly = true;
            // 
            // tag
            // 
            this.tag.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.tag.DataPropertyName = "tag";
            this.tag.HeaderText = "Oznaka";
            this.tag.MinimumWidth = 6;
            this.tag.Name = "tag";
            this.tag.ReadOnly = true;
            // 
            // isActive
            // 
            this.isActive.DataPropertyName = "isActive";
            this.isActive.HeaderText = "isActive";
            this.isActive.MinimumWidth = 6;
            this.isActive.Name = "isActive";
            this.isActive.ReadOnly = true;
            this.isActive.Visible = false;
            this.isActive.Width = 125;
            // 
            // vehicleBindingSource
            // 
            this.vehicleBindingSource.DataMember = "vehicle";
            this.vehicleBindingSource.DataSource = this.dataSources;
            // 
            // dataSources
            // 
            this.dataSources.DataSetName = "DataSources";
            this.dataSources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inspectorsGridView
            // 
            this.inspectorsGridView.AllowUserToAddRows = false;
            this.inspectorsGridView.AllowUserToDeleteRows = false;
            this.inspectorsGridView.AutoGenerateColumns = false;
            this.inspectorsGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.inspectorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspectorsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.firstname,
            this.lastname,
            this.departmentDataGridViewTextBoxColumn,
            this.unavailableDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.iscoordinatorDataGridViewTextBoxColumn,
            this.username,
            this.saltDataGridViewTextBoxColumn,
            this.passwordhashDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.inspectorsGridView.DataSource = this.inspectorBindingSource;
            this.inspectorsGridView.Dock = System.Windows.Forms.DockStyle.Top;
            this.inspectorsGridView.Location = new System.Drawing.Point(0, 0);
            this.inspectorsGridView.Name = "inspectorsGridView";
            this.inspectorsGridView.ReadOnly = true;
            this.inspectorsGridView.RowHeadersWidth = 51;
            this.inspectorsGridView.RowTemplate.Height = 24;
            this.inspectorsGridView.Size = new System.Drawing.Size(402, 195);
            this.inspectorsGridView.TabIndex = 0;
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
            // firstname
            // 
            this.firstname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.firstname.DataPropertyName = "first_name";
            this.firstname.HeaderText = "Ime";
            this.firstname.MinimumWidth = 6;
            this.firstname.Name = "firstname";
            this.firstname.ReadOnly = true;
            // 
            // lastname
            // 
            this.lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastname.DataPropertyName = "last_name";
            this.lastname.HeaderText = "Prezime";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            this.lastname.ReadOnly = true;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "Odjeljenje";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // unavailableDataGridViewTextBoxColumn
            // 
            this.unavailableDataGridViewTextBoxColumn.DataPropertyName = "unavailable";
            this.unavailableDataGridViewTextBoxColumn.HeaderText = "unavailable";
            this.unavailableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unavailableDataGridViewTextBoxColumn.Name = "unavailableDataGridViewTextBoxColumn";
            this.unavailableDataGridViewTextBoxColumn.ReadOnly = true;
            this.unavailableDataGridViewTextBoxColumn.Visible = false;
            this.unavailableDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "Smjena";
            this.shiftDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // iscoordinatorDataGridViewTextBoxColumn
            // 
            this.iscoordinatorDataGridViewTextBoxColumn.DataPropertyName = "is_coordinator";
            this.iscoordinatorDataGridViewTextBoxColumn.HeaderText = "is_coordinator";
            this.iscoordinatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iscoordinatorDataGridViewTextBoxColumn.Name = "iscoordinatorDataGridViewTextBoxColumn";
            this.iscoordinatorDataGridViewTextBoxColumn.ReadOnly = true;
            this.iscoordinatorDataGridViewTextBoxColumn.Visible = false;
            this.iscoordinatorDataGridViewTextBoxColumn.Width = 125;
            // 
            // username
            // 
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "username";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            this.username.ReadOnly = true;
            this.username.Visible = false;
            this.username.Width = 125;
            // 
            // saltDataGridViewTextBoxColumn
            // 
            this.saltDataGridViewTextBoxColumn.DataPropertyName = "salt";
            this.saltDataGridViewTextBoxColumn.HeaderText = "salt";
            this.saltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saltDataGridViewTextBoxColumn.Name = "saltDataGridViewTextBoxColumn";
            this.saltDataGridViewTextBoxColumn.ReadOnly = true;
            this.saltDataGridViewTextBoxColumn.Visible = false;
            this.saltDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordhashDataGridViewTextBoxColumn
            // 
            this.passwordhashDataGridViewTextBoxColumn.DataPropertyName = "password_hash";
            this.passwordhashDataGridViewTextBoxColumn.HeaderText = "password_hash";
            this.passwordhashDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordhashDataGridViewTextBoxColumn.Name = "passwordhashDataGridViewTextBoxColumn";
            this.passwordhashDataGridViewTextBoxColumn.ReadOnly = true;
            this.passwordhashDataGridViewTextBoxColumn.Visible = false;
            this.passwordhashDataGridViewTextBoxColumn.Width = 125;
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
            // inspectorBindingSource
            // 
            this.inspectorBindingSource.DataMember = "inspector";
            this.inspectorBindingSource.DataSource = this.dataSources;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(249, 23);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(46, 17);
            this.titleLabel.TabIndex = 5;
            this.titleLabel.Text = "label1";
            // 
            // refreshButton
            // 
            this.refreshButton.Location = new System.Drawing.Point(303, 114);
            this.refreshButton.Name = "refreshButton";
            this.refreshButton.Size = new System.Drawing.Size(75, 23);
            this.refreshButton.TabIndex = 4;
            this.refreshButton.Text = "Osvježi";
            this.refreshButton.UseVisualStyleBackColor = true;
            this.refreshButton.Click += new System.EventHandler(this.refreshButton_Click);
            // 
            // responsibilitiesGridView
            // 
            this.responsibilitiesGridView.AllowUserToAddRows = false;
            this.responsibilitiesGridView.AllowUserToDeleteRows = false;
            this.responsibilitiesGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.responsibilitiesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.responsibilitiesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.vehicleNameColumn,
            this.inspectorResponsibilityColumn,
            this.inspector_id_column,
            this.vehicle_id_column});
            this.responsibilitiesGridView.Location = new System.Drawing.Point(73, 159);
            this.responsibilitiesGridView.Name = "responsibilitiesGridView";
            this.responsibilitiesGridView.RowHeadersWidth = 51;
            this.responsibilitiesGridView.RowTemplate.Height = 24;
            this.responsibilitiesGridView.Size = new System.Drawing.Size(444, 150);
            this.responsibilitiesGridView.TabIndex = 3;
            this.responsibilitiesGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.responsibilitiesGridView_CellValueChanged);
            // 
            // vehicleNameColumn
            // 
            this.vehicleNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.vehicleNameColumn.HeaderText = "Vozilo";
            this.vehicleNameColumn.MinimumWidth = 6;
            this.vehicleNameColumn.Name = "vehicleNameColumn";
            // 
            // inspectorResponsibilityColumn
            // 
            this.inspectorResponsibilityColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inspectorResponsibilityColumn.HeaderText = "Inspektor";
            this.inspectorResponsibilityColumn.MinimumWidth = 6;
            this.inspectorResponsibilityColumn.Name = "inspectorResponsibilityColumn";
            // 
            // inspector_id_column
            // 
            this.inspector_id_column.HeaderText = "insp id";
            this.inspector_id_column.MinimumWidth = 6;
            this.inspector_id_column.Name = "inspector_id_column";
            this.inspector_id_column.Visible = false;
            this.inspector_id_column.Width = 125;
            // 
            // vehicle_id_column
            // 
            this.vehicle_id_column.HeaderText = "Column1";
            this.vehicle_id_column.MinimumWidth = 6;
            this.vehicle_id_column.Name = "vehicle_id_column";
            this.vehicle_id_column.Visible = false;
            this.vehicle_id_column.Width = 125;
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(89, 66);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(108, 17);
            this.dateLabel.TabIndex = 2;
            this.dateLabel.Text = "Datum kontrole:";
            // 
            // controlDatePicker
            // 
            this.controlDatePicker.Location = new System.Drawing.Point(222, 61);
            this.controlDatePicker.Name = "controlDatePicker";
            this.controlDatePicker.Size = new System.Drawing.Size(200, 22);
            this.controlDatePicker.TabIndex = 1;
            this.controlDatePicker.Value = new System.DateTime(2020, 2, 9, 20, 42, 40, 0);
            // 
            // regularControl
            // 
            this.regularControl.AutoSize = true;
            this.regularControl.Checked = true;
            this.regularControl.CheckState = System.Windows.Forms.CheckState.Checked;
            this.regularControl.Location = new System.Drawing.Point(73, 114);
            this.regularControl.Name = "regularControl";
            this.regularControl.Size = new System.Drawing.Size(142, 21);
            this.regularControl.TabIndex = 0;
            this.regularControl.Text = "Redovna kontrola";
            this.regularControl.UseVisualStyleBackColor = true;
            // 
            // inspectorTableAdapter
            // 
            this.inspectorTableAdapter.ClearBeforeFill = true;
            // 
            // vehicleTableAdapter
            // 
            this.vehicleTableAdapter.ClearBeforeFill = true;
            // 
            // NewControlsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(935, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "NewControlsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "NewControlsView";
            this.Load += new System.EventHandler(this.NewControlsView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsibilitiesGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem potvrdiToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView vehiclesGridView;
        private System.Windows.Forms.DataGridView inspectorsGridView;
        private DataSources dataSources;
        private System.Windows.Forms.BindingSource inspectorBindingSource;
        private DataSourcesTableAdapters.inspectorTableAdapter inspectorTableAdapter;
        private System.Windows.Forms.BindingSource vehicleBindingSource;
        private DataSourcesTableAdapters.vehicleTableAdapter vehicleTableAdapter;
        private System.Windows.Forms.CheckBox regularControl;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.DateTimePicker controlDatePicker;
        private System.Windows.Forms.DataGridView responsibilitiesGridView;
        private System.Windows.Forms.Button refreshButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicle_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameData;
        private System.Windows.Forms.DataGridViewTextBoxColumn registrationnum;
        private System.Windows.Forms.DataGridViewTextBoxColumn maxcapacity;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstname;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unavailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iscoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewTextBoxColumn saltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordhashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicleNameColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn inspectorResponsibilityColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspector_id_column;
        private System.Windows.Forms.DataGridViewTextBoxColumn vehicle_id_column;
    }
}