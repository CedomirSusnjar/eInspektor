namespace eInspektor.Views
{
    partial class ChangePswd
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.oldPswd = new System.Windows.Forms.TextBox();
            this.newPswd = new System.Windows.Forms.TextBox();
            this.failedChangepswdLbl = new System.Windows.Forms.Label();
            this.shortPswdLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Nova lozinka";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Trenutna lozinka";
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(260, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(95, 29);
            this.button1.TabIndex = 2;
            this.button1.Text = "Potvrdi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // oldPswd
            // 
            this.oldPswd.Location = new System.Drawing.Point(187, 40);
            this.oldPswd.Name = "oldPswd";
            this.oldPswd.PasswordChar = '*';
            this.oldPswd.Size = new System.Drawing.Size(168, 22);
            this.oldPswd.TabIndex = 0;
            // 
            // newPswd
            // 
            this.newPswd.Location = new System.Drawing.Point(187, 73);
            this.newPswd.Name = "newPswd";
            this.newPswd.PasswordChar = '*';
            this.newPswd.Size = new System.Drawing.Size(168, 22);
            this.newPswd.TabIndex = 1;
            // 
            // failedChangepswdLbl
            // 
            this.failedChangepswdLbl.AutoSize = true;
            this.failedChangepswdLbl.ForeColor = System.Drawing.Color.Red;
            this.failedChangepswdLbl.Location = new System.Drawing.Point(33, 117);
            this.failedChangepswdLbl.Name = "failedChangepswdLbl";
            this.failedChangepswdLbl.Size = new System.Drawing.Size(198, 17);
            this.failedChangepswdLbl.TabIndex = 8;
            this.failedChangepswdLbl.Text = "Neuspješna promjena lozinke.";
            this.failedChangepswdLbl.Visible = false;
            // 
            // shortPswdLbl
            // 
            this.shortPswdLbl.AutoSize = true;
            this.shortPswdLbl.ForeColor = System.Drawing.Color.Red;
            this.shortPswdLbl.Location = new System.Drawing.Point(36, 116);
            this.shortPswdLbl.Name = "shortPswdLbl";
            this.shortPswdLbl.Size = new System.Drawing.Size(231, 17);
            this.shortPswdLbl.TabIndex = 9;
            this.shortPswdLbl.Text = "Lozinka mora imati bar 9 karaktera.";
            this.shortPswdLbl.Visible = false;
            // 
            // ChangePswd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(367, 206);
            this.Controls.Add(this.shortPswdLbl);
            this.Controls.Add(this.failedChangepswdLbl);
            this.Controls.Add(this.newPswd);
            this.Controls.Add(this.oldPswd);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ChangePswd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Promjena lozinke";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox oldPswd;
        private System.Windows.Forms.TextBox newPswd;
        private System.Windows.Forms.Label failedChangepswdLbl;
        private System.Windows.Forms.Label shortPswdLbl;
    }
}