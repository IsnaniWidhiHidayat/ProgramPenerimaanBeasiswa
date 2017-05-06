using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Resources;
using TubesAI.Properties;


namespace TubesAI
{
    public partial class Form1 : Form
    {

        

        public Form1()
        {
            
            InitializeComponent();
            SetLocation ( );
            CheckCapslock ( );
            Password.Enabled = false;
            DatabaseScript.form1 = this;
            
        }
        
        #region MainProgram
            private void CheckCapslock() // Mengecek CapsLock
        {
            
            if (Control.IsKeyLocked(Keys.CapsLock))
            {
                CapsLock.Show();
            }
            else
            {
                CapsLock.Hide();
            }
        }
            private void Password_KeyDown(object sender, KeyEventArgs e) // Login
            {
                if (e.KeyCode == Keys.CapsLock)
                {
                    e.SuppressKeyPress = true;
                    CheckCapslock();
                }



                if (e.KeyCode == Keys.Enter)
                {

                    ErorMessage.Text = "";
                    DatabaseScript.Login(Password.Text);
                    Password.Clear();
                    ErorMessage.Text = DatabaseScript.errorMessage;
                    SetLocation();


                }
            } 
            private void LoginButton_MouseClick(object sender, MouseEventArgs e) // Login
            {

                DatabaseScript.Login(Password.Text);
            }
            private void SetLocation() // Mengatur Posisi 
            {

                int offset = 100;
                Password.Location = new Point((this.Size.Width / 2) - (Password.Size.Width / 2), (this.Size.Height / 2) - (Password.Size.Height / 2) + offset);
                ProfilePicture.Location = new Point((this.Size.Width / 2) - (ProfilePicture.Size.Width / 2), (this.Size.Height / 2) - (ProfilePicture.Size.Height / 2) - 130);
                ProfileName.Location = new Point((this.Size.Width / 2) - (ProfileName.Size.Width / 2), (this.Size.Height / 2) - (ProfileName.Size.Height / 2) + 20);
                PasswordLabel.Location = new Point(Password.Location.X + 6, Password.Location.Y + 6);
                CapsLock.Location = new Point((this.Size.Width / 2) + 150, PasswordLabel.Location.Y);
                LoginButton.Location = new Point(Password.Location.X + 234, Password.Location.Y + 0);
                ErorMessage.Location = new Point((this.Size.Width / 2) - (ErorMessage.Size.Width / 2), Password.Location.Y + 50);
            }
        #endregion

        #region ActionTrigger 
            private void Form1_Resize(object sender, EventArgs e)
            {
                SetLocation();

            }
            private void PasswordLabel_MouseClick(object sender, MouseEventArgs e)
            {
                Password.Enabled = true;
                Password.Focus();
                PasswordLabel.Hide();
                PasswordLabel.Enabled = false;
                CheckCapslock();
            }
            private void Form1_Load(object sender, EventArgs e) // Play Music
            {             
              //Music.PlayMusic(Resources._08___AM02_00);
            //    MusicPlayer MP = new MusicPlayer();
            //    MP.Show(this);
            }
        #endregion   
    }
}
