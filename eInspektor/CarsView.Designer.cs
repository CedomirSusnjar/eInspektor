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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.nazadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.štampajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sačuvajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registration = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.seats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tag = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.nazadToolStripMenuItem,
            this.štampajToolStripMenuItem,
            this.sačuvajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.registration,
            this.seats,
            this.tag});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 28);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(800, 422);
            this.dataGridView1.TabIndex = 1;
            // 
            // nazadToolStripMenuItem
            // 
            this.nazadToolStripMenuItem.Name = "nazadToolStripMenuItem";
            this.nazadToolStripMenuItem.Size = new System.Drawing.Size(64, 24);
            this.nazadToolStripMenuItem.Text = "Nazad";
            // 
            // štampajToolStripMenuItem
            // 
            this.štampajToolStripMenuItem.Name = "štampajToolStripMenuItem";
            this.štampajToolStripMenuItem.Size = new System.Drawing.Size(76, 24);
            this.štampajToolStripMenuItem.Text = "Štampaj";
            // 
            // sačuvajToolStripMenuItem
            // 
            this.sačuvajToolStripMenuItem.Name = "sačuvajToolStripMenuItem";
            this.sačuvajToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.sačuvajToolStripMenuItem.Text = "Sačuvaj";
            // 
            // registration
            // 
            this.registration.HeaderText = "Registracija";
            this.registration.Name = "registration";
            // 
            // seats
            // 
            this.seats.HeaderText = "Br. sjedišta";
            this.seats.Name = "seats";
            this.seats.Width = 120;
            // 
            // tag
            // 
            this.tag.HeaderText = "Br. vozila";
            this.tag.Name = "tag";
            // 
            // CarsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "CarsView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CarsView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem nazadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem štampajToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sačuvajToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn registration;
        private System.Windows.Forms.DataGridViewTextBoxColumn seats;
        private System.Windows.Forms.DataGridViewTextBoxColumn tag;
    }
}