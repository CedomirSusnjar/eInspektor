namespace eInspektor
{
    partial class CarsView
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
            this.vehicleGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isActive1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataSources = new eInspektor.DataSources();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.vehicleTableAdapter2 = new eInspektor.DataSourcesTableAdapters.vehicleTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).BeginInit();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehicleGridView
            // 
            this.vehicleGridView.AutoGenerateColumns = false;
            this.vehicleGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehicleGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn12,
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.isActive1});
            this.vehicleGridView.DataSource = this.bindingSource;
            this.vehicleGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vehicleGridView.Location = new System.Drawing.Point(0, 28);
            this.vehicleGridView.Name = "vehicleGridView";
            this.vehicleGridView.RowHeadersWidth = 51;
            this.vehicleGridView.RowTemplate.Height = 24;
            this.vehicleGridView.Size = new System.Drawing.Size(782, 525);
            this.vehicleGridView.TabIndex = 0;
            this.vehicleGridView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.vehicleGridView_CellValueChanged);
            this.vehicleGridView.DefaultValuesNeeded += new System.Windows.Forms.DataGridViewRowEventHandler(this.dataGridView2_DefaultValuesNeeded);
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.DataPropertyName = "id";
            this.dataGridViewTextBoxColumn11.HeaderText = "id";
            this.dataGridViewTextBoxColumn11.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.Visible = false;
            this.dataGridViewTextBoxColumn11.Width = 125;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.DataPropertyName = "name";
            this.dataGridViewTextBoxColumn16.HeaderText = "Naziv";
            this.dataGridViewTextBoxColumn16.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.Width = 125;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.DataPropertyName = "registration_num";
            this.dataGridViewTextBoxColumn12.HeaderText = "Registracioni broj";
            this.dataGridViewTextBoxColumn12.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.Width = 125;
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.DataPropertyName = "max_capacity";
            this.dataGridViewTextBoxColumn13.HeaderText = "Broj mjesta";
            this.dataGridViewTextBoxColumn13.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.Width = 125;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.DataPropertyName = "tag";
            this.dataGridViewTextBoxColumn14.HeaderText = "Oznaka";
            this.dataGridViewTextBoxColumn14.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.Width = 125;
            // 
            // isActive1
            // 
            this.isActive1.DataPropertyName = "isActive";
            this.isActive1.HeaderText = "isActive";
            this.isActive1.MinimumWidth = 6;
            this.isActive1.Name = "isActive1";
            this.isActive1.Visible = false;
            this.isActive1.Width = 125;
            // 
            // bindingSource
            // 
            this.bindingSource.DataMember = "vehicle";
            this.bindingSource.DataSource = this.dataSources;
            // 
            // dataSources
            // 
            this.dataSources.DataSetName = "DataSources";
            this.dataSources.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // menuStrip
            // 
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem5});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(782, 28);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip2";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(66, 24);
            this.toolStripMenuItem1.Text = "Nazad";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.nazadToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(78, 24);
            this.toolStripMenuItem2.Text = "Štampaj";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(73, 24);
            this.toolStripMenuItem3.Text = "Sačuvaj";
            this.toolStripMenuItem3.Click += new System.EventHandler(this.sačuvajToolStripMenuItem_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(62, 24);
            this.toolStripMenuItem5.Text = "Obriši";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.obrišiToolStripMenuItem_Click);
            // 
            // vehicleTableAdapter2
            // 
            this.vehicleTableAdapter2.ClearBeforeFill = true;
            // 
            // CarsView
            // 
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.vehicleGridView);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "CarsView";
            this.Load += new System.EventHandler(this.CarsView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicleGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataSources)).EndInit();
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vehicleGridView;
        private System.Windows.Forms.MenuStrip menuStrip;
        private DataSources dataSources;
        private DataSourcesTableAdapters.vehicleTableAdapter vehicleTableAdapter2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.BindingSource bindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private System.Windows.Forms.DataGridViewTextBoxColumn isActive1;
    }
}