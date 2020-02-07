namespace eInspektor.Views
{
    partial class Plan
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.blaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bbToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Subjekt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ulica = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Inspektor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ponedjeljakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.utorakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.srijedaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.četvrtakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.petakToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.subotaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.Subjekti = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.blaToolStripMenuItem,
            this.bbToolStripMenuItem,
            this.bToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1071, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // blaToolStripMenuItem
            // 
            this.blaToolStripMenuItem.Name = "blaToolStripMenuItem";
            this.blaToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.blaToolStripMenuItem.Text = "Nazad";
            // 
            // bbToolStripMenuItem
            // 
            this.bbToolStripMenuItem.Name = "bbToolStripMenuItem";
            this.bbToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.bbToolStripMenuItem.Text = "Sačuvaj";
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.CheckOnClick = true;
            this.bToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ponedjeljakToolStripMenuItem,
            this.utorakToolStripMenuItem,
            this.srijedaToolStripMenuItem,
            this.četvrtakToolStripMenuItem,
            this.petakToolStripMenuItem,
            this.subotaToolStripMenuItem});
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(48, 24);
            this.bToolStripMenuItem.Text = "Dan";
            this.bToolStripMenuItem.Click += new System.EventHandler(this.bToolStripMenuItem_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView2);
            this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.dataGridView1);
            this.splitContainer1.Size = new System.Drawing.Size(1071, 422);
            this.splitContainer1.SplitterDistance = 270;
            this.splitContainer1.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subjekt,
            this.Ulica,
            this.Inspektor});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(797, 422);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Subjekt
            // 
            this.Subjekt.HeaderText = "Subjekt";
            this.Subjekt.Name = "Subjekt";
            this.Subjekt.Width = 300;
            // 
            // Ulica
            // 
            this.Ulica.HeaderText = "Ulica";
            this.Ulica.Name = "Ulica";
            this.Ulica.Width = 300;
            // 
            // Inspektor
            // 
            this.Inspektor.HeaderText = "Inspektor";
            this.Inspektor.Name = "Inspektor";
            this.Inspektor.Width = 150;
            // 
            // ponedjeljakToolStripMenuItem
            // 
            this.ponedjeljakToolStripMenuItem.Name = "ponedjeljakToolStripMenuItem";
            this.ponedjeljakToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ponedjeljakToolStripMenuItem.Text = "Ponedjeljak";
            // 
            // utorakToolStripMenuItem
            // 
            this.utorakToolStripMenuItem.Name = "utorakToolStripMenuItem";
            this.utorakToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.utorakToolStripMenuItem.Text = "Utorak";
            // 
            // srijedaToolStripMenuItem
            // 
            this.srijedaToolStripMenuItem.Name = "srijedaToolStripMenuItem";
            this.srijedaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.srijedaToolStripMenuItem.Text = "Srijeda";
            // 
            // četvrtakToolStripMenuItem
            // 
            this.četvrtakToolStripMenuItem.Name = "četvrtakToolStripMenuItem";
            this.četvrtakToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.četvrtakToolStripMenuItem.Text = "Četvrtak";
            this.četvrtakToolStripMenuItem.Click += new System.EventHandler(this.četvrtakToolStripMenuItem_Click);
            // 
            // petakToolStripMenuItem
            // 
            this.petakToolStripMenuItem.Name = "petakToolStripMenuItem";
            this.petakToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.petakToolStripMenuItem.Text = "Petak";
            // 
            // subotaToolStripMenuItem
            // 
            this.subotaToolStripMenuItem.Name = "subotaToolStripMenuItem";
            this.subotaToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.subotaToolStripMenuItem.Text = "Subota";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Subjekti});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(270, 422);
            this.dataGridView2.TabIndex = 0;
            // 
            // Subjekti
            // 
            this.Subjekti.HeaderText = "Subjekti";
            this.Subjekti.Name = "Subjekti";
            this.Subjekti.Width = 225;
            // 
            // Plan
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1071, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Plan";
            this.Text = "Plan";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem blaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bbToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subjekt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ulica;
        private System.Windows.Forms.DataGridViewTextBoxColumn Inspektor;
        private System.Windows.Forms.ToolStripMenuItem ponedjeljakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem utorakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem srijedaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem četvrtakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem petakToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem subotaToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Subjekti;
    }
}