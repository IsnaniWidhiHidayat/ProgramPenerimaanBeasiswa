namespace TubesAI
{
    partial class SplashScreen
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
            this.Welcome = new System.Windows.Forms.Label();
            this.Powered = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Welcome
            // 
            this.Welcome.AutoSize = true;
            this.Welcome.Font = new System.Drawing.Font("Kozuka Gothic Pro R", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcome.Image = global::TubesAI.Properties.Resources.logo;
            this.Welcome.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Welcome.Location = new System.Drawing.Point(247, 158);
            this.Welcome.MinimumSize = new System.Drawing.Size(282, 60);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(282, 60);
            this.Welcome.TabIndex = 0;
            this.Welcome.Text = "               Welcome";
            this.Welcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Powered
            // 
            this.Powered.AutoSize = true;
            this.Powered.Location = new System.Drawing.Point(12, 389);
            this.Powered.Name = "Powered";
            this.Powered.Size = new System.Drawing.Size(195, 13);
            this.Powered.TabIndex = 1;
            this.Powered.Text = "Powered by C# Programming Language";
            // 
            // SplashScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ClientSize = new System.Drawing.Size(784, 411);
            this.Controls.Add(this.Powered);
            this.Controls.Add(this.Welcome);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SplashScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SplashScreen";
            this.Click += new System.EventHandler(this.SplashScreen_Click);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.SplashScreen_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcome;
        private System.Windows.Forms.Label Powered;
    }
}