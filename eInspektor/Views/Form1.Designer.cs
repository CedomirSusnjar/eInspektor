namespace eInspektor
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.passwordTb = new System.Windows.Forms.TextBox();
            this.usernameTb = new System.Windows.Forms.TextBox();
            this.failedLoginLbl = new System.Windows.Forms.Label();
            this.databasefailLbl = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.button1.BackColor = System.Drawing.SystemColors.Control;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(163, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 40);
            this.button1.TabIndex = 2;
            this.button1.Text = "Prijavi se";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(64, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Korisničko ime:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(64, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "Lozinka:";
            // 
            // passwordTb
            // 
            this.passwordTb.Location = new System.Drawing.Point(231, 116);
            this.passwordTb.Name = "passwordTb";
            this.passwordTb.PasswordChar = '*';
            this.passwordTb.Size = new System.Drawing.Size(173, 22);
            this.passwordTb.TabIndex = 1;
            // 
            // usernameTb
            // 
            this.usernameTb.Location = new System.Drawing.Point(231, 74);
            this.usernameTb.Name = "usernameTb";
            this.usernameTb.Size = new System.Drawing.Size(173, 22);
            this.usernameTb.TabIndex = 0;
            // 
            // failedLoginLbl
            // 
            this.failedLoginLbl.AutoSize = true;
            this.failedLoginLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.failedLoginLbl.ForeColor = System.Drawing.Color.Red;
            this.failedLoginLbl.Location = new System.Drawing.Point(170, 212);
            this.failedLoginLbl.Name = "failedLoginLbl";
            this.failedLoginLbl.Size = new System.Drawing.Size(183, 25);
            this.failedLoginLbl.TabIndex = 1;
            this.failedLoginLbl.Text = "Neuspješna prijava.";
            this.failedLoginLbl.Visible = false;
            // 
            // databasefailLbl
            // 
            this.databasefailLbl.AutoSize = true;
            this.databasefailLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.databasefailLbl.ForeColor = System.Drawing.Color.Red;
            this.databasefailLbl.Location = new System.Drawing.Point(116, 27);
            this.databasefailLbl.Name = "databasefailLbl";
            this.databasefailLbl.Size = new System.Drawing.Size(313, 26);
            this.databasefailLbl.TabIndex = 8;
            this.databasefailLbl.Text = "Ne postoji konekcija sa bazom.";
            this.databasefailLbl.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(531, 262);
            this.Controls.Add(this.databasefailLbl);
            this.Controls.Add(this.failedLoginLbl);
            this.Controls.Add(this.usernameTb);
            this.Controls.Add(this.passwordTb);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prijava";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox passwordTb;
        private System.Windows.Forms.TextBox usernameTb;
        private System.Windows.Forms.Label failedLoginLbl;
        private System.Windows.Forms.Label databasefailLbl;
    }
}

