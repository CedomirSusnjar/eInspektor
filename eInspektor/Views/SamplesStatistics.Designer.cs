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
            this.samplesGV = new System.Windows.Forms.DataGridView();
            this.company = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inspector = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.description = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.searchTb = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.searchTB1 = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.samplesGV)).BeginInit();
            this.SuspendLayout();
            // 
            // samplesGV
            // 
            this.samplesGV.AllowUserToAddRows = false;
            this.samplesGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.samplesGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.company,
            this.inspector,
            this.date,
            this.description});
            this.samplesGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.samplesGV.Location = new System.Drawing.Point(0, 24);
            this.samplesGV.Name = "samplesGV";
            this.samplesGV.RowTemplate.Height = 24;
            this.samplesGV.Size = new System.Drawing.Size(902, 426);
            this.samplesGV.TabIndex = 0;
            // 
            // company
            // 
            this.company.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.company.HeaderText = "Subjekt";
            this.company.Name = "company";
            // 
            // inspector
            // 
            this.inspector.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.inspector.HeaderText = "Inspektor";
            this.inspector.Name = "inspector";
            // 
            // date
            // 
            this.date.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.date.HeaderText = "Datum preuzimanja";
            this.date.Name = "date";
            // 
            // description
            // 
            this.description.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.description.HeaderText = "Opis";
            this.description.Name = "description";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(902, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // searchTb
            // 
            this.searchTb.Location = new System.Drawing.Point(169, 1);
            this.searchTb.Name = "searchTb";
            this.searchTb.Size = new System.Drawing.Size(128, 22);
            this.searchTb.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(151, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Pretraži po inspektoru:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(303, 1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Pretraži";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(449, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 17);
            this.label2.TabIndex = 5;
            this.label2.Text = "Pretraži po subjektu:";
            // 
            // searchTB1
            // 
            this.searchTB1.Location = new System.Drawing.Point(606, 1);
            this.searchTB1.Name = "searchTB1";
            this.searchTB1.Size = new System.Drawing.Size(128, 22);
            this.searchTB1.TabIndex = 6;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(740, 1);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "Pretraži";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // SamplesStatistics
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(902, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.searchTB1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.searchTb);
            this.Controls.Add(this.samplesGV);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "SamplesStatistics";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Uzorci";
            this.Load += new System.EventHandler(this.SamplesStatistics_Load);
            ((System.ComponentModel.ISupportInitialize)(this.samplesGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView samplesGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn company;
        private System.Windows.Forms.DataGridViewTextBoxColumn inspector;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn description;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.TextBox searchTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox searchTB1;
        private System.Windows.Forms.Button button2;
    }
}