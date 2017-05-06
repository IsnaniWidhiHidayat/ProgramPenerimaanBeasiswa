namespace TubesAI
{
    partial class MusicPlayer
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MusicPlayer));
            this.Music_List = new System.Windows.Forms.ListBox();
            this.Hide = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // Music_List
            // 
            this.Music_List.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Music_List.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Music_List.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Music_List.FormattingEnabled = true;
            this.Music_List.Location = new System.Drawing.Point(-1, -1);
            this.Music_List.Name = "Music_List";
            this.Music_List.Size = new System.Drawing.Size(365, 377);
            this.Music_List.TabIndex = 1;
            this.Music_List.SelectedIndexChanged += new System.EventHandler(this.Music_List_SelectedIndexChanged);
            // 
            // Hide
            // 
            this.Hide.ForeColor = System.Drawing.Color.Black;
            this.Hide.Location = new System.Drawing.Point(281, 382);
            this.Hide.Name = "Hide";
            this.Hide.Size = new System.Drawing.Size(75, 23);
            this.Hide.TabIndex = 2;
            this.Hide.Text = "Ok";
            this.Hide.UseVisualStyleBackColor = true;
            this.Hide.Click += new System.EventHandler(this.Hide_Click);
            // 
            // MusicPlayer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(361, 408);
            this.ControlBox = false;
            this.Controls.Add(this.Hide);
            this.Controls.Add(this.Music_List);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MusicPlayer";
            this.Text = "Music List";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox Music_List;
        private System.Windows.Forms.Button Hide;
    }
}