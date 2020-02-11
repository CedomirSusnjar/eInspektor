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
            this.adminsGridView = new System.Windows.Forms.DataGridView();
            this._is_projDataSet = new eInspektor._is_projDataSet();
            this.adminBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.adminTableAdapter = new eInspektor._is_projDataSetTableAdapters.adminTableAdapter();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordhashDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataSources = new eInspektor.DataSources();
            this.inspectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inspectorTableAdapter = new eInspektor.DataSourcesTableAdapters.inspectorTableAdapter();
            this.idDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.firstnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.departmentDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unavailableDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shiftDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.iscoordinatorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.usernameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.saltDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordhashDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActiveDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.adminsGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._is_projDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // adminsGridView
            // 
            this.adminsGridView.AutoGenerateColumns = false;
            this.adminsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adminsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.usernameDataGridViewTextBoxColumn,
            this.saltDataGridViewTextBoxColumn,
            this.passwordhashDataGridViewTextBoxColumn,
            this.isActiveDataGridViewTextBoxColumn});
            this.adminsGridView.DataSource = this.adminBindingSource;
            this.adminsGridView.Location = new System.Drawing.Point(12, 12);
            this.adminsGridView.Name = "adminsGridView";
            this.adminsGridView.RowHeadersWidth = 51;
            this.adminsGridView.RowTemplate.Height = 24;
            this.adminsGridView.Size = new System.Drawing.Size(730, 122);
            this.adminsGridView.TabIndex = 0;
            // 
            // _is_projDataSet
            // 
            this._is_projDataSet.DataSetName = "_is_projDataSet";
            this._is_projDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // adminBindingSource
            // 
            this.adminBindingSource.DataMember = "admin";
            this.adminBindingSource.DataSource = this._is_projDataSet;
            // 
            // adminTableAdapter
            // 
            this.adminTableAdapter.ClearBeforeFill = true;
            // 
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn
            // 
            this.usernameDataGridViewTextBoxColumn.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn.Name = "usernameDataGridViewTextBoxColumn";
            this.usernameDataGridViewTextBoxColumn.Width = 125;
            // 
            // saltDataGridViewTextBoxColumn
            // 
            this.saltDataGridViewTextBoxColumn.DataPropertyName = "salt";
            this.saltDataGridViewTextBoxColumn.HeaderText = "salt";
            this.saltDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.saltDataGridViewTextBoxColumn.Name = "saltDataGridViewTextBoxColumn";
            this.saltDataGridViewTextBoxColumn.Width = 125;
            // 
            // passwordhashDataGridViewTextBoxColumn
            // 
            this.passwordhashDataGridViewTextBoxColumn.DataPropertyName = "password_hash";
            this.passwordhashDataGridViewTextBoxColumn.HeaderText = "password_hash";
            this.passwordhashDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.passwordhashDataGridViewTextBoxColumn.Name = "passwordhashDataGridViewTextBoxColumn";
            this.passwordhashDataGridViewTextBoxColumn.Width = 125;
            // 
            // isActiveDataGridViewTextBoxColumn
            // 
            this.isActiveDataGridViewTextBoxColumn.DataPropertyName = "isActive";
            this.isActiveDataGridViewTextBoxColumn.HeaderText = "isActive";
            this.isActiveDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isActiveDataGridViewTextBoxColumn.Name = "isActiveDataGridViewTextBoxColumn";
            this.isActiveDataGridViewTextBoxColumn.Width = 125;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
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
            this.dataGridView1.DataSource = this.inspectorBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(13, 141);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(729, 297);
            this.dataGridView1.TabIndex = 1;
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
            // idDataGridViewTextBoxColumn1
            // 
            this.idDataGridViewTextBoxColumn1.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn1.HeaderText = "id";
            this.idDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn1.Name = "idDataGridViewTextBoxColumn1";
            this.idDataGridViewTextBoxColumn1.Width = 125;
            // 
            // firstnameDataGridViewTextBoxColumn
            // 
            this.firstnameDataGridViewTextBoxColumn.DataPropertyName = "first_name";
            this.firstnameDataGridViewTextBoxColumn.HeaderText = "first_name";
            this.firstnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.firstnameDataGridViewTextBoxColumn.Name = "firstnameDataGridViewTextBoxColumn";
            this.firstnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // lastnameDataGridViewTextBoxColumn
            // 
            this.lastnameDataGridViewTextBoxColumn.DataPropertyName = "last_name";
            this.lastnameDataGridViewTextBoxColumn.HeaderText = "last_name";
            this.lastnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.lastnameDataGridViewTextBoxColumn.Name = "lastnameDataGridViewTextBoxColumn";
            this.lastnameDataGridViewTextBoxColumn.Width = 125;
            // 
            // departmentDataGridViewTextBoxColumn
            // 
            this.departmentDataGridViewTextBoxColumn.DataPropertyName = "department";
            this.departmentDataGridViewTextBoxColumn.HeaderText = "department";
            this.departmentDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.departmentDataGridViewTextBoxColumn.Name = "departmentDataGridViewTextBoxColumn";
            this.departmentDataGridViewTextBoxColumn.Width = 125;
            // 
            // unavailableDataGridViewTextBoxColumn
            // 
            this.unavailableDataGridViewTextBoxColumn.DataPropertyName = "unavailable";
            this.unavailableDataGridViewTextBoxColumn.HeaderText = "unavailable";
            this.unavailableDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.unavailableDataGridViewTextBoxColumn.Name = "unavailableDataGridViewTextBoxColumn";
            this.unavailableDataGridViewTextBoxColumn.Width = 125;
            // 
            // shiftDataGridViewTextBoxColumn
            // 
            this.shiftDataGridViewTextBoxColumn.DataPropertyName = "shift";
            this.shiftDataGridViewTextBoxColumn.HeaderText = "shift";
            this.shiftDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.shiftDataGridViewTextBoxColumn.Name = "shiftDataGridViewTextBoxColumn";
            this.shiftDataGridViewTextBoxColumn.Width = 125;
            // 
            // iscoordinatorDataGridViewTextBoxColumn
            // 
            this.iscoordinatorDataGridViewTextBoxColumn.DataPropertyName = "is_coordinator";
            this.iscoordinatorDataGridViewTextBoxColumn.HeaderText = "is_coordinator";
            this.iscoordinatorDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.iscoordinatorDataGridViewTextBoxColumn.Name = "iscoordinatorDataGridViewTextBoxColumn";
            this.iscoordinatorDataGridViewTextBoxColumn.Width = 125;
            // 
            // usernameDataGridViewTextBoxColumn1
            // 
            this.usernameDataGridViewTextBoxColumn1.DataPropertyName = "username";
            this.usernameDataGridViewTextBoxColumn1.HeaderText = "username";
            this.usernameDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.usernameDataGridViewTextBoxColumn1.Name = "usernameDataGridViewTextBoxColumn1";
            this.usernameDataGridViewTextBoxColumn1.Width = 125;
            // 
            // saltDataGridViewTextBoxColumn1
            // 
            this.saltDataGridViewTextBoxColumn1.DataPropertyName = "salt";
            this.saltDataGridViewTextBoxColumn1.HeaderText = "salt";
            this.saltDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.saltDataGridViewTextBoxColumn1.Name = "saltDataGridViewTextBoxColumn1";
            this.saltDataGridViewTextBoxColumn1.Width = 125;
            // 
            // passwordhashDataGridViewTextBoxColumn1
            // 
            this.passwordhashDataGridViewTextBoxColumn1.DataPropertyName = "password_hash";
            this.passwordhashDataGridViewTextBoxColumn1.HeaderText = "password_hash";
            this.passwordhashDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.passwordhashDataGridViewTextBoxColumn1.Name = "passwordhashDataGridViewTextBoxColumn1";
            this.passwordhashDataGridViewTextBoxColumn1.Width = 125;
            // 
            // isActiveDataGridViewTextBoxColumn1
            // 
            this.isActiveDataGridViewTextBoxColumn1.DataPropertyName = "isActive";
            this.isActiveDataGridViewTextBoxColumn1.HeaderText = "isActive";
            this.isActiveDataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.isActiveDataGridViewTextBoxColumn1.Name = "isActiveDataGridViewTextBoxColumn1";
            this.isActiveDataGridViewTextBoxColumn1.Width = 125;
            // 
            // AdminView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.adminsGridView);
            this.Name = "AdminView";
            this.Text = "AdminView";
            this.Load += new System.EventHandler(this.AdminView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.adminsGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._is_projDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.adminBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView adminsGridView;
        private _is_projDataSet _is_projDataSet;
        private System.Windows.Forms.BindingSource adminBindingSource;
        private _is_projDataSetTableAdapters.adminTableAdapter adminTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn saltDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordhashDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridView dataGridView1;
        private DataSources dataSources;
        private System.Windows.Forms.BindingSource inspectorBindingSource;
        private DataSourcesTableAdapters.inspectorTableAdapter inspectorTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn firstnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unavailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn shiftDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iscoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn saltDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordhashDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActiveDataGridViewTextBoxColumn1;
    }
}