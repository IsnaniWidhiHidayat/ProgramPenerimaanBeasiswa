namespace TubesAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Password = new System.Windows.Forms.TextBox();
            this.ProfileName = new System.Windows.Forms.Label();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.CapsLock = new System.Windows.Forms.Label();
            this.LoginButton = new System.Windows.Forms.Button();
            this.ErorMessage = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // Password
            // 
            this.Password.AccessibleDescription = "sdaw";
            this.Password.BackColor = System.Drawing.Color.White;
            this.Password.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Password.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.Password.Font = new System.Drawing.Font("Arial", 20F);
            this.Password.ForeColor = System.Drawing.Color.DimGray;
            this.Password.Location = new System.Drawing.Point(392, 325);
            this.Password.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Password.MaxLength = 50;
            this.Password.MinimumSize = new System.Drawing.Size(204, 32);
            this.Password.Name = "Password";
            this.Password.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Password.Size = new System.Drawing.Size(276, 31);
            this.Password.TabIndex = 0;
            this.Password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Password.UseSystemPasswordChar = true;
            this.Password.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Password_KeyDown);
            // 
            // ProfileName
            // 
            this.ProfileName.AutoSize = true;
            this.ProfileName.BackColor = System.Drawing.Color.Transparent;
            this.ProfileName.Font = new System.Drawing.Font("Script MT Bold", 25F);
            this.ProfileName.ForeColor = System.Drawing.Color.White;
            this.ProfileName.Location = new System.Drawing.Point(433, 239);
            this.ProfileName.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ProfileName.Name = "ProfileName";
            this.ProfileName.Size = new System.Drawing.Size(202, 82);
            this.ProfileName.TabIndex = 2;
            this.ProfileName.Text = "DBW \r\nProgramming";
            this.ProfileName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.BackColor = System.Drawing.Color.White;
            this.PasswordLabel.Font = new System.Drawing.Font("MS Outlook", 11F);
            this.PasswordLabel.ForeColor = System.Drawing.Color.Goldenrod;
            this.PasswordLabel.Location = new System.Drawing.Point(401, 332);
            this.PasswordLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.PasswordLabel.MinimumSize = new System.Drawing.Size(260, 0);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(260, 16);
            this.PasswordLabel.TabIndex = 3;
            this.PasswordLabel.Text = "B";
            this.PasswordLabel.MouseClick += new System.Windows.Forms.MouseEventHandler(this.PasswordLabel_MouseClick);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.BackColor = System.Drawing.Color.Transparent;
            this.ProfilePicture.Image = global::TubesAI.Properties.Resources.profile;
            this.ProfilePicture.Location = new System.Drawing.Point(419, 13);
            this.ProfilePicture.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(216, 210);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 4;
            this.ProfilePicture.TabStop = false;
            // 
            // CapsLock
            // 
            this.CapsLock.AutoSize = true;
            this.CapsLock.BackColor = System.Drawing.Color.Transparent;
            this.CapsLock.Font = new System.Drawing.Font("Calibri", 11F, System.Drawing.FontStyle.Bold);
            this.CapsLock.ForeColor = System.Drawing.Color.Orange;
            this.CapsLock.Location = new System.Drawing.Point(680, 332);
            this.CapsLock.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.CapsLock.Name = "CapsLock";
            this.CapsLock.Size = new System.Drawing.Size(65, 18);
            this.CapsLock.TabIndex = 5;
            this.CapsLock.Text = "Caps lock";
            // 
            // LoginButton
            // 
            this.LoginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.LoginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.LoginButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.LoginButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.LoginButton.FlatAppearance.BorderSize = 0;
            this.LoginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LoginButton.Font = new System.Drawing.Font("Wingdings 3", 18F, System.Drawing.FontStyle.Bold);
            this.LoginButton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LoginButton.Image = global::TubesAI.Properties.Resources.Arrow1;
            this.LoginButton.Location = new System.Drawing.Point(626, 325);
            this.LoginButton.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(42, 32);
            this.LoginButton.TabIndex = 6;
            this.LoginButton.UseVisualStyleBackColor = false;
            this.LoginButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.LoginButton_MouseClick);
            // 
            // ErorMessage
            // 
            this.ErorMessage.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ErorMessage.AutoSize = true;
            this.ErorMessage.BackColor = System.Drawing.Color.Transparent;
            this.ErorMessage.Font = new System.Drawing.Font("Calibri", 10F);
            this.ErorMessage.ForeColor = System.Drawing.Color.Red;
            this.ErorMessage.Location = new System.Drawing.Point(350, 362);
            this.ErorMessage.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.ErorMessage.MaximumSize = new System.Drawing.Size(350, 200);
            this.ErorMessage.Name = "ErorMessage";
            this.ErorMessage.Size = new System.Drawing.Size(0, 17);
            this.ErorMessage.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImage = global::TubesAI.Properties.Resources.artificial_engine_00229391;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1016, 501);
            this.Controls.Add(this.ErorMessage);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.CapsLock);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.ProfileName);
            this.Controls.Add(this.Password);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 4, 2, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DBW";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Password;
        private System.Windows.Forms.Label ProfileName;
        private System.Windows.Forms.Label PasswordLabel;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Label CapsLock;
        private System.Windows.Forms.Button LoginButton;
        private System.Windows.Forms.Label ErorMessage;
      
        
    }
}

