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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dodajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sačuvajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrišiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.idDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.companyidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.issuerDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isjustifiedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.controlidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.isresolvedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.complaintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.complaintBindingSource)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
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
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idDataGridViewTextBoxColumn,
            this.companyidDataGridViewTextBoxColumn,
            this.textDataGridViewTextBoxColumn,
            this.issuerDataGridViewTextBoxColumn,
            this.isjustifiedDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.controlidDataGridViewTextBoxColumn,
            this.isresolvedDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.complaintBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(0, 31);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 416);
            this.dataGridView1.TabIndex = 1;
            // 
            // dodajToolStripMenuItem
            // 
            this.dodajToolStripMenuItem.Name = "dodajToolStripMenuItem";
            this.dodajToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.dodajToolStripMenuItem.Text = "Dodaj";
            this.dodajToolStripMenuItem.Click += new System.EventHandler(this.dodajToolStripMenuItem_Click);
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
            // idDataGridViewTextBoxColumn
            // 
            this.idDataGridViewTextBoxColumn.DataPropertyName = "id";
            this.idDataGridViewTextBoxColumn.HeaderText = "id";
            this.idDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.idDataGridViewTextBoxColumn.Name = "idDataGridViewTextBoxColumn";
            this.idDataGridViewTextBoxColumn.Visible = false;
            this.idDataGridViewTextBoxColumn.Width = 125;
            // 
            // companyidDataGridViewTextBoxColumn
            // 
            this.companyidDataGridViewTextBoxColumn.DataPropertyName = "company_id";
            this.companyidDataGridViewTextBoxColumn.HeaderText = "company_id";
            this.companyidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.companyidDataGridViewTextBoxColumn.Name = "companyidDataGridViewTextBoxColumn";
            this.companyidDataGridViewTextBoxColumn.Visible = false;
            this.companyidDataGridViewTextBoxColumn.Width = 125;
            // 
            // textDataGridViewTextBoxColumn
            // 
            this.textDataGridViewTextBoxColumn.DataPropertyName = "text";
            this.textDataGridViewTextBoxColumn.HeaderText = "Sadržaj";
            this.textDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.textDataGridViewTextBoxColumn.Name = "textDataGridViewTextBoxColumn";
            this.textDataGridViewTextBoxColumn.Width = 125;
            // 
            // issuerDataGridViewTextBoxColumn
            // 
            this.issuerDataGridViewTextBoxColumn.DataPropertyName = "issuer";
            this.issuerDataGridViewTextBoxColumn.HeaderText = "Podnosilac";
            this.issuerDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.issuerDataGridViewTextBoxColumn.Name = "issuerDataGridViewTextBoxColumn";
            this.issuerDataGridViewTextBoxColumn.Width = 125;
            // 
            // isjustifiedDataGridViewTextBoxColumn
            // 
            this.isjustifiedDataGridViewTextBoxColumn.DataPropertyName = "is_justified";
            this.isjustifiedDataGridViewTextBoxColumn.HeaderText = "Opravdana";
            this.isjustifiedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isjustifiedDataGridViewTextBoxColumn.Name = "isjustifiedDataGridViewTextBoxColumn";
            this.isjustifiedDataGridViewTextBoxColumn.Width = 125;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Datum";
            this.dateDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.Width = 125;
            // 
            // controlidDataGridViewTextBoxColumn
            // 
            this.controlidDataGridViewTextBoxColumn.DataPropertyName = "control_id";
            this.controlidDataGridViewTextBoxColumn.HeaderText = "control_id";
            this.controlidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.controlidDataGridViewTextBoxColumn.Name = "controlidDataGridViewTextBoxColumn";
            this.controlidDataGridViewTextBoxColumn.Visible = false;
            this.controlidDataGridViewTextBoxColumn.Width = 125;
            // 
            // isresolvedDataGridViewTextBoxColumn
            // 
            this.isresolvedDataGridViewTextBoxColumn.DataPropertyName = "is_resolved";
            this.isresolvedDataGridViewTextBoxColumn.HeaderText = "Riješena";
            this.isresolvedDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.isresolvedDataGridViewTextBoxColumn.Name = "isresolvedDataGridViewTextBoxColumn";
            this.isresolvedDataGridViewTextBoxColumn.Width = 125;
            // 
            // complaintBindingSource
            // 
            this.complaintBindingSource.DataSource = typeof(eInspektor.complaint);
            // 
            // Reclamation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn idDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn companyidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn textDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn issuerDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isjustifiedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn controlidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn isresolvedDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource complaintBindingSource;
    }
}