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
    public partial class MessageForm : Form
    {
        public MessageForm(string SQLScript, string error)
        {
            InitializeComponent();
            ScriptBox.Text = SQLScript;
            MessageError.Text = error;

        }

        private void MessageForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            DatabaseScript.ErrorForm = new MessageForm("","");
        }
    }
}
