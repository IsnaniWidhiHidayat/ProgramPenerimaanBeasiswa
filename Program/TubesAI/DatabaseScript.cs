using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data;
using System.Globalization;
using System.Drawing;
using System.IO;




namespace TubesAI
{
    class DatabaseScript
    {

       public struct Mahasiswa   //struct
        {
           public string  Npm;
           public string  Nama;
           public string  Jenis_beasiswa;
           public string  ipk;
           public string  aktif_organisasi;
           public string  Financial;
           public string  prestasi;
           public string  diterima;
        }

        #region Variable
           public static List<string> AtributMahasiswa;
           public static MySqlConnection connection;
           public static string errorMessage;
           public static Form1 form1;
           public static Data data;
           public static Log logForm;
           public static MessageForm ErrorForm;
           public static Mahasiswa[] mahasiswa;
           public static MusicPlayer MP;
           
          
       #endregion

        #region Function
           public static int[] SearchDataEntropy(string Coloum, string kelas)       //Mencari banyak data di database sesuai Script SQL
           {

               CheckConnection();

               int[] hasil = new int[3];
               string Query = "select Count(if(" + Coloum + "='" + kelas + "',1,Null )AND if(Diterima='Ya',1,Null)) AS ya,Count(if(" + Coloum + "='" + kelas + "',1,Null )AND if(Diterima='Tidak',1,Null)) AS tidak,Count(if(" + Coloum + "='" + kelas + "',1,Null )) AS total From beasiswa";
               MySqlCommand cmdDataBase = new MySqlCommand(Query, connection);
               MySqlDataReader Reader;
               Reader = cmdDataBase.ExecuteReader();
               Reader.Read();
               hasil[0] = Reader.GetInt32("ya");
               hasil[1] = Reader.GetInt32("tidak");
               hasil[2] = Reader.GetInt32("total");
               connection.Close();
               return hasil;
           }

