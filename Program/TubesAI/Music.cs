using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Media;
using System.IO;

namespace TubesAI
{
    class Music
    {
        public static SoundPlayer player = new SoundPlayer();

        public static void PlayMusic(Stream filename ) {
            player.Stream = filename;
            player.PlayLooping ( );
                    
        }

        public static void Stop() {
            player.Stop();
        }
    }
}
