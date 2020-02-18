namespace eInspektor.Views
{
    partial class ReportView
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
            this.lbcompanyName = new System.Windows.Forms.Label();
            this.lbDate = new System.Windows.Forms.Label();
            this.lbContent = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cbJustified = new System.Windows.Forms.CheckBox();
            this.tbContent = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbcompanyName
            // 
            this.lbcompanyName.AutoSize = true;
            this.lbcompanyName.Location = new System.Drawing.Point(21, 19);
            this.lbcompanyName.Name = "lbcompanyName";
            this.lbcompanyName.Size = new System.Drawing.Size(46, 17);
            this.lbcompanyName.TabIndex = 0;
            this.lbcompanyName.Text = "label1";
            // 
            // lbDate
            // 
            this.lbDate.AutoSize = true;
            this.lbDate.Location = new System.Drawing.Point(21, 50);
            this.lbDate.Name = "lbDate";
            this.lbDate.Size = new System.Drawing.Size(53, 17);
            this.lbDate.TabIndex = 1;
            this.lbDate.Text = "Datum:";
            // 
            // lbContent
            // 
            this.lbContent.AutoSize = true;
            this.lbContent.Location = new System.Drawing.Point(21, 114);
            this.lbContent.Name = "lbContent";
            this.lbContent.Size = new System.Drawing.Size(60, 17);
            this.lbContent.TabIndex = 2;
            this.lbContent.Text = "Sadržaj:";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(147, 50);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 22);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // cbJustified
            // 
            this.cbJustified.AutoSize = true;
            this.cbJustified.Location = new System.Drawing.Point(24, 81);
            this.cbJustified.Name = "cbJustified";
            this.cbJustified.Size = new System.Drawing.Size(156, 21);
            this.cbJustified.TabIndex = 5;
            this.cbJustified.Text = "Opravdana kontrola";
            this.cbJustified.UseVisualStyleBackColor = true;
            // 
            // tbContent
            // 
            this.tbContent.Location = new System.Drawing.Point(106, 114);
            this.tbContent.Multiline = true;
            this.tbContent.Name = "tbContent";
            this.tbContent.Size = new System.Drawing.Size(247, 123);
            this.tbContent.TabIndex = 6;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(106, 293);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(185, 37);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Potvrdi";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // ReportView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(409, 379);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.tbContent);
            this.Controls.Add(this.cbJustified);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lbContent);
            this.Controls.Add(this.lbDate);
            this.Controls.Add(this.lbcompanyName);
            this.Name = "ReportView";
            this.Text = "ReportView";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbDate;
        private System.Windows.Forms.Label lbContent;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.CheckBox cbJustified;
        private System.Windows.Forms.TextBox tbContent;
        public System.Windows.Forms.Label lbcompanyName;
        private System.Windows.Forms.Button btnSubmit;
    }
}