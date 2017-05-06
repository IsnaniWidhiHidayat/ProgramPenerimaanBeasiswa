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
    public partial class SplashScreen : Form
    {
        public SplashScreen()
        {
            InitializeComponent();
            
        }

        private void SplashScreen_KeyDown(object sender, KeyEventArgs e)
        {
            this.Close();
        }

        private void SplashScreen_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