           public static int[] SearchDataEntropy(string Query)                     //Mencari banyak data di database sesuai Script SQL
           {
               CheckConnection();

               int[] hasil = new int[3];
               MySqlCommand cmdDataBase = new MySqlCommand(Query, connection);
               MySqlDataReader Reader;
               Reader = cmdDataBase.ExecuteReader();
               Reader.Read();
               hasil[0] = Reader.GetInt32("ya");
               hasil[1] = Reader.GetInt32("tidak");
               hasil[2] = Reader.GetInt32("total");
               connection.Close();
               return hasil;
           }
           public static int[] treeScript(int coloumAndGain, int AtributMahasiswa) // Pembuatan Script Keseluruhan
           {
               int[] hasil = new int[2];
               string add = "";
               string Query = "";
               string DiterimaY = "AND if(Diterima='Ya',1,Null)";
               string DiterimaT = "AND if(Diterima='Tidak',1,Null)";

               for (int i = 0; i <= coloumAndGain; i++)
               {
                   string Coloum = Rumus.coloumAndGain[i].Coloum;


                   if (Coloum == "Financial")
                   {
                       double financial = Convert.ToDouble(DatabaseScript.AtributMahasiswa[i]);

                       if (financial <= 1000000)
                       {
                           add = FixScript(i, add, "if(" + Coloum + "<" + Convert.ToString(1000000) + ",1,Null)");
                       }
                       else if (financial > 1000000 && financial <= 5000000)
                       {
                           add = FixScript(i, add, range(Coloum, Convert.ToString(1000000), Convert.ToString(5000000)));
                       }
                       else if (financial > 5000000 && financial <= 7500000)
                       {
                           add = FixScript(i, add, range(Coloum, Convert.ToString(5000000), Convert.ToString(7500000)));
                       }
                       else if (financial > 7500000 && financial <= 10000000)
                       {
                           add = FixScript(i, add, range(Coloum, Convert.ToString(7500000), Convert.ToString(10000000)));
                       }
                       else
                       {
                           add = FixScript(i, add, "if(" + Coloum + ">" + Convert.ToString(10000000) + ",1,Null)");
                       }
                   }
                   else if (Coloum == "ipk")
                   {
                       double IPK = FixIpk(DatabaseScript.AtributMahasiswa[i]);

                       if (IPK == 4)
                       {
                           add = FixScript(i, add, "if(" + Coloum + "=" + FixIpk(4) + ",1,Null)");
                       }
                       else if (IPK >= 3.5 && IPK < 4)
                       {
                           add = FixScript(i, add, range(Coloum, FixIpk(3.5), FixIpk(4)));
                       }
                       else if (IPK >= 3.25 && IPK < 3.5)
                       {
                           add = FixScript(i, add, range(Coloum, FixIpk(3.25), FixIpk(3.5)));
                       }
                       else if (IPK >= 3 && IPK < 3.25)
                       {
                           add = FixScript(i, add, range(Coloum, FixIpk(3), FixIpk(3.25)));
                       }
                       else
                       {
                           add = FixScript(i, add, "if(" + Coloum + "<" + FixIpk(3) + ",1,Null)");
                       }

                   }
                   else if (Coloum == "Prestasi" && DatabaseScript.AtributMahasiswa[i] == "")
                   {
                       add = FixScript(i, add, " if(" + Coloum + " is Null,1,Null)");
                   }
                   else
                   {
                       add = FixScript(i, add, " if(" + Coloum + "='" + DatabaseScript.AtributMahasiswa[i] + "',1,Null)");
                   }

               }

               Query = "select count(" + add + DiterimaY + ") as Ya,count(" + add + DiterimaT + ") as Tidak from beasiswa;";

               CheckConnection();
               MySqlCommand cmdDataBase = new MySqlCommand(Query, connection);
               MySqlDataReader Reader;
               Reader = cmdDataBase.ExecuteReader();
               Reader.Read();
               hasil[0] = Reader.GetInt32("ya");
               hasil[1] = Reader.GetInt32("tidak");
               logForm.addText(Query + "\n", Color.White);
               connection.Close();

               return hasil;
           }
           public static string range(string Coloum, string A, string B)           // Pembuatan Script SQL IPK Dan Financial
           {
               return "if(" + Coloum + ">" + A + ",1,Null) AND if(" + Coloum + "<=" + B + ",1,Null)";
           }
           public static string FixScript(int A, string add, string script)         // Penambahan Script SQL Keseluruhan
           {
               if (A == 0)
               {
                   return script;
               }
               else
               {
                   return add + " AND " + script;
               }

           }
           public static double FixIpk(string A)                                  // FIX nilai IPK yang dari String ke double
           {
               CultureInfo usCulture = new CultureInfo("en-US");
               NumberFormatInfo numberFormat = usCulture.NumberFormat;
               return double.Parse(A, numberFormat);
           }
           public static string FixIpk(double A)                                   // FIX nilai IPK yang dari double ke String
           {
               return Convert.ToString(A).Replace(',', '.');
           }
           public static string DecisionResult(Mahasiswa mahasiswa,int rows)                // Hasil dari Decision tree Ya atau Tidak
           {
               logForm.addText("------------------------Row " + (rows + 1) + "--------------------\n", Color.LightBlue);
               CheckConnection();
               Rumus.SearchAllGain();
               AtributMahasiswa = new List<string>();

               for (int i = 0; i < Rumus.coloumAndGain.Count; i++)
               {
                   if (Rumus.coloumAndGain[i].Coloum == "Jenis_beasiswa")
                   {
                       AtributMahasiswa.Add(mahasiswa.Jenis_beasiswa);
                   }
                   else if (Rumus.coloumAndGain[i].Coloum == "ipk")
                   {
                       AtributMahasiswa.Add(mahasiswa.ipk);
                   }
                   else if (Rumus.coloumAndGain[i].Coloum == "Aktif_Organisasi")
                   {
                       AtributMahasiswa.Add(mahasiswa.aktif_organisasi);
                   }
                   else if (Rumus.coloumAndGain[i].Coloum == "Financial")
                   {
                       AtributMahasiswa.Add(mahasiswa.Financial);
                   }
                   else if (Rumus.coloumAndGain[i].Coloum == "Prestasi")
                   {
                       AtributMahasiswa.Add(mahasiswa.prestasi);
                   }

               }


               mahasiswa.diterima = MakeTree.Tree(0, 0);

               return mahasiswa.diterima;

      
           }
           public static string CheckIfEmpty(object A)                             //Mengecek apakah inputan di datagridview kosong
           {
               string Hasil = "";
               if (A != null)
               {
                   Hasil = A.ToString();
               }
               return Hasil;
           }
           public static DataTable SQLscriptExecute(string script)                // Query Script Execute 
           {

               if (script.Length == 0)
               {
                   return null;
               }

               CheckConnection();
               try
               {
                   
                   MySqlCommand command = new MySqlCommand(script, connection);
                   command.ExecuteNonQuery();
                   MySqlDataAdapter adapter = new MySqlDataAdapter(command);
                   DataTable dt = new DataTable();
                   adapter.Fill(dt);
                   logForm.addText(script + "\n",Color.MediumSlateBlue);
                   return dt;
                   

               }
               catch (MySqlException ex)
               {
                   errorMessage = ex.Message;                                 
                   logForm.addText(errorMessage + "\n",Color.Red);
                   ErrorForm.MessageError.Text = errorMessage;
                   ErrorForm.ScriptBox.Text = script;
                   ErrorForm.ShowDialog();
                   
             
                   return null;
               }

           }

