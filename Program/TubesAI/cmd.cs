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
    public partial class cmd : Form
    {
        string sql = "";
        public cmd()
        {
            InitializeComponent();

        }

        private void richTextBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && e.Shift)
            {

            }
            else if (e.KeyCode == Keys.Enter)
            {
                RunScript();
            }
        }

        private void RunScript()
        {
            object temp = new object();

            sql = Script.Text;
            if (sql.IndexOf("*/") > 0 )
            {   
                
                sql = sql.Remove(0, sql.IndexOf("*/")+2);
                
            }

            sql = HapusLineEnding(sql);
      
            temp = DatabaseScript.SQLscriptExecute(sql);

            if (temp != null)
            {
                DatabaseScript.data.DataView.DataSource = temp;
            }
            else {
                Script.Text = deletecommnet(Script.Text);
                Script.Text = addcomment(Script.Text);
                Script.AppendText(" ");
            }
           
                                
            
        }

        string addcomment(string txt)
        {
            return "/*" + txt + "*/";
        }
        string deletecommnet(string txt) {
            if (txt.IndexOf("*/") > 0 && txt.IndexOf("/*") >= 0)
            {
                txt = txt.Remove(0, 2);
                txt = txt.Remove(txt.IndexOf("*/"), 2);
            }
           
            return txt;
        }
        string HapusLineEnding(string value)
        {
            if (String.IsNullOrEmpty(value))
            {
                return value;
            }
            string lineSeparator = ((char)0x2028).ToString();
            string paragraphSeparator = ((char)0x2029).ToString();

            return value.Replace("\r\n", string.Empty).Replace("\n", string.Empty).Replace("\r", string.Empty).Replace(lineSeparator, string.Empty).Replace(paragraphSeparator, string.Empty);
        }

    }
}
