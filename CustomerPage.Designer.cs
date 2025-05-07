namespace Programmerings_Eksamen
{
    partial class CustomerPage
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
            this.exit_button = new System.Windows.Forms.Button();
            this.WelcomeLabel = new System.Windows.Forms.Label();
            this.MailLabel = new System.Windows.Forms.Label();
            this.read_mails_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_button.Location = new System.Drawing.Point(3, 3);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(53, 27);
            this.exit_button.TabIndex = 1;
            this.exit_button.Text = "Return";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // WelcomeLabel
            // 
            this.WelcomeLabel.AutoSize = true;
            this.WelcomeLabel.Font = new System.Drawing.Font("Segoe UI Black", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))));
            this.WelcomeLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.WelcomeLabel.Location = new System.Drawing.Point(-2, 33);
            this.WelcomeLabel.Name = "WelcomeLabel";
            this.WelcomeLabel.Size = new System.Drawing.Size(132, 30);
            this.WelcomeLabel.TabIndex = 8;
            this.WelcomeLabel.Text = "Welcome, x";
            // 
            // MailLabel
            // 
            this.MailLabel.AutoSize = true;
            this.MailLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MailLabel.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MailLabel.Location = new System.Drawing.Point(0, 63);
            this.MailLabel.Name = "MailLabel";
            this.MailLabel.Size = new System.Drawing.Size(0, 18);
            this.MailLabel.TabIndex = 9;
            // 
            // read_mails_button
            // 
            this.read_mails_button.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold);
            this.read_mails_button.Location = new System.Drawing.Point(163, 83);
            this.read_mails_button.Name = "read_mails_button";
            this.read_mails_button.Size = new System.Drawing.Size(136, 31);
            this.read_mails_button.TabIndex = 12;
            this.read_mails_button.Text = "Read Mails";
            this.read_mails_button.UseCompatibleTextRendering = true;
            this.read_mails_button.UseVisualStyleBackColor = true;
            this.read_mails_button.Click += new System.EventHandler(this.read_mails_button_Click);
            // 
            // CustomerPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Highlight;
            this.ClientSize = new System.Drawing.Size(460, 165);
            this.Controls.Add(this.read_mails_button);
            this.Controls.Add(this.MailLabel);
            this.Controls.Add(this.WelcomeLabel);
            this.Controls.Add(this.exit_button);
            this.Name = "CustomerPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "customerPage";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label WelcomeLabel;
        private System.Windows.Forms.Label MailLabel;
        private System.Windows.Forms.Button read_mails_button;
    }
}