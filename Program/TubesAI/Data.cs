using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace TubesAI

{
    public partial class Data : Form
    {

       
        

        public Data()
        {
            InitializeComponent();
        }

      

        #region HideShowSomething
            private void sqlScript_TextChanged(object sender, EventArgs e)
            {
                SQLScriptLabel.Hide();
            }

            private void InputData_Click(object sender, EventArgs e)
            {
                AddDataLabel.Hide();
            }

            private void Data_FormClosing(object sender, FormClosingEventArgs e) // Mencegah Applikasi di tutup
            {

                DialogResult dialog = MessageBox.Show("Close Program ?", "Warning", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);

                if (dialog == DialogResult.No || dialog == DialogResult.Cancel)
                {
                    e.Cancel = true;

                }

            }

            private void Data_FormClosed(object sender, FormClosedEventArgs e)   // Menutup Aplikasi
            {
                Application.Exit();
            }
        #endregion
   
        #region Menu
            private void ClearData_Click(object sender, EventArgs e)  // Menghapus Data di inputan GridView
            {
                InputData.Rows.Clear();
                InputData.Refresh();
            }
            private void Refresh_Click(object sender, EventArgs e)    // Refresh Table Beasiswa
            {
                DataView.DataSource = DatabaseScript.SQLscriptExecute("select *from beasiswa;");
            }
            private void Clear_Click(object sender, EventArgs e)      // Menghapus Script di textbox SQL Script
            {
                sqlScript.Clear();
            }
        #endregion

        #region Main_program
            private void Data_Load(object sender, EventArgs e)        // Action / Trigger
            {
               
                DataView.DataSource = DatabaseScript.SQLscriptExecute("select *from beasiswa;");
                Algoritm.SelectedItem = Algoritm.Items[0];
                ValueView();
                
                            
            }
            private void AddData_Click(object sender, EventArgs e)    // Run Program
            {
               
                if (Algoritm.SelectedItem == Algoritm.Items[0])
                {
                    DatabaseScript.AddData();
                    ValueView();
                    foreach (DatabaseScript.Mahasiswa mhs in DatabaseScript.mahasiswa)
                    {
                      
                            DatabaseScript.AddToDatabase(mhs);
                        
                       
                    }
                   
                    Refresh.PerformClick();
                }
                else {
                    DatabaseScript.AddData();
                    int error = 0;
                    DialogResult dialog = MessageBox.Show("Add now to databases?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    
                        if (dialog == DialogResult.Yes)
                        {
                            DatabaseScript.AddData();
                            
                            foreach (DatabaseScript.Mahasiswa mhs in DatabaseScript.mahasiswa)
                            {

                                if (mhs.diterima == "-" || mhs.diterima == null)
                                {
                                    error += 1;
                                }

                                
                            }

                            if (error > 0)
                            {
                                DialogResult result = MessageBox.Show("We Find " + error + " data that dont have result, we will ignore it do you want to Process?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                                if (result == System.Windows.Forms.DialogResult.Yes)
                                {
                                    foreach (DatabaseScript.Mahasiswa mhs in DatabaseScript.mahasiswa)
                                    {
                                        if (mhs.diterima != "-" && mhs.diterima != null)
                                        {
                                            DatabaseScript.AddToDatabase(mhs);
                                        }
                                    }
                                }
                            }
                            else {

                                foreach (DatabaseScript.Mahasiswa mhs in DatabaseScript.mahasiswa)
                                {
                                  
                                        DatabaseScript.AddToDatabase(mhs);
                                    
                                }
                            
                            
                            }
                                
                            

                            

                            Refresh.PerformClick();
                            ValueView();
                        }
                    }
                
             

            }
            private void ExecuteSQL_Click(object sender, EventArgs e)  // Menjalankan SQL Script
            {
                object temp = DatabaseScript.SQLscriptExecute(sqlScript.Text);
                if(temp != null){
                    DataView.DataSource = temp;
                }
                
            }
        #endregion

            private void DataView_MouseClick(object sender, MouseEventArgs e)
            {
                bool FoundPK = false;

                for (int i = 0; i < DataView.ColumnCount; i++)
                {
                    if (DataView.Columns[i].Name == "Npm")
                    {
                        FoundPK = true;
                    }
                }

                if (!FoundPK)
                {
                    EditMenu.Enabled = false;
                    DeleteMenu.Enabled = false;
                }
                else {
                    EditMenu.Enabled = true;
                    DeleteMenu.Enabled = true;
                }
                                                 
                if(e.Button == MouseButtons.Right )
                {
                    
                     contextMenuStrip1.Show(DataView, new Point(e.X, e.Y));
                                   
                }
            }
            private void EditMenu_Click(object sender, EventArgs e)
            {
                   
                   DatabaseScript.EditData();
                  
                   ValueView();
                   
            }
            private void DeleteMenu_Click(object sender, EventArgs e)
            {
                
                DatabaseScript.Delete();
                
            }
            private void Newcmd_Click(object sender, EventArgs e)
            {
                cmd cm = new cmd();
                cm.Show(this);
            }
            private void Log_Click(object sender, EventArgs e)
            {
                DatabaseScript.logForm.Show(this);
                DatabaseScript.logForm.BringToFront();
               
            }
            public void ValueView() {
                int[] temp;
                tree.ExpandAll();
                Rumus.SearchAllGain();
                for (int i = 0; i < 5;i++ )
                {
                    tree.Nodes[0].Nodes[i].Text = SetText(Rumus.coloumAndGain[i].Coloum, Rumus.coloumAndGain[i].Gain.ToString(), 18);
                }

                //double test = Rumus.Entropy(3,0,3);
                //jenis beasiswa;

                temp = DatabaseScript.SearchDataEntropy("Jenis_beasiswa", "BBM");
                tree.Nodes[1].Nodes[0].Nodes[0].Text = SetText("BBM", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 5);
                temp = DatabaseScript.SearchDataEntropy("Jenis_beasiswa", "PPA");
                tree.Nodes[1].Nodes[0].Nodes[1].Text = SetText("PPA", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 5);

               //prestasi

                temp = DatabaseScript.SearchDataEntropy("Prestasi", "Internasional");
                tree.Nodes[1].Nodes[4].Nodes[0].Text = SetText("Internasional", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 14);
                temp = DatabaseScript.SearchDataEntropy("Prestasi", "Nasional");
                tree.Nodes[1].Nodes[4].Nodes[1].Text = SetText("Nasional", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 14);
                temp = DatabaseScript.SearchDataEntropy("Prestasi", "Regional");
                tree.Nodes[1].Nodes[4].Nodes[2].Text = SetText("Regional", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 14);
                temp = DatabaseScript.SearchDataEntropy("Prestasi", "Lokal");
                tree.Nodes[1].Nodes[4].Nodes[3].Text = SetText("Lokal", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 14);
                

                //aktif anggota
                
                temp = DatabaseScript.SearchDataEntropy("Aktif_Organisasi", "Ketua");
                tree.Nodes[1].Nodes[2].Nodes[0].Text = SetText("Ketua",Rumus.Entropy(temp[0],temp[1],temp[2]).ToString(),10);
                temp = DatabaseScript.SearchDataEntropy("Aktif_Organisasi", "Pengurus");
                tree.Nodes[1].Nodes[2].Nodes[1].Text = SetText("Pengurus", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 10);
                temp = DatabaseScript.SearchDataEntropy("Aktif_Organisasi", "Anggota");
                tree.Nodes[1].Nodes[2].Nodes[2].Text = SetText("Anggota", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 10);

                //Semesta

                temp = DatabaseScript.SearchDataEntropy("Select count(IF(Diterima ='ya',1,Null)) as ya,count(IF(Diterima ='tidak',1,Null)) as tidak,count(IF(Diterima,1,Null)) as total from beasiswa;");
                tree.Nodes[1].Nodes[5].Text = SetText("Semesta", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 10);
               
                
                //Financial
                temp = DatabaseScript.SearchDataEntropy("select count(if(Financial <= 1000000,1,Null) AND if(Diterima='Ya',1,Null))as Ya,count(if(Financial <= 1000000,1,Null) AND if(Diterima='Tidak',1,Null))as Tidak,count(if(Financial <= 1000000,1,Null)) Total from beasiswa;");
                tree.Nodes[1].Nodes[3].Nodes[0].Text = SetText("      <=1jt", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 15);
                temp = DatabaseScript.SearchDataEntropy("select count(if(Financial <= 5000000,1,Null) AND if(Financial > 1000000,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(Financial <= 5000000,1,Null) AND if(Financial > 1000000,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(Financial <= 5000000,1,Null) AND if(Financial > 1000000,1,Null)) as Total from beasiswa;");
                tree.Nodes[1].Nodes[3].Nodes[1].Text = SetText("  1jt - 5jt", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 15);
                temp = DatabaseScript.SearchDataEntropy("select count(if(Financial <= 7500000,1,Null) AND if(Financial > 5000000,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(Financial <= 7500000,1,Null) AND if(Financial > 5000000,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(Financial <= 7500000,1,Null) AND if(Financial > 5000000,1,Null)) as Total from beasiswa;");
                tree.Nodes[1].Nodes[3].Nodes[2].Text = SetText("  5jt - 7.5jt", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 15);
                temp = DatabaseScript.SearchDataEntropy("select count(if(Financial <= 10000000,1,Null) AND if(Financial > 7500000,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(Financial <= 10000000,1,Null) AND if(Financial > 7500000,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(Financial <= 10000000,1,Null) AND if(Financial > 7500000,1,Null)) as Total from beasiswa;");
                tree.Nodes[1].Nodes[3].Nodes[3].Text = SetText("7.5jt - 10jt", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 15);
                temp = DatabaseScript.SearchDataEntropy("select count(if(Financial > 10000000,1,Null) AND if(Diterima='Ya',1,Null))as Ya,count(if(Financial > 10000000,1,Null) AND if(Diterima='Tidak',1,Null))as Tidak,count(if(Financial > 10000000,1,Null)) Total from beasiswa;");
                tree.Nodes[1].Nodes[3].Nodes[4].Text = SetText("      > 10jt", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 15);
                
                //IPK
                temp = DatabaseScript.SearchDataEntropy("select count(if(ipk = '4',1,Null) AND if(Diterima='Ya',1,Null))as Ya,count(if(ipk = '4',1,Null) AND if(Diterima='Tidak',1,Null))as Tidak,count(if(ipk = '4',1,Null)) Total from beasiswa;");
                tree.Nodes[1].Nodes[1].Nodes[0].Text = SetText("    4     ", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 15);
                temp = DatabaseScript.SearchDataEntropy("select count(if(ipk < 4,1,Null) AND if(ipk >= 3.5,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(ipk < 4,1,Null) AND if(ipk >= 3.5,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(ipk < 4,1,Null) AND if(ipk >= 3.5,1,Null)) as Total from beasiswa;");
                tree.Nodes[1].Nodes[1].Nodes[1].Text = SetText("  4 - 3.5 ", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 15);
                temp = DatabaseScript.SearchDataEntropy("select count(if(ipk < 3.5,1,Null) AND if(ipk >= 3.25,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(ipk < 3.5,1,Null) AND if(ipk >= 3.25,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(ipk < 3.5,1,Null) AND if(ipk >= 3.25,1,Null)) as Total from beasiswa;");
                tree.Nodes[1].Nodes[1].Nodes[2].Text = SetText("3.5 - 3.25", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 15);
                temp = DatabaseScript.SearchDataEntropy("select count(if(ipk < 3.25,1,Null) AND if(ipk >= 3,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(ipk < 3.25,1,Null) AND if(ipk >= 3,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(ipk < 3.25,1,Null) AND if(ipk >= 3,1,Null)) as Total from beasiswa;");
                tree.Nodes[1].Nodes[1].Nodes[3].Text = SetText("3.25- 3   ", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 15);
                temp = DatabaseScript.SearchDataEntropy("select count(if(ipk < 3,1,Null) AND if(Diterima='Ya',1,Null)) as Ya,count(if(ipk < 3,1,Null) AND if(Diterima='Tidak',1,Null)) as Tidak,count(if(ipk < 3,1,Null))as Total from beasiswa;");
                tree.Nodes[1].Nodes[1].Nodes[4].Text = SetText("    < 3   ", Rumus.Entropy(temp[0], temp[1], temp[2]).ToString(), 15);
            }
            private string SetText(string A,string B, int Max) {
                int now = Max - A.Length;
                for (int i = 0; i < now; i ++)
                {
                    A += " ";
                }

                return A + B;
            }
            private void button1_Click(object sender, EventArgs e)
            {
                ValueView();
            }

            private void Export_Click(object sender, EventArgs e)
            {
                
                DatabaseScript.BackUp();
                
            }

            private void Import_Click(object sender, EventArgs e)
            {
                
                DatabaseScript.Import();
                
            }

            private void InputData_DataSourceChanged(object sender, EventArgs e)
            {
                AddDataLabel.Hide();
            }

            private void MusicLabel_Click(object sender, EventArgs e)
            {
                DatabaseScript.MP.Show(this);
            }

            private void Stop_Click(object sender, EventArgs e)
            {
                DatabaseScript.MP.Stop();
            }

            private void Next_Click(object sender, EventArgs e)
            {
                DatabaseScript.MP.next();
                updateJudul();

            }

            private void Previous_Click(object sender, EventArgs e)
            {
                DatabaseScript.MP.previous();
                updateJudul();
               

            }

            private void button2_Click(object sender, EventArgs e)
            {
                //MP.checkPLay();
                if (DatabaseScript.MP.player.playState == WMPPlayState.wmppsPlaying)
                {
                    DatabaseScript.MP.player.controls.pause();
                    button2.Image = TubesAI.Properties.Resources.pause;
                }
                else
                {
                    DatabaseScript.MP.player.controls.play();
                    button2.Image = TubesAI.Properties.Resources.play;
                }
            }

           public  void updateJudul() {
               Judul_lagu.Text = DatabaseScript.MP.UpdateJudul();
            }

           
                   
    }
}
