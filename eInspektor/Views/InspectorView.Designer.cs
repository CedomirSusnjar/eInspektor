namespace eInspektor
{
    partial class InspectorView
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
            this.štampajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sačuvajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.inspectorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dataSources = new eInspektor.DataSources();
            this.inspectorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.jointcontrolBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.joint_controlTableAdapter = new eInspektor.DataSourcesTableAdapters.joint_controlTableAdapter();
            this.inspectorTableAdapter = new eInspektor.DataSourcesTableAdapters.inspectorTableAdapter();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lastname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.shift = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_coordinator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.username = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unavailableReason = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.unavailable = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.department = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.password_hash = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.is_active = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointcontrolBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem,
            this.štampajToolStripMenuItem,
            this.sačuvajToolStripMenuItem,
            this.obrišiToolStripMenuItem,
            this.dodajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1184, 28);
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
            // štampajToolStripMenuItem
            // 
            this.štampajToolStripMenuItem.Name = "štampajToolStripMenuItem";
            this.štampajToolStripMenuItem.Size = new System.Drawing.Size(78, 24);
            this.štampajToolStripMenuItem.Text = "Štampaj";
            // 
            // sačuvajToolStripMenuItem
            // 
            this.sačuvajToolStripMenuItem.Name = "sačuvajToolStripMenuItem";
            this.sačuvajToolStripMenuItem.Size = new System.Drawing.Size(73, 24);
            this.sačuvajToolStripMenuItem.Text = "Sačuvaj";
            this.sačuvajToolStripMenuItem.Click += new System.EventHandler(this.sačuvajToolStripMenuItem_Click);
            // 
            // obrišiToolStripMenuItem
            // 
            this.obrišiToolStripMenuItem.Name = "obrišiToolStripMenuItem";
            this.obrišiToolStripMenuItem.Size = new System.Drawing.Size(62, 24);
            this.obrišiToolStripMenuItem.Text = "Obriši";
            this.obrišiToolStripMenuItem.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.name,
            this.lastname,
            this.shift,
            this.is_coordinator,
            this.username,
            this.unavailableReason,
            this.unavailable,
            this.department,
            this.salt,
            this.password_hash,
            this.is_active});
            this.dataGridView1.DataSource = this.inspectorBindingSource1;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1184, 422);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleGridView_CellValueChanged);
            this.dataGridView1.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView1_DefaultValuesNeeded);
            // 
            // inspectorBindingSource1
            // 
            this.inspectorBindingSource1.DataMember = "inspector";
            this.inspectorBindingSource1.DataSource = this.dataSources;
            // 
            // dataSources
            // 
            this.dataSources.DataSetName = "DataSources";
            this.dataSources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // jointcontrolBindingSource
            // 
            this.jointcontrolBindingSource.DataMember = "joint_control";
            this.jointcontrolBindingSource.DataSource = this.dataSources;
            // 
            // joint_controlTableAdapter
            // 
            this.joint_controlTableAdapter.ClearBeforeFill = true;
            // 
            // inspectorTableAdapter
            // 
            this.inspectorTableAdapter.ClearBeforeFill = true;
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
            this.name.DataPropertyName = "first_name";
            this.name.HeaderText = "Ime";
            this.name.MinimumWidth = 6;
            this.name.Name = "name";
            // 
            // lastname
            // 
            this.lastname.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.lastname.DataPropertyName = "last_name";
            this.lastname.HeaderText = "Prezime";
            this.lastname.MinimumWidth = 6;
            this.lastname.Name = "lastname";
            // 
            // shift
            // 
            this.shift.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.shift.DataPropertyName = "shift";
            this.shift.HeaderText = "Smjena";
            this.shift.MinimumWidth = 6;
            this.shift.Name = "shift";
            // 
            // is_coordinator
            // 
            this.is_coordinator.DataPropertyName = "is_coordinator";
            this.is_coordinator.HeaderText = "is_coordinator";
            this.is_coordinator.MinimumWidth = 6;
            this.is_coordinator.Name = "is_coordinator";
            this.is_coordinator.Visible = false;
            this.is_coordinator.Width = 125;
            // 
            // username
            // 
            this.username.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.username.DataPropertyName = "username";
            this.username.HeaderText = "Korisničko ime";
            this.username.MinimumWidth = 6;
            this.username.Name = "username";
            // 
            // unavailableReason
            // 
            this.unavailableReason.HeaderText = "Razlog nedostupnosti";
            this.unavailableReason.MinimumWidth = 6;
            this.unavailableReason.Name = "unavailableReason";
            this.unavailableReason.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.unavailableReason.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.unavailableReason.Width = 125;
            // 
            // unavailable
            // 
            this.unavailable.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.unavailable.DataPropertyName = "unavailable";
            this.unavailable.HeaderText = "Razlog nedostupnosti";
            this.unavailable.MinimumWidth = 6;
            this.unavailable.Name = "unavailable";
            this.unavailable.Visible = false;
            // 
            // department
            // 
            this.department.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.department.DataPropertyName = "department";
            this.department.HeaderText = "Odjeljenje";
            this.department.MinimumWidth = 6;
            this.department.Name = "department";
            // 
            // salt
            // 
            this.salt.DataPropertyName = "salt";
            this.salt.HeaderText = "salt";
            this.salt.MinimumWidth = 6;
            this.salt.Name = "salt";
            this.salt.Visible = false;
            this.salt.Width = 125;
            // 
            // password_hash
            // 
            this.password_hash.DataPropertyName = "password_hash";
            this.password_hash.HeaderText = "password_hash";
            this.password_hash.MinimumWidth = 6;
            this.password_hash.Name = "password_hash";
            this.password_hash.Visible = false;
            this.password_hash.Width = 125;
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
            // InspectorView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "InspectorView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inspektori";
            this.Load += new System.EventHandler(this.InspectorView_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inspectorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.jointcontrolBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem štampajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sačuvajToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem obrišiToolStripMenuItem;
        private System.Windows.Forms.BindingSource inspectorBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn departmentDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn unavailableDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn iscoordinatorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn usernameDataGridViewTextBoxColumn;
        private DataSources dataSources;
        private System.Windows.Forms.BindingSource jointcontrolBindingSource;
        private DataSourcesTableAdapters.joint_controlTableAdapter joint_controlTableAdapter;
        private System.Windows.Forms.BindingSource inspectorBindingSource1;
        private DataSourcesTableAdapters.inspectorTableAdapter inspectorTableAdapter;
        private System.Windows.Forms.ToolStripMenuItem dodajToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn name;
        private System.Windows.Forms.DataGridViewTextBoxColumn lastname;
        private System.Windows.Forms.DataGridViewTextBoxColumn shift;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_coordinator;
        private System.Windows.Forms.DataGridViewTextBoxColumn username;
        private System.Windows.Forms.DataGridViewComboBoxColumn unavailableReason;
        private System.Windows.Forms.DataGridViewTextBoxColumn unavailable;
        private System.Windows.Forms.DataGridViewTextBoxColumn department;
        private System.Windows.Forms.DataGridViewTextBoxColumn salt;
        private System.Windows.Forms.DataGridViewTextBoxColumn password_hash;
        private System.Windows.Forms.DataGridViewTextBoxColumn is_active;
    }
}