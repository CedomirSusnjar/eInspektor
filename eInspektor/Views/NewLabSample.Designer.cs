namespace eInspektor.Views
{
    partial class NewLabSample
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
            this.lblDate = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.inspectorsGridView = new System.Windows.Forms.DataGridView();
            this.companiesGridVew = new System.Windows.Forms.DataGridView();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.dataSources = new eInspektor.DataSources();
            this.inspectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectorTableAdapter = new eInspektor.DataSourcesTableAdapters.inspectorTableAdapter();
            this.companyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.companyTableAdapter = new eInspektor.DataSourcesTableAdapters.companyTableAdapter();
            this.idInspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iscoordinatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.idCompany = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.jibDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.locationDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ownerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookkeeperDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastcontrolDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastcontroltypeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesGridVew)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.Location = new System.Drawing.Point(490, 29);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(57, 17);
            this.lblDate.TabIndex = 0;
            this.lblDate.Text = "Datum: ";
            // 
            // lblDescription
            // 
            this.lblDescription.AutoSize = true;
            this.lblDescription.Location = new System.Drawing.Point(490, 56);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(41, 17);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Opis:";
            // 
            // inspectorsGridView
            // 
            this.inspectorsGridView.AllowUserToAddRows = false;
            this.inspectorsGridView.AllowUserToDeleteRows = false;
            this.inspectorsGridView.AutoGenerateColumns = false;
            this.inspectorsGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.inspectorsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.inspectorsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idInspector,
            this.firstnameDataGridViewTextBoxColumn,
            this.lastnameDataGridViewTextBoxColumn,
            this.departmentDataGridViewTextBoxColumn,
            this.unavailableDataGridViewTextBoxColumn,
            this.shiftDataGridViewTextBoxColumn,
            this.iscoordinatorDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.inspectorsGridView.DataSource = this.inspectorBindingSource;
            this.inspectorsGridView.Location = new System.Drawing.Point(12, 12);
            this.inspectorsGridView.Name = "inspectorsGridView";
            this.inspectorsGridView.ReadOnly = true;
            this.inspectorsGridView.RowHeadersWidth = 51;
            this.inspectorsGridView.RowTemplate.Height = 24;
            this.inspectorsGridView.Size = new System.Drawing.Size(223, 426);
            this.inspectorsGridView.TabIndex = 3;
            // 
            // companiesGridVew
            // 
            this.companiesGridVew.AllowUserToAddRows = false;
            this.companiesGridVew.AllowUserToDeleteRows = false;
            this.companiesGridVew.AutoGenerateColumns = false;
            this.companiesGridVew.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.companiesGridVew.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.companiesGridVew.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idCompany,
            this.jibDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.locationDataGridViewTextBoxColumn,
            this.ownerDataGridViewTextBoxColumn,
            this.bookkeeperDataGridViewTextBoxColumn,
            this.lastcontrolDataGridViewTextBoxColumn,
            this.lastcontroltypeDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn1});
            this.companiesGridVew.DataSource = this.companyBindingSource;
            this.companiesGridVew.Location = new System.Drawing.Point(254, 12);
            this.companiesGridVew.Name = "companiesGridVew";
            this.companiesGridVew.ReadOnly = true;
            this.companiesGridVew.RowHeadersWidth = 51;
            this.companiesGridVew.RowTemplate.Height = 24;
            this.companiesGridVew.Size = new System.Drawing.Size(209, 426);
            this.companiesGridVew.TabIndex = 4;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(568, 24);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(568, 61);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(199, 204);
            this.textBox1.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(568, 287);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(100, 31);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Potvrdi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // dataSources
            // 
            this.dataSources.DataSetName = "DataSources";
            this.dataSources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // inspectorBindingSource
            // 
            this.inspectorBindingSource.DataMember = "inspector";
            this.inspectorBindingSource.DataSource = this.dataSources;
            // 
            // inspectorTableAdapter
            // 
            this.inspectorTableAdapter.ClearBeforeFill = true;
            // 
            // companyBindingSource
            // 
            this.companyBindingSource.DataMember = "company";
            this.companyBindingSource.DataSource = this.dataSources;
            // 
            // companyTableAdapter
            // 
            this.companyTableAdapter.ClearBeforeFill = true;
            // 
            // idInspector
            // 
            this.idInspector.DataPropertyName = "id";
            this.idInspector.HeaderText = "id";
            this.idInspector.MinimumWidth = 6;
            this.idInspector.Name = "idInspector";
            this.idInspector.ReadOnly = true;
            this.idInspector.Visible = false;
            this.idInspector.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "Ime";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.firstnameDataGridViewTextBoxColumn.Width = 85;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "Prezime";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastnameDataGridViewTextBoxColumn.Width = 85;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.ReadOnly = true;
            this.departmentDataGridViewTextBoxColumn.Visible = false;
            this.departmentDataGridViewTextBoxColumn.Width = 125;
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
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "shift";
            this.shiftDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.ReadOnly = true;
            this.shiftDataGridViewTextBoxColumn.Visible = false;
            this.shiftDataGridViewTextBoxColumn.Width = 125;
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
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.ReadOnly = true;
            this.usernameDataGridViewTextBoxColumn.Visible = false;
            this.usernameDataGridViewTextBoxColumn.Width = 125;
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
            // idCompany
            // 
            this.idCompany.DataPropertyName = "id";
            this.idCompany.HeaderText = "id";
            this.idCompany.MinimumWidth = 6;
            this.idCompany.Name = "idCompany";
            this.idCompany.ReadOnly = true;
            this.idCompany.Visible = false;
            this.idCompany.Width = 125;
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
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Naziv";
            this.nameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            this.nameDataGridViewTextBoxColumn.ReadOnly = true;
            this.nameDataGridViewTextBoxColumn.Width = 150;
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
            // lastcontrolDataGridViewTextBoxColumn
            // 
            this.lastcontrolDataGridViewTextBoxColumn.DataPropertyName = "last_control";
            this.lastcontrolDataGridViewTextBoxColumn.HeaderText = "last_control";
            this.lastcontrolDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastcontrolDataGridViewTextBoxColumn.Name = "lastcontrolDataGridViewTextBoxColumn";
            this.lastcontrolDataGridViewTextBoxColumn.ReadOnly = true;
            this.lastcontrolDataGridViewTextBoxColumn.Visible = false;
            this.lastcontrolDataGridViewTextBoxColumn.Width = 125;
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
            // NewLabSample
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.companiesGridVew);
            this.Controls.Add(this.inspectorsGridView);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblDate);
            this.Name = "NewLabSample";
            this.Text = "NewLabSample";
            this.Load += new System.EventHandler(this.NewLabSample_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inspectorsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companiesGridVew)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.companyBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.DataGridView inspectorsGridView;
        private System.Windows.Forms.DataGridView companiesGridVew;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSubmit;
        private DataSources dataSources;
        private System.Windows.Forms.BindingSource inspectorBindingSource;
        private DataSourcesTableAdapters.inspectorTableAdapter inspectorTableAdapter;
        private System.Windows.Forms.BindingSource companyBindingSource;
        private DataSourcesTableAdapters.companyTableAdapter companyTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idInspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unavailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iscoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn idCompany;
        private System.Windows.Forms.DataGridViewTextBoxColumn jibDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn locationDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn ownerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bookkeeperDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastcontrolDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastcontroltypeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn1;
    }
}