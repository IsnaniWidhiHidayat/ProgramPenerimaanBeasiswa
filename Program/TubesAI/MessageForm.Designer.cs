namespace TubesAI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MessageForm));
            this.ScriptBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.MessageError = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // ScriptBox
            // 
            this.ScriptBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.ScriptBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScriptBox.CausesValidation = false;
            this.ScriptBox.ForeColor = System.Drawing.Color.White;
            this.ScriptBox.Location = new System.Drawing.Point(241, 44);
            this.ScriptBox.Name = "ScriptBox";
            this.ScriptBox.ReadOnly = true;
            this.ScriptBox.Size = new System.Drawing.Size(400, 215);
            this.ScriptBox.TabIndex = 0;
            this.ScriptBox.TabStop = false;
            this.ScriptBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGray;
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(238, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(174, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "SQL script to Databases";
            // 
            // MessageError
            // 
            this.MessageError.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(26)))));
            this.MessageError.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageError.ForeColor = System.Drawing.Color.Red;
            this.MessageError.Location = new System.Drawing.Point(241, 261);
            this.MessageError.Name = "MessageError";
            this.MessageError.ReadOnly = true;
            this.MessageError.Size = new System.Drawing.Size(400, 153);
            this.MessageError.TabIndex = 4;
            this.MessageError.Text = "";
            // 
            // MessageForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.BackgroundImage = global::TubesAI.Properties.Resources.MessageFormBG;
            this.ClientSize = new System.Drawing.Size(641, 459);
            this.Controls.Add(this.MessageError);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ScriptBox);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MessageForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.MessageForm_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.RichTextBox ScriptBox;
        public System.Windows.Forms.RichTextBox MessageError;
    }
}