namespace eInspektor.Views
{
    partial class MessageForm
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
            this.textLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textLabel
            // 
            this.textLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textLabel.Location = new System.Drawing.Point(0, 0);
            this.textLabel.Name = "textLabel";
            this.textLabel.Padding = new System.Windows.Forms.Padding(10);
            this.textLabel.Size = new System.Drawing.Size(318, 102);
            this.textLabel.TabIndex = 0;
            this.textLabel.Text = "label1";
            this.textLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(318, 102);
            this.Controls.Add(this.textLabel);
            this.Name = "MessageForm";
            this.Text = "MessageForm";
            this.Load += new System.EventHandler(this.MessageForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label textLabel;
    }
}