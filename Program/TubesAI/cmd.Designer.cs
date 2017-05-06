namespace TubesAI
{
    partial class cmd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(cmd));
            this.Script = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // Script
            // 
            this.Script.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Script.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.Script.DetectUrls = false;
            resources.ApplyResources(this.Script, "Script");
            this.Script.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Script.Name = "Script";
            this.Script.KeyDown += new System.Windows.Forms.KeyEventHandler(this.richTextBox1_KeyDown);
            // 
            // cmd
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Script);
            this.Name = "cmd";
            this.Opacity = 0.8D;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox Script;
    }
}