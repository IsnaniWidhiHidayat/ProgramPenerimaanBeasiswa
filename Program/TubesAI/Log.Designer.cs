namespace TubesAI
{
    partial class Log
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Log));
            this.LogText = new System.Windows.Forms.RichTextBox();
            this.Menustrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.clear = new System.Windows.Forms.ToolStripMenuItem();
            this.LogLabel = new System.Windows.Forms.Label();
            this.Menustrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // LogText
            // 
            resources.ApplyResources(this.LogText, "LogText");
            this.LogText.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.LogText.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LogText.ContextMenuStrip = this.Menustrip;
            this.LogText.DetectUrls = false;
            this.LogText.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogText.Name = "LogText";
            this.LogText.ReadOnly = true;
            // 
            // Menustrip
            // 
            this.Menustrip.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.Menustrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clear});
            this.Menustrip.Name = "contextMenuStrip1";
            resources.ApplyResources(this.Menustrip, "Menustrip");
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.SystemColors.ControlDark;
            this.clear.ForeColor = System.Drawing.Color.Black;
            this.clear.Image = global::TubesAI.Properties.Resources.clear;
            this.clear.Name = "clear";
            resources.ApplyResources(this.clear, "clear");
            this.clear.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // LogLabel
            // 
            resources.ApplyResources(this.LogLabel, "LogLabel");
            this.LogLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.LogLabel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.LogLabel.Name = "LogLabel";
            // 
            // Log
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Controls.Add(this.LogLabel);
            this.Controls.Add(this.LogText);
            this.DoubleBuffered = true;
            this.Name = "Log";
            this.Opacity = 0.9D;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Log_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Log_FormClosed);
            this.Menustrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LogLabel;
        public System.Windows.Forms.RichTextBox LogText;
        private System.Windows.Forms.ContextMenuStrip Menustrip;
        private System.Windows.Forms.ToolStripMenuItem clear;
    }
}
