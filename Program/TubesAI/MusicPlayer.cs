using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace TubesAI
{
    public partial class MusicPlayer : Form
    {

        public WindowsMediaPlayer player = new WindowsMediaPlayer();
        private IWMPMedia[] media;
        private IWMPPlaylist Playlist;

      
        public MusicPlayer()
        {
            InitializeComponent();
            addPlaylist();
            
        }

     
        private void Music_List_SelectedIndexChanged(object sender, EventArgs e)
        {

            player.controls.playItem(media[Music_List.SelectedIndex]);
            DatabaseScript.data.updateJudul();
                    
        }

        public void addPlaylist(){

            Playlist = player.playlistCollection.getAll().Item(0);
            int jmlhMusic = Playlist.count;
            media = new IWMPMedia[jmlhMusic];
            

            for (int i = 0; i < jmlhMusic; i++)
            {
                media[i] = Playlist.get_Item(i);
                Music_List.Items.Add(media[i].name);
            }

            player.currentPlaylist = Playlist;
            play();
            
        }

        public void play() {
        
            player.controls.play();
           
        }

        public void Stop() {
            player.controls.stop();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stop();
        }

        public void next() {
            player.controls.next();
            
        }

        public void previous() {
            player.controls.previous();
        }

        public string GetName() {
         
           return player.currentMedia.name;
        }

        private void Hide_Click(object sender, EventArgs e)
        {
            this.Hide();
            
        }

        private void player_CurrentItemChange(object sender, AxWMPLib._WMPOCXEvents_CurrentItemChangeEvent e)
        {
            MessageBox.Show(player.currentMedia.name);
        }

        public string UpdateJudul() {
           return player.currentMedia.name;
        }
      
    }
}
