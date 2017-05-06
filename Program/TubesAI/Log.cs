using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TubesAI
{
    public partial class Log : Form
    {
        public static string history;

        public Log()
        {
            InitializeComponent();
            LogText.Text = history;
            Paste();
            LogText.SelectionStart = LogText.Text.Length;
            LogText.ScrollToCaret();
            
            

        }

        public void addText(string text, Color color)
        {
           this.LogText.SelectionStart = this.LogText.TextLength;
           this.LogText.SelectionLength = 0;
           this.LogText.SelectionColor = color;
           this.LogText.AppendText(text + "\n");
           this.LogText.SelectionColor = this.LogText.ForeColor;
           this.LogText.ScrollToCaret();
        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.LogText.Clear();
            history = "";
        }

        private void Log_FormClosing(object sender, FormClosingEventArgs e)
        {
            history = LogText.Text;
            Copy();
        }

        private void Log_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseScript.logForm = new Log();
        }

        private void Copy()
        {
            Clipboard.SetText(LogText.Rtf, TextDataFormat.Rtf);
        }

        private void Paste()
        {
            if (Clipboard.ContainsText(TextDataFormat.Rtf))
            {
                LogText.Rtf = Clipboard.GetText(TextDataFormat.Rtf);

            }
        }
      
    }
}