        #endregion

        #region Method
           public static void CheckConnection()                                    //Mengecek Koneksi
           {
               if (connection.State == System.Data.ConnectionState.Closed)
               {
                   connection.Open();
               }
           }
           public static void Login(string password)                               //Login ke Database dan membuka Form Data
           {

               try
               {
                   SplashScreen SS = new SplashScreen();
                   logForm = new Log();                 
                   data = new Data();
                   MP = new MusicPlayer();
                   data.updateJudul();
                   ErrorForm = new MessageForm("","");
                   string config = "datasource=localhost;username=root;password=" + password + ";database=beasiswa";
                   connection = new MySqlConnection(config);
                   connection.Open();
                   errorMessage = "";                  
                   form1.Hide();
                   data.Show();
                   SS.ShowDialog(data);
                   

               }
               catch (MySqlException ex)
               {
                   errorMessage = ex.Message;

               }

           }
           public static void AddData()                                            // Penambahan data dari DataGridView 
           {


               mahasiswa = new Mahasiswa[data.InputData.Rows.Count - 1];

               for (int rows = 0; rows < data.InputData.Rows.Count - 1; rows++)    // Baca data dari gridview
               {
                   
                   mahasiswa[rows].Npm = CheckIfEmpty(data.InputData.Rows[rows].Cells[0].Value);
                   mahasiswa[rows].Nama = CheckIfEmpty(data.InputData.Rows[rows].Cells[1].Value);
                   mahasiswa[rows].Jenis_beasiswa = CheckIfEmpty(data.InputData.Rows[rows].Cells[2].Value);
                   mahasiswa[rows].ipk = CheckIfEmpty(data.InputData.Rows[rows].Cells[3].Value);
                   mahasiswa[rows].aktif_organisasi = CheckIfEmpty(data.InputData.Rows[rows].Cells[4].Value);
                   mahasiswa[rows].Financial = CheckIfEmpty(data.InputData.Rows[rows].Cells[5].Value);
                   mahasiswa[rows].prestasi = CheckIfEmpty(data.InputData.Rows[rows].Cells[6].Value);
                   mahasiswa[rows].diterima = CheckIfEmpty(data.InputData.Rows[rows].Cells[7].Value);



                   if (data.Algoritm.SelectedItem == data.Algoritm.Items[1])
                   {
                                        
                       data.InputData.Rows[rows].Cells[7].Value = DecisionResult(mahasiswa[rows],rows);                    
                       
                   }

                   
               }

           }
           public static void AddToDatabase(Mahasiswa mahasiswa){
               CheckConnection();
               string script = "";
               if (mahasiswa.prestasi.Length > 0)
               {
                   script = "INSERT INTO `db_ai`.`beasiswa` (`Npm`, `Nama`, `Jenis_beasiswa`, `ipk`, `Aktif_Organisasi`, `Financial`,`Prestasi`, `Diterima`) VALUES ('" + mahasiswa.Npm + "', '" + mahasiswa.Nama + "', '" + mahasiswa.Jenis_beasiswa + "', '" + mahasiswa.ipk + "', '" + mahasiswa.aktif_organisasi + "', '" + mahasiswa.Financial + "', '" + mahasiswa.prestasi + "', '" + mahasiswa.diterima + "');";
               }
               else {
                   script = "INSERT INTO `db_ai`.`beasiswa` (`Npm`, `Nama`, `Jenis_beasiswa`, `ipk`, `Aktif_Organisasi`, `Financial`, `Diterima`) VALUES ('" + mahasiswa.Npm + "', '" + mahasiswa.Nama + "', '" + mahasiswa.Jenis_beasiswa + "', '" + mahasiswa.ipk + "', '" + mahasiswa.aktif_organisasi + "', '" + mahasiswa.Financial + "', '" + mahasiswa.diterima + "');";
               }
               
               try
               {
                   
                   MySqlCommand command = new MySqlCommand (script, connection);
                   command.ExecuteNonQuery();
                   logForm.addText(script + "\n", Color.Olive);
                   connection.Close();
               }
               catch (MySqlException ex)
               {                
                   errorMessage = ex.Message;
                   ErrorForm = new MessageForm(script, errorMessage);
                   logForm.addText(errorMessage + "\n", Color.Red);
                   ErrorForm.Show();
               }
           }
           public static void Delete() // Delete Data from Database
           {
               DialogResult result = MessageBox.Show("Are you sure want to delete?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

               if (result == DialogResult.Yes)
               {
                   if (data.DataView.SelectedRows.Count > 0)
                   {
                       foreach (DataGridViewRow Current in data.DataView.SelectedRows)
                       {

                           string NPM = data.DataView[0, Current.Index].Value.ToString();
                           DatabaseScript.SQLscriptExecute("DELETE FROM `db_ai`.`beasiswa` WHERE `Npm`='" + NPM + "';");
                       }


                   }

                   data.Refresh.PerformClick();
                   data.ValueView();
               }
           }
           public static void EditData() // Edit Data From Database
           {

               DialogResult result = MessageBox.Show("Data will be deleted first. Do you want to process?", "", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
               if (result == System.Windows.Forms.DialogResult.Yes)
               {
                   int rows  = data.DataView.SelectedRows.Count;
                   int PrimaryKey = 0;
                   bool FoundPK = false;

                   for (int i = 0; i < data.DataView.ColumnCount;i++ )
                   {
                       if(data.DataView.Columns[i].Name == "Npm"){
                           PrimaryKey = i;
                           FoundPK = true;
                       }
                   }

                   if (rows > 0 && FoundPK == true)
                   {
                       
                       data.ClearData.PerformClick();
                       string script = "select *from beasiswa where ";
                       bool Can = true;
                       foreach (DataGridViewRow Current in data.DataView.SelectedRows)
                       {
                           string NPM = data.DataView[0, Current.Index].Value.ToString();
                           
                           if (Can)
                           {
                               script += " NPM = '" + NPM + "' ";
                               Can = false;
                           }
                           else
                           {
                               script += "or NPM = '" + NPM + "' ";

                           }

                       }
                       script += ";";
                       DataTable dt = DatabaseScript.SQLscriptExecute(script);
                       DataTableReader read = dt.CreateDataReader();
                       data.InputData.Rows.Add(rows);
                       int i = 0;
                       
                       while (read.Read())
                       {
                           for (int j = 0; j < 8; j++)
                           {
                               data.InputData[j, i].Value = read.GetValue(j).ToString();
                               
                           }
                           DatabaseScript.SQLscriptExecute("DELETE FROM `db_ai`.`beasiswa` WHERE `Npm`='" + data.InputData[0, i].Value.ToString() + "';");
                           i++;
                       }


                   }
                   
                   data.Refresh.PerformClick();
                   

               }

           }
           public static void BackUp() {
               CheckConnection();
               DialogResult result = data.SaveSQL.ShowDialog();               
               string file = data.SaveSQL.FileName;
              
               if(result == DialogResult.OK){                             
                  
                   try
                   {
                       MySqlCommand cmd = new MySqlCommand();
                       MySqlBackup bk = new MySqlBackup(cmd);
                       cmd.Connection = connection;
                       bk.ExportToFile(file);
                       connection.Close();
                       MessageBox.Show("Export Completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                       
                   }
                   catch (MySqlException ex)
                   {                    
                       logForm.addText(ex.Message + "\n", Color.Red);
                       ErrorForm.MessageError.Text = ex.Message;                 
                       ErrorForm.ShowDialog();
                   }

                   
               }
          }
           public static void Import() {
               CheckConnection();
               DialogResult result = data.OpenFile.ShowDialog();
               string file = data.OpenFile.FileName;
              
             
                   if(result == DialogResult.OK){
                       StreamReader readFile = new StreamReader(file);
                       string script = readFile.ReadToEnd();
                       
                             try
                            {
                       
                       
                                MySqlCommand cmd = new MySqlCommand();
                                MySqlBackup bk = new MySqlBackup(cmd);
                                cmd.Connection = connection;
                                bk.ImportFromFile(file);
                                connection.Close();
                                logForm.addText(script + "\n", Color.MistyRose);
                                MessageBox.Show("Import Completed", "", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                data.Refresh.PerformClick();                              
                                data.ValueView();


                            }
                            catch (MySqlException ex)
                            {
                                
                                ErrorForm = new MessageForm(script,ex.Message);
                                logForm.addText(script + "\n", Color.Red);
                                ErrorForm.ShowDialog();
                            }

                       
                   }               
            }
                    
        #endregion

        #region Other
                      
        #endregion

    }              
}
